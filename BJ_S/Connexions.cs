using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace BJ_S
{
    /*Protocole:
     * 1. Serveur attend la mise de ceux qui vont joueur.
     * 2. Chacun envoie un message : Joueur / Passer.
     * 3. Serveur diffuse message a tous. 1er tour, chaque joueur update son interface/données membre suite à la réception du message du serveur.
     * 4. Chaque joueur tombe en mode écoute par défaut et un joueur a un BJ, un flag se leve pour qu'il ne joue plus.
     * 5. Serveur Envoie message a joueur correspondant à Indice 
     * 6. Joueur dont la connexion correspond à l'indice du tableau de l'hôte tombe en mode "Parler"
     * 7. Joueur envoie son move. 
     * 8. Serveur reçoit réponse. 
     *      8.1. Si Joueur !Stand ou !Busted, serveur ne change pas de joueur, mais diffuse les mises à jour. Retour 8.
     *      8.2. Si Joueur Stand ou Busted, il se met en mode "Écoute", serveur diffuse mise à jour et incrémente indice de connexion. Retour 6.
     * 9. Lorsque le serveur sort de son tableau d'indice, il fait jouer le croupier. (loop until busted ou >= 16)
     *      9.1. Il révèle sa 2ieme carte.
     *      9.2. Stand ou Hit
     *      9.3. Diffuse la mise à jour aux autres.
     * 10. Serveur compare les mains. (Double mise des gagnants, redonne mise aux égalités)     
     * 11. Chacun des joueurs met à jour ses stats.
     * 12. Server Diffuse message fin.
     *      12.1. Reset des interfaces.
     *      
     * 
     * Format :
     * Type(Mise, Tour, MAJ, Fin), Action(Stand, Hit), Qui, TotalMain, Carte(carte ,null)
     * 
     * 
     * 
    */

    class Connexions
    {
        enum Evenement : ushort //bitshift use
        { 
            DEPART = 1, 
            MISE = 2, 
            ECOUTE = 4, 
            PARLE = 8, 
            MAJ = 16, 
            FIN = 32
        }

        TcpListener receptionniste;
        TcpClient invite;
        Socket[] canals;
        NetworkStream ns;
        StreamWriter sw;
        StreamReader sr;

        public Connexions(bool hote, string adresseIP) {
            if (hote)
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
                receptionniste = new TcpListener(ip,777);
                canals =  new Socket[4];
            }
            else 
            {
                System.Net.IPAddress ipDistant = System.Net.IPAddress.Parse(adresseIP);
                System.Net.IPEndPoint serveurDistant = new System.Net.IPEndPoint(ipDistant, 777);
                try
                {
                    invite = new TcpClient(serveurDistant);
                    ns = invite.GetStream();
                }
                catch { 
                
                }
            }

            sw = new StreamWriter(ns);
            sr = new StreamReader(ns);
        }

        public void AccueillirInvites() {
            receptionniste.Start();
            //while(nbJoueurConnecté < nombreAttendu)
            //canal = receptionniste.AcceptSocket();
            //canals[0] = new Socket(canal);
        }


        public void AttendreSonTour()
        {
            string message = "";
            do
                message = sr.ReadLine();
            while (Convert.ToInt32(message.Split(';',1)) == (int)Evenement.ECOUTE);
        }

        public void Parler(int protocole)
        {
            sw.WriteLine(protocole);
            sw.Flush();
        }

        public bool EstReceptionniste()
        {
            if (receptionniste != null)
                return true;
            return false;
        }

        public void Close()
        {
            receptionniste.Stop();
            invite.Close();

            sr.Close();
            sw.Close();
            ns.Close();

            // canal.Shutdown(SocketShutdown.Both);
            // canal.Disconnect(false);
            // canal.Close();

            invite.Dispose();
            invite.Dispose();
        }
    }
}
