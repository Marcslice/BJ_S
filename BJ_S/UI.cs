using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BJ_S
{

    /// <summary>
    /// Affiche et gère les actions de l'utilisateur pour le déroulement de la partie.
    /// </summary>
    public partial class UI : Form
    {
        Label[] feed = new Label[5];
        PictureBox selected;
        bool extended = false;
        Partie m_Controleur;

        public UI(Partie p_Controleur)
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            m_Controleur = p_Controleur;
            feed[0] = this.lblFeed1;
            feed[1] = this.lblFeed2;
            feed[2] = this.lblFeed3;
            feed[3] = this.lblFeed4;
            feed[4] = this.lblFeed5;
        }

        private void btnMiser_hover(object sender, EventArgs e)
        {
            this.btnMiser.BackgroundImage = Image.FromFile("../../images/buttonMiserOn.png");
        }

        private void btnMiser_Out(object sender, EventArgs e)
        {
            this.btnMiser.BackgroundImage = Image.FromFile("../../images/buttonMiserOut.png");
        }

        private void btnHit_hover(object sender, EventArgs e)
        {
            this.btnHit.BackgroundImage = Image.FromFile("../../images/buttonHitOn.png");
        }

        private void btnHit_Out(object sender, EventArgs e)
        {
            this.btnHit.BackgroundImage = Image.FromFile("../../images/buttonHitOut.png");
        }

        private void btnStand_hover(object sender, EventArgs e)
        {
            this.btnStand.BackgroundImage = Image.FromFile("../../images/buttonStandOn.png");
        }

        private void btnStand_Out(object sender, EventArgs e)
        {
            this.btnStand.BackgroundImage = Image.FromFile("../../images/buttonStandOut.png");
        }

        private void jetonsClick(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;

            if (selected != null)
            {
                selected.BackgroundImage = Image.FromFile("../../images/" + selected.Name + "Out.png");
            }
            if (clicked == selected)
            {
                selected = null;
            }
            else
            {
                clicked.BackgroundImage = Image.FromFile("../../images/" + clicked.Name + "On.png");
                selected = clicked;
            }
        }

        private void btnExpendHover(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.Black;

            bt.BackgroundImage = Image.FromFile("../../images/" + bt.Name + "On.png");
        }

        private void btnExpendOut(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackgroundImage = Image.FromFile("../../images/" + bt.Name + ".png");
        }

        private void jetonsHover(object sender, EventArgs e)
        {
            PictureBox hovered = (PictureBox)sender;
            hovered.BackgroundImage = Image.FromFile("../../images/" + hovered.Name + "Hover.png");
        }

        private void jetonsOut(object sender, EventArgs e)
        {
            PictureBox hovered = (PictureBox)sender;
            if (hovered != selected)
                hovered.BackgroundImage = Image.FromFile("../../images/" + hovered.Name + "Out.png");
            else
                hovered.BackgroundImage = Image.FromFile("../../images/" + hovered.Name + "On.png");
        }

        /// <summary>
        /// Développe la liste des événements passée.
        /// Cache la liste si déjà développée.
        /// </summary>
        private void btnExtendfeedClick(object sender, EventArgs e)
        {
            extended = !extended;
            if (extended)
            {
                feedPanel.Height = 200;
                this.buttonExpendFeed.Location = new Point(this.buttonExpendFeed.Location.X, this.buttonExpendFeed.Location.Y + 150);
                foreach (Label l in feed)
                    l.Visible = true;

                this.buttonExpendFeed.BackgroundImage = Image.FromFile("../../images/buttonCloseFeed.png");
                this.buttonExpendFeed.Name = "buttonCloseFeed";
            }
            else
            {
                feedPanel.Height = 50;
                this.buttonExpendFeed.Location = new Point(this.buttonExpendFeed.Location.X, this.buttonExpendFeed.Location.Y - 150);
                for (int x = 4; x > 0; x--)
                    feed[x].Visible = false;
                this.buttonExpendFeed.BackgroundImage = Image.FromFile("../../images/buttonExpendFeed.png");
                this.buttonExpendFeed.Name = "buttonExpendFeed";
            }
        }

        /// <summary>
        /// Met à jour le file d'événement pendant la partie, selon les joueurs et leurs actions.
        /// </summary>
        /// <param name="update">string : événement à afficher.</param>
        public delegate void d_MettreAJourFileEvenement(string update);
        public void MettreAJourFileEvenement(string update)
        {

            lblFeed5.Text = lblFeed4.Text;
            lblFeed4.Text = lblFeed3.Text;
            lblFeed3.Text = lblFeed2.Text;
            lblFeed2.Text = lblFeed1.Text;

            lblFeed1.Text = update;
        }

        /// <summary>
        /// En fin de partie, Réinitialise le file d'évènements.
        /// </summary>
        public delegate void d_ReinitialiserFileEvenement();
        public void ReinitialiserFileEvenement() {
            lblFeed1.Text = "";
            lblFeed2.Text = "";
            lblFeed3.Text = "";
            lblFeed4.Text = "";
            lblFeed5.Text = "";
        }

        /// <summary>
        /// Bloque la section de l'interface pour la mise.
        /// </summary>
        public delegate void d_BloquerMise();
        public void BloquerMise()
        {
            this.btnMiser.Enabled = false;
            this.jeton10.Enabled = false;
            this.jeton25.Enabled = false;
            this.jeton50.Enabled = false;
        }

        /// <summary>
        /// Débloque la section de l'interface pour la mise.
        /// </summary>
        public delegate void d_DebloquerMise();
        public void DebloquerMise()
        {
            this.btnMiser.Enabled = true;
            this.jeton10.Enabled = true;
            this.jeton25.Enabled = true;
            this.jeton50.Enabled = true;
        }

        /// <summary>
        /// Met à jour le montant en encaisse du joueur à l'écran.
        /// </summary>
        public delegate void d_MettreAJourEncaisseJoueur();
        public void MettreAJourEncaisseJoueur()
        {
            this.lblMontantPorteFeuille.Text = m_Controleur.Moi.Encaisse.ToString();
        }

        /// <summary>
        /// Affiche les cartes des joueurs actifs sur la table.
        /// Créer des PictureBox au besoin.
        /// </summary>
        /// <param name="j">Joueur.</param>
        /// <param name="siege">Index de joueur.</param>
        public delegate void d_MettreAJourMainJoueur(Joueurs j, int siege);
        public void MettreAJourMainJoueur(Joueurs j, int siege)
        {
            PictureBox carte;
            string carteNom;
            int index;

            if (m_Controleur.tabJoueur[0].Mise != 0)
                this.lblMainCalcule.Text = m_Controleur.Moi.ValeurMain.ToString();
            if (m_Controleur.tabJoueur[1].Mise != 0)
                this.M2.Text = m_Controleur.tabJoueur[1].ValeurMain.ToString();
            if (m_Controleur.tabJoueur[2].Mise != 0)
                this.M3.Text = m_Controleur.tabJoueur[2].ValeurMain.ToString();
            if (m_Controleur.tabJoueur[3].Mise != 0)
                this.M4.Text = m_Controleur.tabJoueur[3].ValeurMain.ToString();
            if (m_Controleur.tabJoueur[4].Mise != 0)
                this.M5.Text = m_Controleur.tabJoueur[4].ValeurMain.ToString();


            if (j.ValeurMain > 0)
            {
                foreach (Control ctls in this.Controls)
                {

                    if (ctls.Name.Equals($"mainJ{siege}") && ctls.GetType().Name.Equals("Panel"))
                    {
                        ctls.BackColor = Color.Transparent;
                        ctls.Visible = true;

                        if (ctls.Controls.Count < j.Main.NombresDeCarte())
                        {
                            PictureBox nouvelleCarte = new PictureBox();
                            nouvelleCarte.Name = $"c{j.Main.NombresDeCarte()}j{siege}";
                            nouvelleCarte.Width = 47;
                            nouvelleCarte.Height = 84;
                            nouvelleCarte.Location = new Point(29 + (42 * (j.Main.NombresDeCarte() - 1)), 5);

                            ctls.Controls.Add(nouvelleCarte);
                        }

                        foreach (Control card in ctls.Controls)
                        {
                            carte = (PictureBox)card;

                            carteNom = carte.Name;

                            index = Int32.Parse(carteNom.Substring(1, 1));

                            carte.BackgroundImage = Image.FromFile($@"{j.Main[index - 1].Image()}");
                            carte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

                            carte.Refresh();
                        }
                    }
                }
            }
            else
                ReinitialiserMainJoueur(j, siege);
        }

        /// <summary>
        /// Détruit les picturebox de trop des joueurs en fin de manche.
        /// </summary>
        /// <param name="j">Joueur</param>
        /// <param name="siege">Index du joueur.</param>
        void ReinitialiserMainJoueur(Joueurs j, int siege)
        {
            PictureBox carte;

            foreach (Control ctls in this.Controls)
            {

                if (ctls.Name.Equals($"mainJ{siege}") && ctls.GetType().Name.Equals("Panel"))
                {
                    ctls.BackColor = Color.Transparent;
                    ctls.Visible = false;

                    while (ctls.Controls.Count > 2)
                    {

                        foreach (Control card in ctls.Controls)
                        {
                            carte = (PictureBox)card;

                            if (!card.Name.Equals($"c1j{siege}") && !card.Name.Equals($"c2j{siege}"))
                            {
                                ctls.Controls.Remove(carte);
                            }
                            else
                            {
                                carte.BackgroundImage = null;
                            }
                        }
                    }
                }                 
            }     
        }

        /// <summary>
        /// Affiche les cartes du croupier sur la table. 
        /// Créer des pictureBox au besoin.
        /// </summary>
        /// <param name="croup"></param>
        /// <param name="tourCroupier"></param>
        public delegate void d_MettreAJourMainCroupier(Croupier croup, bool tourCroupier);
        public void MettreAJourMainCroupier(Croupier croup, bool tourCroupier)
        {

            PictureBox carte;
            string carteNom;
            int index;

            mainCroupier.BackColor = Color.Transparent;
            mainCroupier.Visible = true;

            this.MCroupier.Text = m_Controleur.croupier.ValeurMain.ToString();

            if (mainCroupier.Controls.Count < croup.Main.NombresDeCarte())
            {
                PictureBox nouvelleCarte = new PictureBox();
                nouvelleCarte.Name = $"cc{croup.Main.NombresDeCarte()}";
                nouvelleCarte.Width = 47;
                nouvelleCarte.Height = 84;
                nouvelleCarte.Location = new Point(29 + (42 * (croup.Main.NombresDeCarte() - 1)), 5);

                mainCroupier.Controls.Add(nouvelleCarte);
            }

            if (croup.Compte() > 0)
            {

                foreach (Control card in mainCroupier.Controls)
                {

                    carte = (PictureBox)card;
                    carteNom = carte.Name;

                    index = Int32.Parse(carteNom.Substring(2, 1));

                    if (carte.Name.Equals("cc1") || tourCroupier)
                    {
                        carte.BackgroundImage = Image.FromFile($@"{croup.Main[index - 1].Image()}");
                    }
                    else if (!tourCroupier && card.Name.Equals("cc2"))
                    {
                        carte.BackgroundImage = Image.FromFile($@"{croup.Main[index - 1].ImageDos()}");
                    }

                    carte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    carte.Visible = true;

                    carte.Refresh();
                }
            }
            else
                ReinitialiserMainCroupier();
        }

        /// <summary>
        /// En fin de manche, détruit les PictureBoxs de trop.
        /// </summary>
        void ReinitialiserMainCroupier()
        {
            PictureBox carte;

            mainCroupier.Visible = false;


            while (mainCroupier.Controls.Count > 2) {

                foreach (PictureBox pb in mainCroupier.Controls)
                {

                    carte = (PictureBox)pb;

                    if (!carte.Name.Equals($"cc1") && !carte.Name.Equals($"cc2"))
                    {
                        mainCroupier.Controls.Remove(carte);
                    }
                    else
                    {
                        carte.BackgroundImage = null;
                    }
                }
            }
            mainCroupier.Refresh();
        }

        /// <summary>
        /// Attribut les noms de joueurs aux sièges.
        /// </summary>
        /// <param name="i">Index de siège.</param>
        /// <param name="nom">string : nom</param>
        public delegate void d_MettreAJourNomSiege(int i, string nom);
        public void MettreAJourNomSiege(int i, string nom)
        {
            foreach (Control ctls in this.Controls)
            {
                if (ctls.GetType().Name.Equals("Label"))
                    if (ctls.Name.Equals($"lblJ{i}"))
                        ctls.Text = nom;
            }
            this.lblJ1.Text = m_Controleur.Moi.Nom;
        }

        /// <summary>
        /// Bloque les boutons de l'interface ainsi que la section mise.
        /// </summary>
        /// <param name="bloquerMise">
        ///     True = Bloquer section mise.
        ///     False = Ignorer section mise.
        /// </param>
        public delegate void d_BloquerInterface(bool bloquerMise);
        public void BloquerInterface(bool bloquerMise) //Pour les joueurs qui passent un tour.
        {
            if (bloquerMise)
                BloquerMise();

            this.btnHit.Enabled = false;
            this.btnStand.Enabled = false;
        }

        /// <summary>
        /// Débloque les boutons de l'interface ainsi que la section mise.
        /// </summary>
        /// <param name="debloquerMise">
        ///     True = Débloquer section mise.
        ///     False = Ignorer section mise.
        /// </param>
        public delegate void d_DebloquerInterface(bool debloquerMise);
        public void DebloquerInterface(bool debloquerMise)
        {
            if (debloquerMise)
                DebloquerMise();

            this.btnHit.Enabled = true;
            this.btnStand.Enabled = true;
        }


        /// <summary>
        /// Affiche ou cache le message de mise avec le timer.
        /// </summary>
        /// <param name="visible">
        ///     True : Afficher
        ///     False = Cacher;   
        /// </param>
        public delegate void d_AfficherTimer(bool visible);
        public void AfficherTimer(bool visible)
        {
            this.lblTimer.Visible = visible;
            this.lblTimer.BringToFront();
        }


        /// <summary>
        /// Met à jour le temps dans le message de mise.
        /// </summary>
        /// <param name="sec"></param>
        public delegate void d_MettreAJourTimer(int sec);
        public void MettreAJourTimer(int sec)
        {

            string texte = this.lblTimer.Text;

            int tempRestant = Int32.Parse(texte.Split(new char[1] { ' ' }, 10, StringSplitOptions.RemoveEmptyEntries)[2]);

            this.lblTimer.Text = $"Vous avez {tempRestant - 1} secondes pour miser.";
        }

        /// <summary>
        /// En début de manche, remet le bon temps dans le label.
        /// </summary>
        public delegate void d_ResetTimer();
        public void ResetTimer()
        {
            this.lblTimer.Text = "Vous avez 10 secondes pour miser.";
        }


        private void btnHit_Click(object sender, EventArgs e) // HIT!
        {
            m_Controleur.Hit(m_Controleur.Moi, 1);
        }

        private void btnStand_Click(object sender, EventArgs e) //STAND !
        {
            m_Controleur.Stand(m_Controleur.Moi);
        }

        private void btnMiser_Click(object sender, EventArgs e) // MISE !
        {
            if (selected != null)
            {

                if (selected == jeton10)
                    Invoke(new Partie.d_Miser(m_Controleur.Miser), 10);
                else if (selected == jeton25)
                    Invoke(new Partie.d_Miser(m_Controleur.Miser), 25);
                else if (selected == jeton50)
                    Invoke(new Partie.d_Miser(m_Controleur.Miser), 50);
            }
        }

        /// <summary>
        /// Tente de fermer les sous fils avant la fermeture.
        /// </summary>
        private void UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProcessThreadCollection currentThreads = Process.GetCurrentProcess().Threads;

            m_Controleur.TerminerPartie();

            foreach (ProcessThread thread in currentThreads)
            {
                thread.Dispose();
            }
        }
    }
}
