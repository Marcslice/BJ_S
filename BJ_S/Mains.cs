using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ_S
{
    class Mains
    {
        List<Cartes> main;

        public Mains()
        {
            main = new List<Cartes>();
        }

        //partie feed une carte a joueur en appelant RecevoirCarte
        public void RecevoirCarte(Cartes nouvelleCarte)
        {
            main.Add(nouvelleCarte);
        }

        public int Compte()
        {
            int compte = 0;
            int nbAs = 0;

            for(int i = 0; i < main.Count(); i++){
                int valeur = main[i].Valeur;

                if (valeur == 1)
                {
                    nbAs++;
                    compte += 11;
                }
                else if (valeur < 10)
                    compte += valeur;
                else
                    compte += 10;

                
                //convertie les as en 1 si la valeur de la main depase 21
                if(compte > 21)
                {
                    while(nbAs > 0 && compte > 21)
                    {
                        nbAs--;
                        compte -= 10;
                    }
                }
            }
            return compte;
        }
    }
}
