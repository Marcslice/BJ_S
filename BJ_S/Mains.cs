using System.Collections.Generic;
using System.Linq;

namespace BJ_S
{

    /// <summary>
    /// Représante une main d'un joueur.
    /// </summary>
    public class Mains
    {
        List<Cartes> main;

        public Mains()
        {
            main = new List<Cartes>();
        }

        /// <summary>
        /// Methode qui distribue des carte dans une main
        /// </summary>
        /// <param name="nouvelleCarte">Correspond a une carte</param>
        public void RecevoirCarte(Cartes nouvelleCarte)
        {
            main.Add(nouvelleCarte);
        }

        /// <summary>
        /// Methode qui calcule la valeur d'une main en prenant compte de la presence d'as. Advenant que la valeur 
        /// depasse 21 elle effectue une convertion des as de 11 a 1
        /// </summary>
        /// <returns>Retourne un int correspondant a la somme des cartes</returns>
        public int Compte()
        {
            int compte = 0;
            int nbAs = 0;

            for (int i = 0; i < main.Count(); i++)
            {
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
                if (compte > 21)
                {
                    while (nbAs > 0 && compte > 21)
                    {
                        nbAs--;
                        compte -= 10;
                    }
                }
            }
            return compte;
        }

        /// <summary>
        /// indexeur permettant d'acceder a chacune des cartes
        /// </summary>
        /// <param name="i"></param>
        /// <returns>Retourne une carte precise de la main</returns>
        public Cartes this[int i]
        {
            get { return main[i]; }
        }

        /// <summary>
        /// Permet d'obtenir le nombre de carte presente dans la main
        /// </summary>
        /// <returns>Retoune un entier equivalent au nombre de carte</returns>
        public int NombresDeCarte()
        {
            return main.Count;
        }
    }
}
