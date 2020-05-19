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
            this.carteHeberger = new System.Windows.Forms.Button();
            this.carteRejoindre = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblYourIP = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.Devs = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panelPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipale
            // 
            this.panelPrincipale.Controls.Add(this.button5);
            this.panelPrincipale.Controls.Add(this.button6);
            this.panelPrincipale.Controls.Add(this.button3);
            this.panelPrincipale.Controls.Add(this.button4);
            this.panelPrincipale.Controls.Add(this.button2);
            this.panelPrincipale.Controls.Add(this.button1);
            this.panelPrincipale.Controls.Add(this.pictureBox1);
            this.panelPrincipale.Controls.Add(this.carteLocal);
            this.panelPrincipale.Controls.Add(this.carteHeberger);
            this.panelPrincipale.Controls.Add(this.carteRejoindre);
            this.panelPrincipale.Controls.Add(this.pictureBox2);
            this.panelPrincipale.Location = new System.Drawing.Point(106, 70);
            this.panelPrincipale.Name = "panelPrincipale";
            this.panelPrincipale.Size = new System.Drawing.Size(880, 730);
            this.panelPrincipale.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BJ_S.Properties.Resources.TitreJeu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(440, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // carteLocal
            // 
            this.carteLocal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carteLocal.BackColor = System.Drawing.Color.Transparent;
            this.carteLocal.BackgroundImage = global::BJ_S.Properties.Resources.carteLocalOut;
            this.carteLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // carteHeberger
            // 
            this.carteHeberger.BackColor = System.Drawing.Color.Transparent;
            this.carteHeberger.BackgroundImage = global::BJ_S.Properties.Resources.carteHebergerOut;
            this.carteHeberger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // carteRejoindre
            // 
            this.carteRejoindre.BackColor = System.Drawing.Color.Transparent;
            this.carteRejoindre.BackgroundImage = global::BJ_S.Properties.Resources.carteRejoindreOut;
            this.carteRejoindre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BJ_S.Properties.Resources.spotlight;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(62, 99);
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
            this.lblIP.Location = new System.Drawing.Point(100, 930);
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
            this.btnQuitter.Location = new System.Drawing.Point(908, 836);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(87, 113);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.Quit_Click);
            this.btnQuitter.MouseEnter += new System.EventHandler(this.button_Quitter_Hover);
            this.btnQuitter.MouseLeave += new System.EventHandler(this.button_Quitter_Out);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 86);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 86);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 86);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 86);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(649, 501);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 86);
            this.button5.TabIndex = 12;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(649, 382);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 86);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Form messages;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

