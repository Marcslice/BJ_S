using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace BJ_S
{
    public class BlackuJacku
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        Menu m_Menu;
        Partie m_Partie;

        public BlackuJacku()
        {
            m_Menu = new Menu(this);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BlackuJacku BJ = new BlackuJacku();
            Application.Run(BJ.m_Menu);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">
        /// 0 -> local Humain
        /// 1 -> local Bot
        /// 2 -> Online Humain Guest
        /// 3 -> Online Bot Guest
        /// 4 -> Online Humain Host
        /// 5 -> ONline Bot Host
        /// </param>
        /// 
        public void NouvellePartie(int type)
        {
            NomDeJoueur f = new NomDeJoueur();

            f.ShowDialog(m_Menu);

            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                m_Partie = new Partie(1, 4, false, f.get_Name());
        }

        /// <summary>
        /// Quit l'application.
        /// </summary>
        public void Quitter()
        {          
            Application.Exit();
        }

        /// <summary>
        /// Demande ton ip externe à un serveur et l'affiche dans le menu principale.
        /// </summary>
        /// <returns>String : IP Formatté</returns>
        public string QuelEstMonIP()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }
    }
}
