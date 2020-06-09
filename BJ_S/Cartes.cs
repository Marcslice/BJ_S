namespace BJ_S
{

    /// <summary>
    /// Cartes de jeu.
    /// </summary>
    public class Cartes
    {
        char sorte; //spade,heart,clove,diamond,
        int valeur; // 1 a 13
        string cheminPNG;
        static string cheminCarteDos = $@"../../images/cartes/0.png";

        public Cartes(char Sorte, int Valeur)
        {
            sorte = Sorte;
            valeur = Valeur;
            cheminPNG = $@"../../images/cartes/{valeur}{sorte}.png";
        }

        /// <summary>
        /// Retourne la valeur de la carte
        /// </summary>
        public int Valeur
        {
            get { return valeur; }
        }

        /// <summary>
        /// Retourne le chemin de la carte vue de face.
        /// </summary>
        /// <returns>string : path</returns>
        public string Image()
        {
            return cheminPNG;
        }

        /// <summary>
        /// Retourne le chemin de la carte vue de dos.
        /// </summary>
        /// <returns>string : path</returns>
        public string ImageDos()
        {
            return cheminCarteDos;
        }
    }
}
