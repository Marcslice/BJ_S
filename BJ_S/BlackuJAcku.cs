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
            BlackuJacku Controller = new BlackuJacku();
            Application.Run(Controller.m_Menu);
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
