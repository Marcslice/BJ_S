using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BJ_S
{
    /// <summary>
    /// Menu Principal
    /// </summary>
    public partial class Menu : Form
    {

        Label titre;
        BlackuJacku m_BJController;
        System.Windows.Forms.Timer t;
        bool estVirer = false;
        Button carteRetournee = null;
        const int NBMAXJOUEURS = 5;
        bool connexionEnCours = false;
        Thread enAttenteDeConnexion;

        public Menu(BlackuJacku BJ)
        {
            InitializeComponent();
            m_BJController = BJ;
            this.lblIP.Text = m_BJController.QuelEstMonIP();
        }


        /// <summary>
        /// Créer un panneau pour afficher l'écran de chargement pour la recherche de partie et l'attente d'hébergement.
        /// </summary>
        /// <param name="sender"></param>
        private void AfficherLoadingScreen(object sender)
        {

            Button clicked = (Button)sender;
            Panel panelAttente = new Panel();

            titre = new Label();

            if (clicked.Name.Equals("btnLancerRejoindre"))
                titre.Text = "Recherche de partie.";
            else
                titre.Text = "En attente de joueurs.";

            titre.Size = new Size(300, 50);
            titre.Location = new Point(this.Width / 2 - 150, this.Height / 2 - 25);
            titre.TextAlign = ContentAlignment.MiddleCenter;

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
            panelAttente.ForeColor = Color.White;
            panelAttente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            panelAttente.BringToFront();
            this.Controls.Add(panelAttente);

            enAttenteDeConnexion = new Thread(new ThreadStart(EcranDeChargement));
            enAttenteDeConnexion.Start();
        }

        /// <summary>
        /// Appeler par le nouveau thread afin d'animer l'écran de chargement.
        /// </summary>
        private void EcranDeChargement()
        {
            connexionEnCours = true;
            while (connexionEnCours)
            {
                Invoke(new d_MettreAJourEcranChargement(MettreAJourEcranChargement));
                Thread.Sleep(400);
            }
        }

        /// <summary>
        /// Permet d'animer l'écran de chargement tout en pouvant cliquer sur quitter ou retour au menu principal.
        /// </summary>
        public delegate void d_MettreAJourEcranChargement();
        private void MettreAJourEcranChargement()
        {
            if (titre.Text.Equals("Recherche de partie..."))
                titre.Text = "Recherche de partie.";
            else if (titre.Text.Equals("En attente de joueurs..."))
                titre.Text = "En attente de joueurs.";
            else
                titre.Text += ".";
        }

        /// <summary>
        /// Determine le déroulement de l'animation des cartes du menu principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="b">Bouton cliqué.</param>
        private void VirerCartes(object sender, EventArgs e, Button b)
        {
            t.Stop();

            if (b.Tag.Equals("facingUp"))
                VirerCartes(b, true);
            else
                VirerCartes(b, false);
        }


        /// <summary>
        /// Gère l'animation des cartes du menu principale.
        /// </summary>
        /// <param name="b">Bouton cliqué.</param>
        /// <param name="Envers">boolean déterminant le côté.</param>
        private void VirerCartes(Button b, bool Envers)
        {
            if (!estVirer)
            {
                b.Width -= 20;
                b.Location = new Point(b.Location.X + 10, b.Location.Y);
                if (carteRetournee != null && b != carteRetournee)
                {
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
                    estVirer = true;
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

                    estVirer = false;
                    t.Stop();
                    t.Dispose();
                    t = null;
                }
            }
        }

        /// <summary>
        /// Lors du pivot d'une carte dans le menu.
        /// Affiche ou cache les contrôles dépendamment du côté de la carte.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="afficher">
        ///     True : les contrôles seront affichés.
        ///     False : les contrôles seront cachés.
        /// </param>
        private void AfficherCacherBoutonDesCartes(Button b, bool afficher)
        {
            List<Control> listControls = b.Controls.OfType<Control>().ToList();
            foreach (Control d in listControls)
            {
                d.Visible = afficher;
                if (d.GetType().Name.Equals("Button"))
                    d.Enabled = afficher;
            }
        }

        /// <summary>
        /// Lors d'un click sur une carte du menu, démarre l'animation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Carte_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
            if (t == null)
            {
                t = new System.Windows.Forms.Timer();
                t.Interval = 1;
                t.Start();
                t.Tick += (sender2, e2) => VirerCartes(sender2, e2, b);
            }
            b.Enabled = true;
        }

        /// <summary>
        /// Ajoute ou soustrait le nombre de joueurs ou d'AIs sur la carte hébergement.
        /// </summary>
        /// <param name="sender">
        ///     Determine quel bouton a été cliqué.
        /// </param>
        private void TextBox_PlusMoins(object sender, EventArgs e)
        {
            int nbJoueurs, nbAIs;
            Control sw = (Button)sender;

            nbJoueurs = Int32.Parse(tBoxNbJoueur.Text);
            nbAIs = Int32.Parse(tBoxNbAI.Text);

            switch (sw.Name)
            {
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

        // *********************   Mouse events   *****************************

        private void CarteLocalHumain_Click(object sender, EventArgs e)
        {
            m_BJController.NouvellePartie(1);
        }

        private void Rejoindre_Click(object sender, EventArgs e)
        {
            AfficherLoadingScreen(sender);
        }

        private void Heberger_Click(object sender, EventArgs e)
        {
            AfficherLoadingScreen(sender);
        }

        /// <summary>
        /// Quitte l'application.
        /// Attend que les fils ont rejoint.
        /// </summary>

        private void Quit_Click(object sender, EventArgs e)
        {
            connexionEnCours = false;
            if (enAttenteDeConnexion != null && enAttenteDeConnexion.IsAlive)
                enAttenteDeConnexion.Join();

            m_BJController.Quitter();
        }

        private void button_Quitter_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = Image.FromFile("../../images/porteOuverte.png");
        }

        private void button_Card_Hover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.Equals("facingUp"))
                btn.BackgroundImage = Image.FromFile("../../images/" + btn.Name + "On.png");
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

        /// <summary>
        /// Retourne au menu principal
        /// Attent que l'animation de connexion se termine.
        /// </summary>
        private void RetourAuMenu_Click(object sender, EventArgs e)
        {
            Panel toRemove = (Panel)this.Controls[this.Controls.Count - 1];
            this.Controls.RemoveAt(this.Controls.Count - 1);
            toRemove.Dispose();
            this.panelPrincipale.Visible = true;
            connexionEnCours = false;

            if (enAttenteDeConnexion != null && enAttenteDeConnexion.IsAlive)
                enAttenteDeConnexion.Join();
        }

        private void carteLocalAI_Click(object sender, EventArgs e)
        {
            m_BJController.NouvellePartie(2);
        }
    }
}
