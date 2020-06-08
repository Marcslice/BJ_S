using System;

namespace BJ_S
{
    class Sabot
    {
        Paquets[] sabot;
        int nbPaquets;

        public Sabot()
        {
            sabot = new Paquets[8];
            nbPaquets = 8;
            for (int i = 0; i < 8; i++)
            {
                sabot[i] = new Paquets();
            }
        }

        /// <summary>
        /// Simule la carte du dessus en sortant une carte aléatoire du sabot.
        /// </summary>
        /// <returns>Cartes : Aléatoire</returns>
        public Cartes CarteDessus()
        {
            var rand = new Random();
            int random;
            bool paquetVide;

            do
            {
                if (nbPaquets == 0)
                {
                    sabot = new Paquets[8];
                    nbPaquets = 8;
                    for (int i = 0; i < 8; i++)
                    {
                        sabot[i] = new Paquets();
                    }
                }

                paquetVide = false;
                random = rand.Next() % nbPaquets;

                if (sabot[random].EsTuVide())
                {
                    sabot[random] = sabot[--nbPaquets];
                    paquetVide = true;
                }

            } while (paquetVide);

            return sabot[random].CarteAleatoire();
        }
    }
}
