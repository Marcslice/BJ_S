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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carteLocal = new System.Windows.Forms.Button();
            this.carteLocalHumain = new System.Windows.Forms.Button();
            this.carteLocalAI = new System.Windows.Forms.Button();
            this.carteHeberger = new System.Windows.Forms.Button();
            this.carteHebergerHumain = new System.Windows.Forms.Button();
            this.carteHebergerAI = new System.Windows.Forms.Button();
            this.carteRejoindre = new System.Windows.Forms.Button();
            this.carteRejoindreHumain = new System.Windows.Forms.Button();
            this.carteRejoindreAI = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblYourIP = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.Devs = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panelPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.carteLocal.SuspendLayout();
            this.carteHeberger.SuspendLayout();
            this.carteRejoindre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipale
            // 
            this.panelPrincipale.Controls.Add(this.pictureBox1);
            this.panelPrincipale.Controls.Add(this.carteLocal);
            this.panelPrincipale.Controls.Add(this.carteHeberger);
            this.panelPrincipale.Controls.Add(this.carteRejoindre);
            this.panelPrincipale.Controls.Add(this.pictureBox2);
            this.panelPrincipale.Location = new System.Drawing.Point(71, 45);
            this.panelPrincipale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPrincipale.Name = "panelPrincipale";
            this.panelPrincipale.Size = new System.Drawing.Size(587, 474);
            this.panelPrincipale.TabIndex = 5;
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
            // carteLocal
            // 
            this.carteLocal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carteLocal.BackColor = System.Drawing.Color.Transparent;
            this.carteLocal.BackgroundImage = global::BJ_S.Properties.Resources.carteLocalOut;
            this.carteLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteLocal.Controls.Add(this.carteLocalHumain);
            this.carteLocal.Controls.Add(this.carteLocalAI);
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
            this.carteLocalHumain.Location = new System.Drawing.Point(20, 103);
            this.carteLocalHumain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteLocalHumain.Name = "carteLocalHumain";
            this.carteLocalHumain.Size = new System.Drawing.Size(133, 56);
            this.carteLocalHumain.TabIndex = 7;
            this.carteLocalHumain.Text = "Humain";
            this.carteLocalHumain.UseVisualStyleBackColor = true;
            this.carteLocalHumain.Visible = false;
            // 
            // carteLocalAI
            // 
            this.carteLocalAI.Location = new System.Drawing.Point(20, 181);
            this.carteLocalAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteLocalAI.Name = "carteLocalAI";
            this.carteLocalAI.Size = new System.Drawing.Size(133, 56);
            this.carteLocalAI.TabIndex = 8;
            this.carteLocalAI.Text = "AI";
            this.carteLocalAI.UseVisualStyleBackColor = true;
            this.carteLocalAI.Visible = false;
            // 
            // carteHeberger
            // 
            this.carteHeberger.BackColor = System.Drawing.Color.Transparent;
            this.carteHeberger.BackgroundImage = global::BJ_S.Properties.Resources.carteHebergerOut;
            this.carteHeberger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteHeberger.Controls.Add(this.carteHebergerHumain);
            this.carteHeberger.Controls.Add(this.carteHebergerAI);
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
            // carteHebergerHumain
            // 
            this.carteHebergerHumain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteHebergerHumain.Location = new System.Drawing.Point(20, 103);
            this.carteHebergerHumain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteHebergerHumain.Name = "carteHebergerHumain";
            this.carteHebergerHumain.Size = new System.Drawing.Size(133, 56);
            this.carteHebergerHumain.TabIndex = 9;
            this.carteHebergerHumain.Text = "Humain";
            this.carteHebergerHumain.UseVisualStyleBackColor = true;
            this.carteHebergerHumain.Visible = false;
            // 
            // carteHebergerAI
            // 
            this.carteHebergerAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteHebergerAI.Location = new System.Drawing.Point(20, 181);
            this.carteHebergerAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteHebergerAI.Name = "carteHebergerAI";
            this.carteHebergerAI.Size = new System.Drawing.Size(133, 56);
            this.carteHebergerAI.TabIndex = 10;
            this.carteHebergerAI.Text = "AI";
            this.carteHebergerAI.UseVisualStyleBackColor = true;
            this.carteHebergerAI.Visible = false;
            // 
            // carteRejoindre
            // 
            this.carteRejoindre.BackColor = System.Drawing.Color.Transparent;
            this.carteRejoindre.BackgroundImage = global::BJ_S.Properties.Resources.carteRejoindreOut;
            this.carteRejoindre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carteRejoindre.Controls.Add(this.carteRejoindreHumain);
            this.carteRejoindre.Controls.Add(this.carteRejoindreAI);
            this.carteRejoindre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carteRejoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteRejoindre.Location = new System.Drawing.Point(413, 150);
            this.carteRejoindre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteRejoindre.Name = "carteRejoindre";
            this.carteRejoindre.Size = new System.Drawing.Size(173, 325);
            this.carteRejoindre.TabIndex = 2;
            this.carteRejoindre.Tag = "facingUp";
            this.carteRejoindre.UseVisualStyleBackColor = false;
            this.carteRejoindre.Click += new System.EventHandler(this.Rejoindre_Click);
            this.carteRejoindre.MouseEnter += new System.EventHandler(this.button_Card_Hover);
            this.carteRejoindre.MouseLeave += new System.EventHandler(this.button_Card_Out);
            // 
            // carteRejoindreHumain
            // 
            this.carteRejoindreHumain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteRejoindreHumain.Location = new System.Drawing.Point(20, 103);
            this.carteRejoindreHumain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteRejoindreHumain.Name = "carteRejoindreHumain";
            this.carteRejoindreHumain.Size = new System.Drawing.Size(133, 56);
            this.carteRejoindreHumain.TabIndex = 11;
            this.carteRejoindreHumain.Text = "Humain";
            this.carteRejoindreHumain.UseVisualStyleBackColor = true;
            this.carteRejoindreHumain.Visible = false;
            // 
            // carteRejoindreAI
            // 
            this.carteRejoindreAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carteRejoindreAI.Location = new System.Drawing.Point(20, 181);
            this.carteRejoindreAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carteRejoindreAI.Name = "carteRejoindreAI";
            this.carteRejoindreAI.Size = new System.Drawing.Size(133, 56);
            this.carteRejoindreAI.TabIndex = 12;
            this.carteRejoindreAI.Text = "AI";
            this.carteRejoindreAI.UseVisualStyleBackColor = true;
            this.carteRejoindreAI.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.carteLocal.ResumeLayout(false);
            this.carteHeberger.ResumeLayout(false);
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
        private System.Windows.Forms.Button carteHebergerAI;
        private System.Windows.Forms.Button carteHebergerHumain;
        private System.Windows.Forms.Button carteLocalAI;
        private System.Windows.Forms.Button carteLocalHumain;
    }
}

