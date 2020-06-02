using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for(int i = 0; i < 8; i++)
            {
                sabot[i] = new Paquets();
            }
        }

        public Cartes CarteDessus()
        {
            var rand = new Random();
            int random;
            bool paquetVide;
            
            do
            {
                if (nbPaquets == 0)
                    new Sabot();

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
