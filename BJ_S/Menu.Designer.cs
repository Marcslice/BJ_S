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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYourIP = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnHeberger = new System.Windows.Forms.Button();
            this.btnRejoindre = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblYourIP);
            this.panel1.Controls.Add(this.lblIP);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(97, 855);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 113);
            this.panel1.TabIndex = 1;
            // 
            // lblYourIP
            // 
            this.lblYourIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourIP.Location = new System.Drawing.Point(14, 16);
            this.lblYourIP.Name = "lblYourIP";
            this.lblYourIP.Size = new System.Drawing.Size(224, 32);
            this.lblYourIP.TabIndex = 0;
            this.lblYourIP.Text = "Votre adresse IP";
            // 
            // lblIP
            // 
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(14, 52);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(224, 32);
            this.lblIP.TabIndex = 0;
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.Location = new System.Drawing.Point(97, 70);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(272, 500);
            this.btnLocal.TabIndex = 0;
            this.btnLocal.Text = "Jeu Local";
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.Local_Click);
            this.btnLocal.MouseEnter += new System.EventHandler(this.buttons_Hover);
            this.btnLocal.MouseLeave += new System.EventHandler(this.buttons_Out);
            // 
            // btnHeberger
            // 
            this.btnHeberger.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHeberger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeberger.Location = new System.Drawing.Point(407, 188);
            this.btnHeberger.Name = "btnHeberger";
            this.btnHeberger.Size = new System.Drawing.Size(272, 500);
            this.btnHeberger.TabIndex = 1;
            this.btnHeberger.Text = "Héberger une partie (Internet)";
            this.btnHeberger.UseVisualStyleBackColor = false;
            this.btnHeberger.Click += new System.EventHandler(this.Heberger_Click);
            this.btnHeberger.MouseEnter += new System.EventHandler(this.buttons_Hover);
            this.btnHeberger.MouseLeave += new System.EventHandler(this.buttons_Out);
            // 
            // btnRejoindre
            // 
            this.btnRejoindre.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRejoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejoindre.Location = new System.Drawing.Point(723, 292);
            this.btnRejoindre.Name = "btnRejoindre";
            this.btnRejoindre.Size = new System.Drawing.Size(272, 500);
            this.btnRejoindre.TabIndex = 2;
            this.btnRejoindre.Text = "Rejoindre une partie (Internet)";
            this.btnRejoindre.UseVisualStyleBackColor = false;
            this.btnRejoindre.Click += new System.EventHandler(this.Rejoindre_Click);
            this.btnRejoindre.MouseEnter += new System.EventHandler(this.buttons_Hover);
            this.btnRejoindre.MouseLeave += new System.EventHandler(this.buttons_Out);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.BackColor = System.Drawing.Color.SpringGreen;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(723, 855);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(272, 113);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.Quit_Click);
            this.btnQuitter.MouseEnter += new System.EventHandler(this.buttons_Hover);
            this.btnQuitter.MouseLeave += new System.EventHandler(this.buttons_Out);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.Transparent;
            this.Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titre.Font = new System.Drawing.Font("Niagara Engraved", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.Color.White;
            this.Titre.Location = new System.Drawing.Point(736, 70);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(254, 87);
            this.Titre.TabIndex = 4;
            this.Titre.Text = "Black Jack";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1079, 1003);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRejoindre);
            this.Controls.Add(this.btnHeberger);
            this.Controls.Add(this.btnLocal);
            this.Name = "Menu";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.SizeChanged += new System.EventHandler(this.ReCalc);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnHeberger;
        private System.Windows.Forms.Button btnRejoindre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblYourIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label Titre;
    }
}

