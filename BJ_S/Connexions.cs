using System.IO;
using System.Net.Sockets;

namespace BJ_S
{
    /// <summary>
    /// Classe gérant la connectivité entre plusieurs joueurs.
    /// Les joueurs en mode écoute reçoivent de l'information provenent du server.
    /// Le joueur en mode parlé envoie l'information au serveur.
    /// </summary>
    class Connexions
    {
        TcpListener receptionniste;
        TcpClient invite;
        Socket[] canals;
        NetworkStream ns;
        StreamWriter sw;
        StreamReader sr;


        public Connexions(bool hote, string adresseIP)
        {
            if (hote)
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
                receptionniste = new TcpListener(ip, 777);
                canals = new Socket[4];
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
                catch
                {

                }
            }

            sw = new StreamWriter(ns);
            sr = new StreamReader(ns);
        }


        /// <summary>
        /// L'hôte attend jusqu'à temps que le nombre de connexions équivaut un nombre de joueurs désiré.
        /// </summary>
        public void AccueillirInvites()
        {
            receptionniste.Start();
            //while(nbJoueurConnecté < nombreAttendu)
            //canal = receptionniste.AcceptSocket();
            //canals[0] = new Socket(canal);
        }

        /// <summary>
        /// État d'écoute pour les joueurs qui attendent.
        /// </summary>
        /// <returns>string : protocole dictant le déroulement de partie</returns>
        public string AttendreSonTour()
        {
            return sr.ReadLine();
        }

        /// <summary>
        /// Lorsque le joueur effectue une action elle est transmise au serveur.
        /// </summary>
        /// <param name="protocole">string : protocole formater pour que le serveur puisse distribuer le message.</param>
        public void Parler(string protocole)
        {
            sw.WriteLine(protocole);
            sw.Flush();
        }

        /// <summary>
        /// Détermine si le joueur utilisant cette connexion est l'hôte ou non.
        /// </summary>
        /// <returns>Vrai si le joueur a un tcplistener actif.
        ///          Faux si le tcpListener du joueur = nullà
        /// </returns>
        public bool EstReceptionniste()
        {
            if (receptionniste != null)
                return true;
            return false;
        }


        /// <summary>
        /// Permet de libérer les ressources utilisées par la connexion.
        /// </summary>
        public void Close()
        {
            receptionniste.Stop();
            invite.Close();

            sr.Close();
            sw.Close();
            ns.Close();

            //canal.Shutdown(SocketShutdown.Both);
            // canal.Disconnect(false);
            // canal.Close();

            invite.Dispose();
            invite.Dispose();
        }
    }
}
