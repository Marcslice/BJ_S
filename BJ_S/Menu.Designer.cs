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
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnHeberger = new System.Windows.Forms.Button();
            this.btnRejoindre = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblYourIP = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.Devs = new System.Windows.Forms.Label();
            this.panelPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipale
            // 
            this.panelPrincipale.Controls.Add(this.pictureBox1);
            this.panelPrincipale.Controls.Add(this.btnLocal);
            this.panelPrincipale.Controls.Add(this.btnHeberger);
            this.panelPrincipale.Controls.Add(this.btnRejoindre);
            this.panelPrincipale.Controls.Add(this.pictureBox2);
            this.panelPrincipale.Location = new System.Drawing.Point(106, 70);
            this.panelPrincipale.Name = "panelPrincipale";
            this.panelPrincipale.Size = new System.Drawing.Size(889, 730);
            this.panelPrincipale.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BJ_S.Properties.Resources.TitreJeu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(452, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnLocal
            // 
            this.btnLocal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLocal.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocal.BackgroundImage = global::BJ_S.Properties.Resources.carteLocalOut;
            this.btnLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.Location = new System.Drawing.Point(0, 3);
            this.btnLocal.MaximumSize = new System.Drawing.Size(272, 500);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(272, 500);
            this.btnLocal.TabIndex = 0;
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.localClick);
            this.btnLocal.MouseEnter += new System.EventHandler(this.button_Local_Hover);
            this.btnLocal.MouseLeave += new System.EventHandler(this.button_Local_Out);
            // 
            // btnHeberger
            // 
            this.btnHeberger.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHeberger.BackgroundImage = global::BJ_S.Properties.Resources.carteHebergeOut;
            this.btnHeberger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeberger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeberger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeberger.Location = new System.Drawing.Point(306, 115);
            this.btnHeberger.Name = "btnHeberger";
            this.btnHeberger.Size = new System.Drawing.Size(272, 500);
            this.btnHeberger.TabIndex = 1;
            this.btnHeberger.UseVisualStyleBackColor = false;
            this.btnHeberger.Click += new System.EventHandler(this.Heberger_Click);
            this.btnHeberger.MouseEnter += new System.EventHandler(this.button_Heberger_Hover);
            this.btnHeberger.MouseLeave += new System.EventHandler(this.button_Heberger_Out);
            // 
            // btnRejoindre
            // 
            this.btnRejoindre.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRejoindre.BackgroundImage = global::BJ_S.Properties.Resources.carteRejoindreMouseOut;
            this.btnRejoindre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRejoindre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejoindre.Location = new System.Drawing.Point(617, 231);
            this.btnRejoindre.Name = "btnRejoindre";
            this.btnRejoindre.Size = new System.Drawing.Size(272, 500);
            this.btnRejoindre.TabIndex = 2;
            this.btnRejoindre.UseVisualStyleBackColor = false;
            this.btnRejoindre.Click += new System.EventHandler(this.Rejoindre_Click);
            this.btnRejoindre.MouseEnter += new System.EventHandler(this.button_Rejoindre_Hover);
            this.btnRejoindre.MouseLeave += new System.EventHandler(this.button_Rejoindre_Out);
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
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnHeberger;
        private System.Windows.Forms.Button btnRejoindre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblYourIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Panel panelPrincipale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Devs;
    }
}

