using System;
using System.Collections.Generic;
using System.Linq;

namespace BJ_S
{
    class Paquets
    {
        List<Cartes> paquet;

        public Paquets()
        {
            paquet = new List<Cartes>();
            string sortes = "shcd";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    paquet.Add(new Cartes(sortes[i], j));
                }
            }
        }

        public Cartes CarteAleatoire()
        {
            var rand = new Random();
            int random = rand.Next() % paquet.Count();
            Cartes carteRandom = paquet.ElementAt(random);
            paquet.RemoveAt(random);
            return carteRandom;
        }

        public bool EsTuVide()
        {
            if (paquet.Count() > 0)
                return false;
            else
                return true;
        }
    }
}
