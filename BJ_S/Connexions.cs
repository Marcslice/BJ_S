using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace BJ_S
{
    class Connexions
    {
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


        public string AttendreSonTour()
        {
            return sr.ReadLine();
        }

        public void Parler(string protocole)
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

            //canal.Shutdown(SocketShutdown.Both);
            // canal.Disconnect(false);
            // canal.Close();

            invite.Dispose();
            invite.Dispose();
        }
    }
}
