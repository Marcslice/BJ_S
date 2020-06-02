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
        System.Windows.Forms.Timer t;
        bool flipped1 = false;
        Button carteRetournee = null;
        const int NBMAXJOUEURS = 5;
        bool connecting = false;
        Thread awaitsConnection;

        public Menu(BlackuJacku BJ)
        {
            m_BJController = BJ;
            InitializeComponent();
            this.lblIP.Text = m_BJController.QuelEstMonIP();
        }


        private void RetourAuMenu_Click(object sender, EventArgs e) {
            Panel toRemove = (Panel)this.Controls[this.Controls.Count - 1];
            this.Controls.RemoveAt(this.Controls.Count - 1);
            toRemove.Dispose();
            this.panelPrincipale.Visible = true;
            connecting = false;

            if (awaitsConnection != null & awaitsConnection.IsAlive)
                awaitsConnection.Join();
        }

        private void RejoindreAdresse_Close(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
        }

        private void Rejoindre_Click(object sender, EventArgs e)
        {

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

            awaitsConnection = new Thread(new ThreadStart(delegateMessage));
            awaitsConnection.Start();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            connecting = false;
            if (awaitsConnection != null & awaitsConnection.IsAlive)
                awaitsConnection.Join();

            m_BJController.Quitter();
        }

        private void button_Card_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Tag.Equals("facingUp"))
                btn.BackgroundImage = Image.FromFile("../../images/" + btn.Name + "On.png");
        }

        private void button_Quitter_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = Image.FromFile("../../images/porteOuverte.png");
        }

        private void button_Card_Out(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.Equals("facingUp"))
                btn.BackgroundImage = Image.FromFile("../../images/" + btn.Name + "Out.png");
        }

        private void button_Quitter_Out(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = Image.FromFile("../../images/porteFermer.png");
        }

        private void afficherLoadingScreen() {

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
            // panelAttente.Controls.Add(status);
            // panelAttente.Controls.Add(nbJoueurActuel);
            // panelAttente.Controls.Add(nbJoueurRequis);
            panelAttente.ForeColor = Color.White;
            panelAttente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            panelAttente.BringToFront();
            this.Controls.Add(panelAttente);
        }


        private void AfficherRejoindre(object sender, EventArgs e)
        {

            awaitsConnection = new Thread(new ThreadStart(delegateMessage));
            awaitsConnection.Start();
        }

        //subThread

        //Loading animation

        private void delegateMessage()
        {
            connecting = true;
            while (connecting) //while connection pas connecter
            {
                Invoke(new updateWaitingMessage(UpdateMessage));
                Thread.Sleep(400);
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

        private void flip(Button b, bool Envers)
        {
            if (!flipped1)
            {
                b.Width -= 20;
                b.Location = new Point(b.Location.X + 10, b.Location.Y);
                if (carteRetournee != null && b != carteRetournee) {
                    carteRetournee.Width -= 20;
                    carteRetournee.Location = new Point(carteRetournee.Location.X + 10, carteRetournee.Location.Y);
                }

                if (b.Width <= 20)
                {
                    if (!Envers)
                    {
                        b.BackgroundImage = Image.FromFile("../../images/" + b.Name + "Out.png");
                        b.Tag = "facingUp";
                        AfficherCacherBoutonDesCartes(carteRetournee, false);
                    }
                    else
                    {
                        b.BackgroundImage = Image.FromFile("../../images/carteFlipped.png");
                        b.Tag = "facingDown";
                        AfficherCacherBoutonDesCartes(b, true);
                    }

                    if (carteRetournee != null && b != carteRetournee)
                    {                      
                        if (carteRetournee.Width <= 20)
                        {
                            carteRetournee.BackgroundImage = Image.FromFile("../../images/" + carteRetournee.Name + "Out.png");
                            carteRetournee.Tag = "facingUp";
                            AfficherCacherBoutonDesCartes(carteRetournee, false);
                        }
                    }
                    flipped1 = true;                 
                }           
                t.Enabled = true;
            }
            else
            {
                if (b.Width <= 170)
                {
                    b.Width += 20;
                    if (b.Location.X < 10)
                        b.Location = new Point(0, b.Location.Y);
                    else
                        b.Location = new Point(b.Location.X - 10, b.Location.Y);

                    if (carteRetournee != null && carteRetournee.Width <= 170 && b != carteRetournee)
                    {
                        carteRetournee.Width += 20;
                        carteRetournee.Location = new Point(carteRetournee.Location.X - 10, carteRetournee.Location.Y);
                    }

                    t.Enabled = true;
                }
                else
                {
                    if (b != carteRetournee)
                        carteRetournee = b;
                    else
                        carteRetournee = null;

                    flipped1 = false;
                    t.Stop();
                    t.Dispose();
                    t = null;
                }
            }
        }

        private void AfficherCacherBoutonDesCartes(Button b, bool afficher) {
            List<Control> listControls = b.Controls.OfType<Control>().ToList();
            foreach (Control d in listControls)
            {
                d.Visible = afficher;
                if(d.GetType().Name.Equals("Button"))
                    d.Enabled = afficher;
            }
        }

        private void flip(object sender, EventArgs e, Button b)
        {
            t.Stop();

            if (b.Tag.Equals("facingUp"))
                flip(b, true);
            else
                flip(b, false);
        }

        private void cardClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
            if (t == null)
            {
                t = new System.Windows.Forms.Timer();
                t.Interval = 1;
                t.Start();
                t.Tick += (sender2, e2) => flip(sender2, e2, b);
            }
            b.Enabled = true;
        }

        private void tBoxPlusMoins(object sender, EventArgs e) 
        {
            int nbJoueurs, nbAIs;
            Control sw = (Button)sender;
            
            nbJoueurs = Int32.Parse(tBoxNbJoueur.Text);
            nbAIs = Int32.Parse(tBoxNbAI.Text);

            switch (sw.Name) {
                case "btnPlusJoueurs":
                    if (nbJoueurs < 5)
                    {
                        this.tBoxNbJoueur.Text = $"{++nbJoueurs}";
                        if ((nbJoueurs + nbAIs) > NBMAXJOUEURS)
                            this.tBoxNbAI.Text = $"{--nbAIs}";
                    }
                    break;
                case "btnPlusAI":
                    if (nbAIs < 3)
                    {
                        this.tBoxNbAI.Text = $"{++nbAIs}";
                        if ((nbJoueurs + nbAIs) > NBMAXJOUEURS)
                            this.tBoxNbJoueur.Text = $"{--nbJoueurs}";
                    }
                    break;
                case "btnMoinsJoueurs":
                    if (nbJoueurs > 1)
                        this.tBoxNbJoueur.Text = $"{--nbJoueurs}";
                    break;
                case "btnMoinsAI":
                    if (nbAIs > 0)
                        this.tBoxNbAI.Text = $"{--nbAIs}";
                    break;
            }           
        }


        // UTILITIES
        public Form FormBuilder(string nom, string titre, string message)
        {
            Form basic = new Form();
            basic.AutoSize = true;
            basic.MaximizeBox = false;
            basic.MinimizeBox = false;
            basic.Size = new Size(300, 100);
            basic.Name = nom;
            basic.Text = titre;
            basic.StartPosition = FormStartPosition.Manual;
            basic.Location = new Point(this.Location.X + this.Width / 2 - 200, this.Location.Y + this.Height / 2);
            basic.FormClosing += new FormClosingEventHandler(this.RejoindreAdresse_Close);

            Label lblMessage = new Label();
            lblMessage.Width = 260;
            lblMessage.Text = message;
            lblMessage.Location = new Point(0, 0);
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;

            Button ok = new Button();
            ok.Size = new Size(50, 30);
            ok.Location = new Point(220, basic.Height - 75);
            ok.Text = "OK";
            ok.Click += new System.EventHandler(CloseCustomForm);

            basic.Controls.Add(lblMessage);
            basic.Controls.Add(ok);

            return basic;
        }

        public void CloseCustomForm(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Form f = (Form)b.GetContainerControl();
            f.Close();
        }

        public Form AlerteBuilder(string nom, string titre, string message)
        {
            Form alert = FormBuilder(nom, titre, message);
            return alert;
        }

        public Form EntryBuilder(string nom, string titre, string message)
        {
            Form entryForm = FormBuilder(nom, titre, message);
            TextBox entry = new TextBox();
            entry.Location = new Point(10, 30);
            entry.Size = new Size(200, 50);

            entryForm.Controls.Add(entry);
            return entryForm;
        }

        private void carteLocalHumain_Click(object sender, EventArgs e)
        {
            m_BJController.NouvellePartie(1);
        }
    }
}
