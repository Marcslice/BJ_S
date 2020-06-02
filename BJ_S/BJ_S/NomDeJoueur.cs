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
    public partial class NomDeJoueur : Form
    {
        public NomDeJoueur()
        {
            InitializeComponent();
        }

        public string get_Name()
        {
            return this.tboxNom.Text;
        }
    }
}
