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
            this.btnPlusAI = new System.Windows.Forms.Button();
            this.btnMoinsAI = new System.Windows.Forms.Button();
            this.btnPlusJoueurs = new System.Windows.Forms.Button();
            this.btnMoinsJoueurs = new System.Windows.Forms.Button();
            this.carteLocal = new System.Windows.Forms.Button();
            this.carteLocalHumain = new System.Windows.Forms.Button();
            this.carteLocalAI = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carteHeberger = new System.Windows.Forms.Button();
            this.lblNbJoueur = new System.Windows.Forms.Label();
            this.lblNbAI = new System.Windows.Forms.Label();
            this.tBoxNbJoueur = new System.Windows.Forms.TextBox();
            this.tBoxNbAI = new System.Windows.Forms.TextBox();
            this.carteRejoindre = new System.Windows.Forms.Button();
            this.carteRejoindreHumain = new System.Windows.Forms.Button();
            this.carteRejoindreAI = new System.Windows.Forms.Button();
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
            this.panelPrincipale.Location = new System.Drawing.Point(106, 69);
            this.panelPrincipale.Name = "panelPrincipale";
            this.panelPrincipale.Size = new System.Drawing.Size(880, 729);
            this.panelPrincipale.TabIndex = 5;
            // 
            // btnPlusAI
            // 
            this.btnPlusAI.BackColor = System.Drawing.Color.White;
            this.btnPlusAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlusAI.Enabled = false;
            this.btnPlusAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusAI.Location = new System.Drawing.Point(170, 304);
            this.btnPlusAI.Name = "btnPlusAI";
            this.btnPlusAI.Size = new System.Drawing.Size(48, 42);
            this.btnPlusAI.TabIndex = 14;
            this.btnPlusAI.Text = "+";
            this.btnPlusAI.UseVisualStyleBackColor = false;
            this.btnPlusAI.Visible = false;
            this.btnPlusAI.Click += new System.EventHandler(this.btnPlusAI_Click);
            // 
            // btnMoinsAI
            // 
            this.btnMoinsAI.BackColor = System.Drawing.Color.White;
            this.btnMoinsAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoinsAI.Enabled = false;
            this.btnMoinsAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoinsAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoinsAI.Location = new System.Drawing.Point(35, 304);
            this.btnMoinsAI.Name = "btnMoinsAI";
            this.btnMoinsAI.Size = new System.Drawing.Size(48, 42);
            this.btnMoinsAI.TabIndex = 13;
            this.btnMoinsAI.Text = "-";
            this.btnMoinsAI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoinsAI.UseVisualStyleBackColor = false;
            this.btnMoinsAI.Visible = false;
            // 
            // btnPlusJoueurs
            // 
            this.btnPlusJoueurs.BackColor = System.Drawing.Color.White;
            this.btnPlusJoueurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlusJoueurs.Enabled = false;
            this.btnPlusJoueurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusJoueurs.Location = new System.Drawing.Point(170, 154);
            this.btnPlusJoueurs.Name = "btnPlusJoueurs";
            this.btnPlusJoueurs.Size = new System.Drawing.Size(48, 42);
            this.btnPlusJoueurs.TabIndex = 11;
            this.btnPlusJoueurs.Text = "+";
            this.btnPlusJoueurs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusJoueurs.UseVisualStyleBackColor = false;
            this.btnPlusJoueurs.Visible = false;
            // 
            // btnMoinsJoueurs
            // 
            this.btnMoinsJoueurs.BackColor = System.Drawing.Color.White;
            this.btnMoinsJoueurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoinsJoueurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoinsJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoinsJoueurs.Location = new System.Drawing.Point(35, 154);
            this.btnMoinsJoueurs.Name = "btnMoinsJoueurs";
            this.btnMoinsJoueurs.Size = new System.Drawing.Size(48, 42);
            this.btnMoinsJoueurs.TabIndex = 12;
            this.btnMoinsJoueurs.Text = "-";
            this.btnMoinsJoueurs.UseVisualStyleBackColor = false;
            this.btnMoinsJoueurs.Visible = false;
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
            this.carteLocal.MaximumSize = new System.Drawing.Size(260, 500);
            this.carteLocal.Name = "carteLocal";
            this.carteLocal.Size = new System.Drawing.Size(260, 500);
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
            this.carteLocalHumain.Location = new System.Drawing.Point(30, 158);
            this.carteLocalHumain.Name = "carteLocalHumain";
            this.carteLocalHumain.Size = new System.Drawing.Size(200, 86);
            this.carteLocalHumain.TabIndex = 7;
            this.carteLocalHumain.UseVisualStyleBackColor = false;
            this.carteLocalHumain.Visible = false;
            // 
            // carteLocalAI
            // 
            this.carteLocalAI.BackColor = System.Drawing.Color.White;
            this.carteLocalAI.BackgroundImage = global::BJ_S.Properties.Resources.btnIA;
            this.carteLocalAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteLocalAI.FlatAppearance.BorderSize = 0;
            this.carteLocalAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteLocalAI.Location = new System.Drawing.Point(30, 278);
            this.carteLocalAI.Name = "carteLocalAI";
            this.carteLocalAI.Size = new System.Drawing.Size(200, 86);
            this.carteLocalAI.TabIndex = 8;
            this.carteLocalAI.UseVisualStyleBackColor = false;
            this.carteLocalAI.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BJ_S.Properties.Resources.TitreJeu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(440, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 49);
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
            this.carteHeberger.FlatAppearance.BorderSize = 0;
            this.carteHeberger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteHeberger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteHeberger.Location = new System.Drawing.Point(310, 115);
            this.carteHeberger.Name = "carteHeberger";
            this.carteHeberger.Size = new System.Drawing.Size(260, 500);
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
            this.lblNbJoueur.Location = new System.Drawing.Point(20, 115);
            this.lblNbJoueur.Name = "lblNbJoueur";
            this.lblNbJoueur.Size = new System.Drawing.Size(227, 29);
            this.lblNbJoueur.TabIndex = 8;
            this.lblNbJoueur.Text = "Nombre de Joueurs";
            this.lblNbJoueur.Visible = false;
            // 
            // lblNbAI
            // 
            this.lblNbAI.AutoSize = true;
            this.lblNbAI.BackColor = System.Drawing.Color.White;
            this.lblNbAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbAI.Location = new System.Drawing.Point(55, 269);
            this.lblNbAI.Name = "lblNbAI";
            this.lblNbAI.Size = new System.Drawing.Size(146, 29);
            this.lblNbAI.TabIndex = 10;
            this.lblNbAI.Text = "Nombre d\'AI";
            this.lblNbAI.Visible = false;
            // 
            // tBoxNbJoueur
            // 
            this.tBoxNbJoueur.Enabled = false;
            this.tBoxNbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNbJoueur.Location = new System.Drawing.Point(88, 153);
            this.tBoxNbJoueur.Name = "tBoxNbJoueur";
            this.tBoxNbJoueur.Size = new System.Drawing.Size(78, 44);
            this.tBoxNbJoueur.TabIndex = 7;
            this.tBoxNbJoueur.Text = "4";
            this.tBoxNbJoueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxNbJoueur.Visible = false;
            // 
            // tBoxNbAI
            // 
            this.tBoxNbAI.Enabled = false;
            this.tBoxNbAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNbAI.Location = new System.Drawing.Point(88, 303);
            this.tBoxNbAI.Name = "tBoxNbAI";
            this.tBoxNbAI.Size = new System.Drawing.Size(78, 44);
            this.tBoxNbAI.TabIndex = 9;
            this.tBoxNbAI.Text = "0";
            this.tBoxNbAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxNbAI.Visible = false;
            // 
            // carteRejoindre
            // 
            this.carteRejoindre.BackColor = System.Drawing.Color.Transparent;
            this.carteRejoindre.BackgroundImage = global::BJ_S.Properties.Resources.carteRejoindreOut;
            this.carteRejoindre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteRejoindre.Controls.Add(this.carteRejoindreHumain);
            this.carteRejoindre.Controls.Add(this.carteRejoindreAI);
            this.carteRejoindre.FlatAppearance.BorderSize = 0;
            this.carteRejoindre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteRejoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteRejoindre.Location = new System.Drawing.Point(620, 231);
            this.carteRejoindre.Name = "carteRejoindre";
            this.carteRejoindre.Size = new System.Drawing.Size(260, 500);
            this.carteRejoindre.TabIndex = 2;
            this.carteRejoindre.Tag = "facingUp";
            this.carteRejoindre.UseVisualStyleBackColor = false;
            this.carteRejoindre.Click += new System.EventHandler(this.Rejoindre_Click);
            this.carteRejoindre.MouseEnter += new System.EventHandler(this.button_Card_Hover);
            this.carteRejoindre.MouseLeave += new System.EventHandler(this.button_Card_Out);
            // 
            // carteRejoindreHumain
            // 
            this.carteRejoindreHumain.BackColor = System.Drawing.Color.White;
            this.carteRejoindreHumain.BackgroundImage = global::BJ_S.Properties.Resources.btnHumain;
            this.carteRejoindreHumain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteRejoindreHumain.FlatAppearance.BorderSize = 0;
            this.carteRejoindreHumain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteRejoindreHumain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteRejoindreHumain.Location = new System.Drawing.Point(30, 158);
            this.carteRejoindreHumain.Name = "carteRejoindreHumain";
            this.carteRejoindreHumain.Size = new System.Drawing.Size(200, 86);
            this.carteRejoindreHumain.TabIndex = 11;
            this.carteRejoindreHumain.UseVisualStyleBackColor = false;
            this.carteRejoindreHumain.Visible = false;
            // 
            // carteRejoindreAI
            // 
            this.carteRejoindreAI.BackColor = System.Drawing.Color.White;
            this.carteRejoindreAI.BackgroundImage = global::BJ_S.Properties.Resources.btnIA;
            this.carteRejoindreAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteRejoindreAI.FlatAppearance.BorderSize = 0;
            this.carteRejoindreAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteRejoindreAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteRejoindreAI.Location = new System.Drawing.Point(30, 278);
            this.carteRejoindreAI.Name = "carteRejoindreAI";
            this.carteRejoindreAI.Size = new System.Drawing.Size(200, 86);
            this.carteRejoindreAI.TabIndex = 12;
            this.carteRejoindreAI.UseVisualStyleBackColor = false;
            this.carteRejoindreAI.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BJ_S.Properties.Resources.spotlight;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(62, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(824, 631);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblYourIP
            // 
            this.lblYourIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourIP.ForeColor = System.Drawing.Color.White;
            this.lblYourIP.Location = new System.Drawing.Point(100, 880);
            this.lblYourIP.Name = "lblYourIP";
            this.lblYourIP.Size = new System.Drawing.Size(224, 32);
            this.lblYourIP.TabIndex = 0;
            this.lblYourIP.Text = "Votre adresse IP";
            // 
            // lblIP
            // 
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.White;
            this.lblIP.Location = new System.Drawing.Point(100, 929);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(224, 32);
            this.lblIP.TabIndex = 0;
            // 
            // Devs
            // 
            this.Devs.AutoSize = true;
            this.Devs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devs.ForeColor = System.Drawing.Color.White;
            this.Devs.Location = new System.Drawing.Point(369, 880);
            this.Devs.Name = "Devs";
            this.Devs.Size = new System.Drawing.Size(358, 64);
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
            this.btnQuitter.Location = new System.Drawing.Point(908, 835);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(87, 112);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.Quit_Click);
            this.btnQuitter.MouseEnter += new System.EventHandler(this.button_Quitter_Hover);
            this.btnQuitter.MouseLeave += new System.EventHandler(this.button_Quitter_Out);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1080, 1000);
            this.Controls.Add(this.Devs);
            this.Controls.Add(this.lblYourIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.panelPrincipale);
            this.Controls.Add(this.btnQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button carteRejoindreAI;
        private System.Windows.Forms.Button carteRejoindreHumain;
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
    }
}

