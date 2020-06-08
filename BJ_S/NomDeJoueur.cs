using System.Windows.Forms;

namespace BJ_S
{
    /// <summary>
    /// Demande le nom du joueur pour créer un partie.
    /// </summary>
    public partial class NomDeJoueur : Form
    {
        public NomDeJoueur()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// Retourne le nom du joueur après avoir appuyé "OK".
        /// </summary>
        /// <returns></returns>
        public string get_Name()
        {
            return this.tboxNom.Text;
        }
    }
}
