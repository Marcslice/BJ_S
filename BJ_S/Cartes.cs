namespace BJ_S
{
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

        public int Valeur
        {
            get { return valeur; }
        }

        public string Image()
        {
            return cheminPNG;
        }

        public string ImageDos() 
        {
            return cheminCarteDos;
        }
    }
}
