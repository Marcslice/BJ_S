﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace BJ_S
{
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

        private void btnMiser_hover(object sender, EventArgs e) {
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

        private void btnExpendHover(object sender, EventArgs e) {
            Button bt = (Button)sender;
            bt.BackColor = Color.Black;

            bt.BackgroundImage = Image.FromFile("../../images/"+bt.Name+"On.png");
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
            if(hovered != selected)
                hovered.BackgroundImage = Image.FromFile("../../images/" + hovered.Name + "Out.png");
            else
                hovered.BackgroundImage = Image.FromFile("../../images/" + hovered.Name + "On.png");
        }

        private void btnExtendfeedClick(object sender, EventArgs e) {
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
                for (int x = 4; x > 0; x--)
                    feed[x].Visible = false;
                this.buttonExpendFeed.BackgroundImage = Image.FromFile("../../images/buttonExpendFeed.png");
                this.buttonExpendFeed.Name = "buttonExpendFeed";
            }
        }

        public void MettreAJourFileEvenement(string update) {

            lblFeed5.Text = lblFeed4.Text;
            lblFeed4.Text = lblFeed3.Text;
            lblFeed3.Text = lblFeed2.Text;
            lblFeed2.Text = lblFeed1.Text;

            lblFeed1.Text = update;
        }

        public delegate void d_BloquerMise();

        public void BloquerMise() {
            this.btnMiser.Enabled = false;
            this.jeton10.Enabled = false;
            this.jeton25.Enabled = false;
            this.jeton50.Enabled = false;
        }

        public delegate void d_DebloquerMise();
        public void DebloquerMise() {
            this.btnMiser.Enabled = true;
            this.jeton10.Enabled = true;
            this.jeton25.Enabled = true;
            this.jeton50.Enabled = true;
        }

        public delegate void d_MettreAJourEncaisseJoueur();
        public void MettreAJourEncaisseJoueur()
        {
            this.lblMontantPorteFeuille.Text = m_Controleur.Moi.Encaisse.ToString();
        }

        public delegate void d_MettreAJourMainJoueur();
        public void MettreAJourMainJoueur() {
            this.lblMainCalcule.Text = m_Controleur.Moi.ValeurMain.ToString();
        }


        public delegate void d_MettreAJourNomSiege();
        public void MettreAJourNomSiege() {
            this.lblJ1.Text = m_Controleur.Moi.Nom;
        }

        public void MontrerCarte(string carte) //Tourne la carte du côté visible
        {
            foreach (Control ctl in mainCroupier.Controls) 
            {
                if (ctl.Tag.Equals("dos")) 
                {
                    ctl.BackgroundImage = Image.FromFile($@"..\..\images\cartes\{carte}.png");
                    ctl.Tag = "face";
                }
            }
        }

        public delegate void d_BloquerInterface(bool bloquerMise);

        public void BloquerInterface(bool bloquerMise) //Pour les joueurs qui passent un tour.
        {
            if(bloquerMise)
                BloquerMise();

            this.btnHit.Enabled = false;
            this.btnStand.Enabled = false;
            this.buttonExpendFeed.Enabled = false;
        }

        public delegate void d_DebloquerInterface(bool debloquerMise);

        public void DebloquerInterface(bool debloquerMise)
        {
            if(debloquerMise)
                DebloquerMise();

            this.btnHit.Enabled = true;
            this.btnStand.Enabled = true;
            this.buttonExpendFeed.Enabled = true;
        }

        public delegate void d_AfficherTimer(bool visible);
        public void AfficherTimer(bool visible) {
            this.lblTimer.Visible = visible;
            this.lblTimer.BringToFront();
        }

        public delegate void d_MettreAJourTimer(int sec);
        public void MettreAJourTimer(int sec) {

            string texte = this.lblTimer.Text;

            int tempRestant = Int32.Parse(texte.Split(new char[1] { ' ' },10, StringSplitOptions.RemoveEmptyEntries)[2]);

            this.lblTimer.Text = $"Vous avez {tempRestant - 1} secondes pour miser.";
        }

        private void btnHit_Click(object sender, EventArgs e) // HIT!
        {
            m_Controleur.Hit(m_Controleur.Moi);
        }

        private void btnStand_Click(object sender, EventArgs e) //STAND !
        {
            m_Controleur.Stand();
        }

        private void btnMiser_Click(object sender, EventArgs e) // MISE !
        {
            if (selected != null)
            {

                if (selected == jeton10)
                    Invoke(new Partie.d_Miser(m_Controleur.Miser),10);
                else if (selected == jeton25)
                    Invoke(new Partie.d_Miser(m_Controleur.Miser),25);
                else if (selected == jeton50)
                    Invoke(new Partie.d_Miser(m_Controleur.Miser),50);
            }
        }
    }
}
