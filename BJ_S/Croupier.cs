namespace BJ_S
{
    public class Croupier
    {
        Mains main;//utiliser par partie pour generer les carte dans le UI et pour le faire le compte avec le dll
        int valeurMain;//utiliser pour eviter d'appeller la methode compte du dll inutilement pour l'affichage dans le UI et determiner qui gagne

        public Croupier()
        {
            main = new Mains();
            valeurMain = 0;
        }

        public Mains Main
        {
            get { return main; }
            set { main = value; }
        }

        public int ValeurMain
        {
            get { return valeurMain; }
            set { valeurMain = value; }
        }

        //tostring permettant de calculer les cartes

        /// <summary>
        /// Methode qui permet de calculer la somme des cartes presentes dans la main du croupier et qui converti les as en 1 si
        /// la somme depasse 21
        /// </summary>
        /// <returns>Retourne un entier qui represente la somme des cartes</returns>
        public int Compte()
        {
            int compte = 0;//somme de la valeur des carte de la main
            int nbAs = 0;//nombre d'as detecter qui sont calculer avec une valeur de 11
            int nbCartes = main.NombresDeCarte();//nombre de carte presente dans la main p-e inutile avec un toString +2 dans un for fetch la valeur puis aditionne

            for (int i = 0; i < nbCartes; i++)
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
        /// Methode qui determine si le croupier dois piger une autre carte au rester
        /// </summary>
        /// <returns>Retourne un entier selon sa decision 1 pour piger et 2 pour rester</returns>
        public int HitOrStand()
        {
            if (Compte() < 17)
                return 1;
            else
                return 2;
        }
    }
}
