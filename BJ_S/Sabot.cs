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

        public Sabot()
        {
            sabot = new Paquets[8];
            for(int i = 0; i < 8; i++)
            {
                sabot[i] = new Paquets();
            }
        }

        public Cartes CarteDessus()
        {
            var rand = new Random();
            int random;

            do
            {
                random = rand.Next() % 8;
            } while (sabot[random].EsTuVide());

            return sabot[random].CarteAleatoire();
        }
    }
}
