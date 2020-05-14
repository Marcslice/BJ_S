using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace BJ_S
{
    public class BlackuJacku
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        Menu m_Menu;
        Partie m_Partie;

        public BlackuJacku() {
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
        public void NouvellePartie(int type) {
            //m_Partie = new Partie(type); 
        }

        public string QuelEstMonIP() {
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
