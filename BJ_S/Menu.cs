using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ_S
{
    public partial class Menu : Form
    {
        BlackuJacku m_BJController;
        public Menu(BlackuJacku BJ)
        {
            m_BJController = BJ;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.lblIP.Text = m_BJController.QuelEstMonIP();           
        }

        private void ReCalc(object sender, EventArgs e) {

        }

        private void Local_Click(object sender, EventArgs e)
        {
        }
        private void Rejoindre_Click(object sender, EventArgs e)
        {
        }
        private void Heberger_Click(object sender, EventArgs e)
        {
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttons_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Orange;
        }

        private void buttons_Out(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Name.Contains("btnQuitter"))
                btn.BackColor = Color.SpringGreen;         
            else
                btn.BackColor = Color.SteelBlue;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


    }
}
