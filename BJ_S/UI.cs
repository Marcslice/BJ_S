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
        PictureBox selected;
        bool extended = false;
        public UI()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void UI_Load(object sender, EventArgs e)
        {

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
                feedPanel.Height = 250;
                this.btnExpendFeed.Location = new Point(this.btnExpendFeed.Location.X, this.btnExpendFeed.Location.Y + 200);
                this.btnExpendFeed.BackgroundImage = Image.FromFile("../../images/buttonCloseFeed.png");
            }
            else
            {
                feedPanel.Height = 50;
                this.btnExpendFeed.Location = new Point(this.btnExpendFeed.Location.X, this.btnExpendFeed.Location.Y - 200);
                this.btnExpendFeed.BackgroundImage = Image.FromFile("../../images/buttonExpendFeed.png");
            }
        }
    }
}
