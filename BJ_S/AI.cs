using System;

namespace BJ_S
{
    public class AI
    {
        Joueurs moi;
        public String Nom;

        public AI(Joueurs source)
        {
            //RandNom();
            moi = source;
        }

        /// <summary>
        /// Set/get permettant d'acceder au joueur que l'AI represante
        /// </summary>
        public Joueurs Moi
        {
            get { return moi; }
            set { moi = value; }
        }

        void RandNom()
        {
            //methode qui retourne un nom aleatoire dans un fichier externe
        }

        /// <summary>
        /// Methode qui determine de facon aleatoire un montant a miser entre 10, 25 et 50
        /// </summary>
        /// <param name="enCaisse">Correspond a la banque du joueur AI</param>
        /// <returns>Retourne un entier correspondant a un des trois jetons qu'un joueur peut miser</returns>
        public int Miser(int enCaisse)
        {
            var rand = new Random();
            int random;
            char choixMise;

            random = rand.Next() % 100;
            if (random < 90)
                choixMise = 's';
            else if (random < 99)
                choixMise = 'm';
            else
                choixMise = 'b';

            switch (choixMise)
            {
                case 's':
                    return 10;

                case 'm':
                    if (enCaisse >= 25)
                        return 25;
                    return 10;

                case 'b':
                    if (enCaisse >= 50)
                        return 50;
                    return 10;
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retourne un entier selon la valeur de la main du joueur</returns>
        public int HitorStand()
        {//possibliliter de faire compter les cartes et de complexifier l'algo
            if (moi.ValeurMain < 17)
                return 1;
            else
                return 2;
        }
    }
}
