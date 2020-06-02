using System.Drawing;
namespace BJ_S
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPrincipale = new System.Windows.Forms.Panel();
            this.carteLocal = new System.Windows.Forms.Button();
            this.carteLocalHumain = new System.Windows.Forms.Button();
            this.carteLocalAI = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carteHeberger = new System.Windows.Forms.Button();
            this.lblNbJoueur = new System.Windows.Forms.Label();
            this.lblNbAI = new System.Windows.Forms.Label();
            this.tBoxNbJoueur = new System.Windows.Forms.TextBox();
            this.tBoxNbAI = new System.Windows.Forms.TextBox();
            this.btnPlusAI = new System.Windows.Forms.Button();
            this.btnMoinsAI = new System.Windows.Forms.Button();
            this.btnPlusJoueurs = new System.Windows.Forms.Button();
            this.btnMoinsJoueurs = new System.Windows.Forms.Button();
            this.btnLancerHebergement = new System.Windows.Forms.Button();
            this.carteRejoindre = new System.Windows.Forms.Button();
            this.lblRejoindreIP = new System.Windows.Forms.Label();
            this.tBoxIP = new System.Windows.Forms.TextBox();
            this.btnLancerRejoindre = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblYourIP = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.Devs = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panelPrincipale.SuspendLayout();
            this.carteLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.carteHeberger.SuspendLayout();
            this.carteRejoindre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipale
            // 
            this.panelPrincipale.Controls.Add(this.carteLocal);
            this.panelPrincipale.Controls.Add(this.pictureBox1);
            this.panelPrincipale.Controls.Add(this.carteHeberger);
            this.panelPrincipale.Controls.Add(this.carteRejoindre);
            this.panelPrincipale.Controls.Add(this.pictureBox2);
            this.panelPrincipale.Location = new System.Drawing.Point(71, 45);
            this.panelPrincipale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPrincipale.Name = "panelPrincipale";
            this.panelPrincipale.Size = new System.Drawing.Size(587, 474);
            this.panelPrincipale.TabIndex = 5;
            // 
            // carteLocal
            // 
            this.carteLocal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carteLocal.BackColor = System.Drawing.Color.Transparent;
            this.carteLocal.BackgroundImage = global::BJ_S.Properties.Resources.carteLocalOut;
            this.carteLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteLocal.Controls.Add(this.carteLocalHumain);
            this.carteLocal.Controls.Add(this.carteLocalAI);
            this.carteLocal.FlatAppearance.BorderSize = 0;
            this.carteLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteLocal.Location = new System.Drawing.Point(0, 0);
            this.carteLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteLocal.MaximumSize = new System.Drawing.Size(173, 325);
            this.carteLocal.Name = "carteLocal";
            this.carteLocal.Size = new System.Drawing.Size(173, 325);
            this.carteLocal.TabIndex = 0;
            this.carteLocal.Tag = "facingUp";
            this.carteLocal.UseVisualStyleBackColor = false;
            this.carteLocal.Click += new System.EventHandler(this.cardClick);
            this.carteLocal.MouseEnter += new System.EventHandler(this.button_Card_Hover);
            this.carteLocal.MouseLeave += new System.EventHandler(this.button_Card_Out);
            // 
            // carteLocalHumain
            // 
            this.carteLocalHumain.BackColor = System.Drawing.Color.White;
            this.carteLocalHumain.BackgroundImage = global::BJ_S.Properties.Resources.btnHumain;
            this.carteLocalHumain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteLocalHumain.FlatAppearance.BorderSize = 0;
            this.carteLocalHumain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteLocalHumain.Location = new System.Drawing.Point(20, 103);
            this.carteLocalHumain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteLocalHumain.Name = "carteLocalHumain";
            this.carteLocalHumain.Size = new System.Drawing.Size(133, 56);
            this.carteLocalHumain.TabIndex = 7;
            this.carteLocalHumain.UseVisualStyleBackColor = false;
            this.carteLocalHumain.Visible = false;
            this.carteLocalHumain.Click += new System.EventHandler(this.carteLocalHumain_Click);
            // 
            // carteLocalAI
            // 
            this.carteLocalAI.BackColor = System.Drawing.Color.White;
            this.carteLocalAI.BackgroundImage = global::BJ_S.Properties.Resources.btnIA;
            this.carteLocalAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteLocalAI.FlatAppearance.BorderSize = 0;
            this.carteLocalAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteLocalAI.Location = new System.Drawing.Point(20, 181);
            this.carteLocalAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteLocalAI.Name = "carteLocalAI";
            this.carteLocalAI.Size = new System.Drawing.Size(133, 56);
            this.carteLocalAI.TabIndex = 8;
            this.carteLocalAI.UseVisualStyleBackColor = false;
            this.carteLocalAI.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BJ_S.Properties.Resources.TitreJeu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(293, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // carteHeberger
            // 
            this.carteHeberger.BackColor = System.Drawing.Color.Transparent;
            this.carteHeberger.BackgroundImage = global::BJ_S.Properties.Resources.carteHebergerOut;
            this.carteHeberger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteHeberger.Controls.Add(this.lblNbJoueur);
            this.carteHeberger.Controls.Add(this.lblNbAI);
            this.carteHeberger.Controls.Add(this.tBoxNbJoueur);
            this.carteHeberger.Controls.Add(this.tBoxNbAI);
            this.carteHeberger.Controls.Add(this.btnPlusAI);
            this.carteHeberger.Controls.Add(this.btnMoinsAI);
            this.carteHeberger.Controls.Add(this.btnPlusJoueurs);
            this.carteHeberger.Controls.Add(this.btnMoinsJoueurs);
            this.carteHeberger.Controls.Add(this.btnLancerHebergement);
            this.carteHeberger.FlatAppearance.BorderSize = 0;
            this.carteHeberger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteHeberger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteHeberger.Location = new System.Drawing.Point(207, 75);
            this.carteHeberger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteHeberger.Name = "carteHeberger";
            this.carteHeberger.Size = new System.Drawing.Size(173, 325);
            this.carteHeberger.TabIndex = 1;
            this.carteHeberger.Tag = "facingUp";
            this.carteHeberger.UseVisualStyleBackColor = false;
            this.carteHeberger.Click += new System.EventHandler(this.cardClick);
            this.carteHeberger.MouseEnter += new System.EventHandler(this.button_Card_Hover);
            this.carteHeberger.MouseLeave += new System.EventHandler(this.button_Card_Out);
            // 
            // lblNbJoueur
            // 
            this.lblNbJoueur.AutoSize = true;
            this.lblNbJoueur.BackColor = System.Drawing.Color.White;
            this.lblNbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbJoueur.Location = new System.Drawing.Point(13, 75);
            this.lblNbJoueur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbJoueur.Name = "lblNbJoueur";
            this.lblNbJoueur.Size = new System.Drawing.Size(148, 20);
            this.lblNbJoueur.TabIndex = 8;
            this.lblNbJoueur.Text = "Nombre de Joueurs";
            this.lblNbJoueur.Visible = false;
            // 
            // lblNbAI
            // 
            this.lblNbAI.AutoSize = true;
            this.lblNbAI.BackColor = System.Drawing.Color.White;
            this.lblNbAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbAI.Location = new System.Drawing.Point(37, 175);
            this.lblNbAI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbAI.Name = "lblNbAI";
            this.lblNbAI.Size = new System.Drawing.Size(97, 20);
            this.lblNbAI.TabIndex = 10;
            this.lblNbAI.Text = "Nombre d\'AI";
            this.lblNbAI.Visible = false;
            // 
            // tBoxNbJoueur
            // 
            this.tBoxNbJoueur.Enabled = false;
            this.tBoxNbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNbJoueur.Location = new System.Drawing.Point(59, 99);
            this.tBoxNbJoueur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxNbJoueur.Name = "tBoxNbJoueur";
            this.tBoxNbJoueur.Size = new System.Drawing.Size(53, 32);
            this.tBoxNbJoueur.TabIndex = 7;
            this.tBoxNbJoueur.Text = "5";
            this.tBoxNbJoueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxNbJoueur.Visible = false;
            // 
            // tBoxNbAI
            // 
            this.tBoxNbAI.Enabled = false;
            this.tBoxNbAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNbAI.Location = new System.Drawing.Point(59, 197);
            this.tBoxNbAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxNbAI.Name = "tBoxNbAI";
            this.tBoxNbAI.Size = new System.Drawing.Size(53, 32);
            this.tBoxNbAI.TabIndex = 9;
            this.tBoxNbAI.Text = "0";
            this.tBoxNbAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxNbAI.Visible = false;
            // 
            // btnPlusAI
            // 
            this.btnPlusAI.BackColor = System.Drawing.Color.White;
            this.btnPlusAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlusAI.Enabled = false;
            this.btnPlusAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusAI.Location = new System.Drawing.Point(113, 198);
            this.btnPlusAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlusAI.Name = "btnPlusAI";
            this.btnPlusAI.Size = new System.Drawing.Size(32, 27);
            this.btnPlusAI.TabIndex = 14;
            this.btnPlusAI.Text = "+";
            this.btnPlusAI.UseVisualStyleBackColor = false;
            this.btnPlusAI.Visible = false;
            this.btnPlusAI.Click += new System.EventHandler(this.tBoxPlusMoins);
            // 
            // btnMoinsAI
            // 
            this.btnMoinsAI.BackColor = System.Drawing.Color.White;
            this.btnMoinsAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoinsAI.Enabled = false;
            this.btnMoinsAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoinsAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoinsAI.Location = new System.Drawing.Point(23, 198);
            this.btnMoinsAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoinsAI.Name = "btnMoinsAI";
            this.btnMoinsAI.Size = new System.Drawing.Size(32, 27);
            this.btnMoinsAI.TabIndex = 13;
            this.btnMoinsAI.Text = "-";
            this.btnMoinsAI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoinsAI.UseVisualStyleBackColor = false;
            this.btnMoinsAI.Visible = false;
            this.btnMoinsAI.Click += new System.EventHandler(this.tBoxPlusMoins);
            // 
            // btnPlusJoueurs
            // 
            this.btnPlusJoueurs.BackColor = System.Drawing.Color.White;
            this.btnPlusJoueurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlusJoueurs.Enabled = false;
            this.btnPlusJoueurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusJoueurs.Location = new System.Drawing.Point(113, 100);
            this.btnPlusJoueurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlusJoueurs.Name = "btnPlusJoueurs";
            this.btnPlusJoueurs.Size = new System.Drawing.Size(32, 27);
            this.btnPlusJoueurs.TabIndex = 11;
            this.btnPlusJoueurs.Text = "+";
            this.btnPlusJoueurs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusJoueurs.UseVisualStyleBackColor = false;
            this.btnPlusJoueurs.Visible = false;
            this.btnPlusJoueurs.Click += new System.EventHandler(this.tBoxPlusMoins);
            // 
            // btnMoinsJoueurs
            // 
            this.btnMoinsJoueurs.BackColor = System.Drawing.Color.White;
            this.btnMoinsJoueurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoinsJoueurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoinsJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoinsJoueurs.Location = new System.Drawing.Point(23, 100);
            this.btnMoinsJoueurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoinsJoueurs.Name = "btnMoinsJoueurs";
            this.btnMoinsJoueurs.Size = new System.Drawing.Size(32, 27);
            this.btnMoinsJoueurs.TabIndex = 12;
            this.btnMoinsJoueurs.Text = "-";
            this.btnMoinsJoueurs.UseVisualStyleBackColor = false;
            this.btnMoinsJoueurs.Visible = false;
            this.btnMoinsJoueurs.Click += new System.EventHandler(this.tBoxPlusMoins);
            // 
            // btnLancerHebergement
            // 
            this.btnLancerHebergement.BackColor = System.Drawing.Color.DimGray;
            this.btnLancerHebergement.FlatAppearance.BorderSize = 0;
            this.btnLancerHebergement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancerHebergement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancerHebergement.ForeColor = System.Drawing.Color.Gold;
            this.btnLancerHebergement.Location = new System.Drawing.Point(40, 260);
            this.btnLancerHebergement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLancerHebergement.Name = "btnLancerHebergement";
            this.btnLancerHebergement.Size = new System.Drawing.Size(92, 34);
            this.btnLancerHebergement.TabIndex = 7;
            this.btnLancerHebergement.Text = "Lancer";
            this.btnLancerHebergement.UseVisualStyleBackColor = false;
            this.btnLancerHebergement.Visible = false;
            this.btnLancerHebergement.Click += new System.EventHandler(this.Heberger_Click);
            // 
            // carteRejoindre
            // 
            this.carteRejoindre.BackColor = System.Drawing.Color.Transparent;
            this.carteRejoindre.BackgroundImage = global::BJ_S.Properties.Resources.carteRejoindreOut;
            this.carteRejoindre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteRejoindre.Controls.Add(this.lblRejoindreIP);
            this.carteRejoindre.Controls.Add(this.tBoxIP);
            this.carteRejoindre.Controls.Add(this.btnLancerRejoindre);
            this.carteRejoindre.FlatAppearance.BorderSize = 0;
            this.carteRejoindre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteRejoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteRejoindre.Location = new System.Drawing.Point(413, 150);
            this.carteRejoindre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteRejoindre.Name = "carteRejoindre";
            this.carteRejoindre.Size = new System.Drawing.Size(173, 325);
            this.carteRejoindre.TabIndex = 2;
            this.carteRejoindre.Tag = "facingUp";
            this.carteRejoindre.UseVisualStyleBackColor = false;
            this.carteRejoindre.Click += new System.EventHandler(this.cardClick);
            this.carteRejoindre.MouseEnter += new System.EventHandler(this.button_Card_Hover);
            this.carteRejoindre.MouseLeave += new System.EventHandler(this.button_Card_Out);
            // 
            // lblRejoindreIP
            // 
            this.lblRejoindreIP.AutoSize = true;
            this.lblRejoindreIP.BackColor = System.Drawing.Color.White;
            this.lblRejoindreIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejoindreIP.Location = new System.Drawing.Point(43, 130);
            this.lblRejoindreIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRejoindreIP.Name = "lblRejoindreIP";
            this.lblRejoindreIP.Size = new System.Drawing.Size(87, 20);
            this.lblRejoindreIP.TabIndex = 9;
            this.lblRejoindreIP.Text = "Adresse IP";
            this.lblRejoindreIP.Visible = false;
            // 
            // tBoxIP
            // 
            this.tBoxIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxIP.Location = new System.Drawing.Point(30, 162);
            this.tBoxIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxIP.Name = "tBoxIP";
            this.tBoxIP.Size = new System.Drawing.Size(115, 26);
            this.tBoxIP.TabIndex = 10;
            this.tBoxIP.Visible = false;
            // 
            // btnLancerRejoindre
            // 
            this.btnLancerRejoindre.BackColor = System.Drawing.Color.DimGray;
            this.btnLancerRejoindre.FlatAppearance.BorderSize = 0;
            this.btnLancerRejoindre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancerRejoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancerRejoindre.ForeColor = System.Drawing.Color.Gold;
            this.btnLancerRejoindre.Location = new System.Drawing.Point(40, 260);
            this.btnLancerRejoindre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLancerRejoindre.Name = "btnLancerRejoindre";
            this.btnLancerRejoindre.Size = new System.Drawing.Size(92, 34);
            this.btnLancerRejoindre.TabIndex = 8;
            this.btnLancerRejoindre.Text = "Lancer";
            this.btnLancerRejoindre.UseVisualStyleBackColor = false;
            this.btnLancerRejoindre.Visible = false;
            this.btnLancerRejoindre.Click += new System.EventHandler(this.Rejoindre_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BJ_S.Properties.Resources.spotlight;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(41, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(549, 410);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblYourIP
            // 
            this.lblYourIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourIP.ForeColor = System.Drawing.Color.White;
            this.lblYourIP.Location = new System.Drawing.Point(67, 572);
            this.lblYourIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYourIP.Name = "lblYourIP";
            this.lblYourIP.Size = new System.Drawing.Size(149, 21);
            this.lblYourIP.TabIndex = 0;
            this.lblYourIP.Text = "Votre adresse IP";
            // 
            // lblIP
            // 
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.White;
            this.lblIP.Location = new System.Drawing.Point(67, 604);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(149, 21);
            this.lblIP.TabIndex = 0;
            // 
            // Devs
            // 
            this.Devs.AutoSize = true;
            this.Devs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devs.ForeColor = System.Drawing.Color.White;
            this.Devs.Location = new System.Drawing.Point(246, 572);
            this.Devs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Devs.Name = "Devs";
            this.Devs.Size = new System.Drawing.Size(239, 48);
            this.Devs.TabIndex = 6;
            this.Devs.Text = "Marc-André Larocque Blais\r\nJean-François Duchesne";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.BackColor = System.Drawing.Color.Black;
            this.btnQuitter.BackgroundImage = global::BJ_S.Properties.Resources.porteFermer;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(605, 543);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(58, 73);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.Quit_Click);
            this.btnQuitter.MouseEnter += new System.EventHandler(this.button_Quitter_Hover);
            this.btnQuitter.MouseLeave += new System.EventHandler(this.button_Quitter_Out);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(720, 650);
            this.Controls.Add(this.Devs);
            this.Controls.Add(this.lblYourIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.panelPrincipale);
            this.Controls.Add(this.btnQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "BlackJack";
            this.panelPrincipale.ResumeLayout(false);
            this.carteLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.carteHeberger.ResumeLayout(false);
            this.carteHeberger.PerformLayout();
            this.carteRejoindre.ResumeLayout(false);
            this.carteRejoindre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button carteLocal;
        private System.Windows.Forms.Button carteHeberger;
        private System.Windows.Forms.Button carteRejoindre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblYourIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Panel panelPrincipale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Devs;
        private System.Windows.Forms.Button carteLocalAI;
        private System.Windows.Forms.Button carteLocalHumain;
        private System.Windows.Forms.Label lblNbAI;
        private System.Windows.Forms.TextBox tBoxNbAI;
        private System.Windows.Forms.Label lblNbJoueur;
        private System.Windows.Forms.TextBox tBoxNbJoueur;
        private System.Windows.Forms.Button btnPlusAI;
        private System.Windows.Forms.Button btnMoinsAI;
        private System.Windows.Forms.Button btnMoinsJoueurs;
        private System.Windows.Forms.Button btnPlusJoueurs;
        private System.Windows.Forms.Button btnLancerHebergement;
        private System.Windows.Forms.TextBox tBoxIP;
        private System.Windows.Forms.Label lblRejoindreIP;
        private System.Windows.Forms.Button btnLancerRejoindre;
    }
}

