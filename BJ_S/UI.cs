using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ_S
{
    public partial class UI : Form
    {
        Label[] feed = new Label[5];
        PictureBox selected;
        bool extended = false;

        public UI()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
                selected.BackgroundImage = Image.FromFile("../../images/" + selected.Name + "Out.png");

            if (clicked == selected)
                selected = null;
            else
            {
                clicked.BackgroundImage = Image.FromFile("../../images/" + clicked.Name + "On.png");
                selected = clicked;
            }
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
                this.btnExpendFeed.Location = new Point(this.btnExpendFeed.Location.X, this.btnExpendFeed.Location.Y + 150);
                foreach (Label l in feed)
                    l.Visible = true;
                this.btnExpendFeed.BackgroundImage = Image.FromFile("../../images/buttonCloseFeed.png");
            }
            else
            {
                feedPanel.Height = 50;
                this.btnExpendFeed.Location = new Point(this.btnExpendFeed.Location.X, this.btnExpendFeed.Location.Y - 150);
                for (int x = 4; x > 0; x--)
                    feed[x].Visible = false;
                this.btnExpendFeed.BackgroundImage = Image.FromFile("../../images/buttonExpendFeed.png");
            }
        }

        public void updateFeed(int type, string joueur, string carte, double montant) {

            if (lblFeed4.Text != "")
                lblFeed5.Text = lblFeed4.Text;
            if(lblFeed3.Text != "")
                lblFeed4.Text = lblFeed3.Text;
            if (lblFeed2.Text != "")
                lblFeed3.Text = lblFeed2.Text;
            if (lblFeed1.Text != "")
                lblFeed2.Text = lblFeed1.Text;

            switch (type)
            {
                case 0:
                    lblFeed1.Text = $"{joueur} a quitté la partie.";
                    break;
                case 1:
                    lblFeed1.Text = $"{joueur} a quitté la partie.";
                    break;
                case 2:
                    lblFeed1.Text = $"{joueur} a quitté la partie.";
                    break;
                case 3:
                    lblFeed1.Text = $"{joueur} a quitté la partie.";
                    break;
                case 4:
                    lblFeed1.Text = $"{joueur} a quitté la partie.";
                    break;
                case 5:
                    lblFeed1.Text = $"{joueur} a quitté la partie.";
                    break;
                default:
                    break;
            }
        }
    }
}
