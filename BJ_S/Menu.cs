using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BJ_S
{
    public partial class Menu : Form
    {
        //main thread
        Label titre;
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

        public string DemanderNomJoueur() {
            Form nom = new Form();

            //PANEL
            nom.AutoSize = true;
            nom.MaximizeBox = false;
            nom.MinimizeBox = false;
            nom.Size = new Size(360, 100);
            nom.Name = "Nom";
            nom.Text = "Nom";
            nom.StartPosition = FormStartPosition.Manual;
            nom.Location = new Point(this.Location.X + this.Width / 2 - 200, this.Location.Y + this.Height / 2);
            nom.FormClosing += new FormClosingEventHandler(this.RejoindreAdresse_Close);

            //Controls
            Label msg = new Label();
            msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            msg.Width = 350;
            msg.Height = 30;
            msg.Location = new Point(10, 10);
            msg.Text = "Quel nom voulez-vous utiliser pour la partie ?";

            TextBox qui = new TextBox();
            qui.Size = new Size(200, 40);
            qui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qui.Location = new Point(10, 50);

            Button OK = new Button();
            OK.Text = "Rejoindre";
            OK.Size = new Size(100, 40);
            OK.Location = new Point(messages.Width - 110, messages.Height - 60);
            OK.Click += new EventHandler(this.AfficherRejoindre);

            messages.Controls.Add(msg);
            messages.Controls.Add(qui);
            messages.Controls.Add(OK);

            nom.BringToFront();
            nom.Show();

            return "skr";
        
        }

        private void RetourAuMenu_Click(object sender, EventArgs e) {
            Panel toRemove = (Panel)this.Controls[this.Controls.Count - 1];
            this.Controls.RemoveAt(this.Controls.Count - 1);
            toRemove.Dispose();
            this.panelPrincipale.Visible = true;
        }

        private void RejoindreAdresse_Close(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
        }

        private void Rejoindre_Click(object sender, EventArgs e)
        {
            this.messages = new Form();

            if (!messages.Visible)
            {

                //PANEL
                messages.AutoSize = true;
                messages.MaximizeBox = false;
                messages.MinimizeBox = false;
                messages.Size = new Size(360, 100);
                messages.Name = "Adresse IP";
                messages.Text = "Adresse IP";
                messages.StartPosition = FormStartPosition.Manual;
                messages.Location = new Point(this.Location.X + this.Width / 2 - 200, this.Location.Y + this.Height / 2);
                messages.FormClosing += new FormClosingEventHandler(this.RejoindreAdresse_Close);

                //Controls
                Label msg = new Label();
                msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                msg.Width = 350;
                msg.Height = 30;
                msg.Location = new Point(10, 10);
                msg.Text = "Entrez l'adresse de l'hôte que vous voulez rejoidre.";

                TextBox qui = new TextBox();
                qui.Size = new Size(200, 40);
                qui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                qui.Location = new Point(10, 50);

                Button OK = new Button();
                OK.Text = "Rejoindre";
                OK.Size = new Size(100, 40);
                OK.Location = new Point(messages.Width - 110, messages.Height - 60);
                OK.Click += new EventHandler(this.AfficherRejoindre);

                messages.Controls.Add(msg);
                messages.Controls.Add(qui);
                messages.Controls.Add(OK);
            }

            this.Enabled = false;
            messages.BringToFront();
            messages.Show();
        }

        private void Heberger_Click(object sender, EventArgs e)
        {

            Panel panelAttente = new Panel();

            titre = new Label();
            titre.Text = "En attente de joueurs.";
            titre.Size = new Size(300, 50);
            titre.Location = new Point(this.Width / 2 - 150, this.Height / 2 - 25);
            titre.TextAlign = ContentAlignment.MiddleCenter;

            Label nbJoueurActuel = new Label();
            nbJoueurActuel.Text = "X";
            nbJoueurActuel.Size = new Size(20, 50);
            nbJoueurActuel.Location = new Point(this.Width / 2 - 25, this.Height / 2 + 70);
            nbJoueurActuel.TextAlign = ContentAlignment.MiddleCenter;

            Label nbJoueurRequis = new Label();
            nbJoueurRequis.Text = " / 4";
            nbJoueurRequis.Size = new Size(60, 50);
            nbJoueurRequis.Location = new Point(this.Width / 2 - 15, this.Height / 2 + 70);
            nbJoueurRequis.TextAlign = ContentAlignment.MiddleCenter;

            Button retour = new Button();
            retour.Text = "Retour au menu";
            retour.Size = new Size(200, 50);
            retour.Location = new Point(50, 50);
            retour.TextAlign = ContentAlignment.MiddleCenter;
            retour.Click += new EventHandler(this.RetourAuMenu_Click);

            panelAttente.Size = new Size(1000, 800);
            panelAttente.Location = new Point(0, 0);

            this.panelPrincipale.Visible = false;

            panelAttente.Controls.Add(titre);
            panelAttente.Controls.Add(retour);
            // panelAttente.Controls.Add(nbJoueurActuel);
            // panelAttente.Controls.Add(nbJoueurRequis);
            panelAttente.ForeColor = Color.White;
            panelAttente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            panelAttente.BringToFront();
            this.Controls.Add(panelAttente);
            int compteur = 1;

            Thread t = new Thread(new ThreadStart(delegateMessage));
            t.Start();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            m_BJController.Quitter();
        }

        private void button_Local_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            btn.BackgroundImage = Image.FromFile("../../images/carteLocalOn.png");
        }
        private void button_Heberger_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackgroundImage = Image.FromFile("../../images/carteHebergerOn.png");
        }
        private void button_Rejoindre_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackgroundImage = Image.FromFile("../../images/carteRejoindreOn.png");
        }
        private void button_Quitter_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackgroundImage = Image.FromFile("../../images/porteOuverte.png");
        }

        private void button_Local_Out(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = Image.FromFile("../../images/carteLocalOut.png");
        }

        private void button_Heberger_Out(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = Image.FromFile("../../images/carteHebergeOut.png");
        }
        private void button_Rejoindre_Out(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = Image.FromFile("../../images/carteRejoindreMouseOut.png");

        }
        private void button_Quitter_Out(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = Image.FromFile("../../images/porteFermer.png");
        }

        private void AfficherRejoindre(object sender, EventArgs e) 
        {

            Button rj = (Button)sender;
            Form rjf = (Form)rj.GetContainerControl();
            rjf.Close();

            Panel panelAttente = new Panel();
            
            titre = new Label();
            titre.Text = "Recherche de partie.";
            titre.Size = new Size(300, 50);
            titre.Location = new Point(this.Width / 2 - 150, this.Height / 2 - 25);
            titre.TextAlign = ContentAlignment.MiddleCenter;

            Label status = new Label();
            status.Size = new Size(500, 50);
            status.Text = "Partie trouvée, en attente de joueur.";
            status.Location = new Point(this.Width / 2 - 250, this.Height / 2 + 30);
            status.TextAlign = ContentAlignment.MiddleCenter;

            Label nbJoueurActuel = new Label();
            nbJoueurActuel.Text = "X";
            nbJoueurActuel.Size = new Size(20,50);
            nbJoueurActuel.Location = new Point(this.Width / 2 - 25, this.Height / 2 + 70);
            nbJoueurActuel.TextAlign = ContentAlignment.MiddleCenter;

            Label nbJoueurRequis = new Label();
            nbJoueurRequis.Text = " / 4";
            nbJoueurRequis.Size = new Size(60, 50);
            nbJoueurRequis.Location = new Point(this.Width / 2 - 15, this.Height / 2 + 70);
            nbJoueurRequis.TextAlign = ContentAlignment.MiddleCenter;

            Button retour = new Button();
            retour.Text = "Retour au menu";
            retour.Size = new Size(200, 50);
            retour.Location = new Point(50, 50);
            retour.TextAlign = ContentAlignment.MiddleCenter;
            retour.Click += new EventHandler(this.RetourAuMenu_Click);

            panelAttente.Size = new Size(1000, 800);

            panelAttente.Location = new Point(0, 0);

            this.panelPrincipale.Visible = false;

            panelAttente.Controls.Add(titre);
            panelAttente.Controls.Add(retour);
           // panelAttente.Controls.Add(status);
           // panelAttente.Controls.Add(nbJoueurActuel);
           // panelAttente.Controls.Add(nbJoueurRequis);
            panelAttente.ForeColor = Color.White;
            panelAttente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            panelAttente.BringToFront();
            this.Controls.Add(panelAttente);
          
            Thread t = new Thread(new ThreadStart(delegateMessage));
            t.Start();
                
        }



        //subThread


        //Loading animation
        
        private void delegateMessage()
        {
          

            int compteur = 1;
            while (compteur < 22) //while connection pas connecter
            {

                Invoke(new updateWaitingMessage(UpdateMessage));
                compteur++;

                Thread.Sleep(400);
                compteur++;
            }
        }

        private void UpdateMessage()
        {
            if (titre.Text.Equals("Recherche de partie..."))
                titre.Text = "Recherche de partie.";
            else if (titre.Text.Equals("En attente de joueurs..."))
                titre.Text = "En attente de joueurs.";
            else
                titre.Text += ".";
        }

        public delegate void updateWaitingMessage();

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
