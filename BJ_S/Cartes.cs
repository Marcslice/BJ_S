using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ_S
{
    public class Cartes
    {
        char sorte; //spade,heart,clove,diamond,
        int valeur; // 1 a 13
        string cheminPNG;

        public Cartes(char Sorte, int Valeur)
        {
            sorte = Sorte;
            valeur = Valeur;
            cheminPNG =  $@"../../images/cartes/{valeur}{sorte}.png";
        }

        public int Valeur
        {
            get { return valeur; }
        }
    }
}
