using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ_S
{
    public class Cartes
    {
        public char sorte; //spade,heart,clove,diamond,
        public int valeur; // 1 a 10 (As a roi ou les figures = 10)
        string cheminIMG;

        public Cartes(char Sorte, int Valeur)
        {
            sorte = Sorte;
            valeur = Valeur;
            cheminIMG = sorte + valeur + ".img";
        }
    }
}
