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

            //deplacer les paquet vide a la fin du tableau et gerer le % pour fit avec nbPaquet
            do
            {
                random = rand.Next() % nbPaquets;
            } while (sabot[random].EsTuVide());

            return sabot[random].CarteAleatoire();
        }
    }
}
