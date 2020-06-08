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
