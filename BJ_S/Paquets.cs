using System;
using System.Collections.Generic;
using System.Linq;

namespace BJ_S
{
    /// <summary>
    /// représente un paquet de carte.
    /// </summary>
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

        /// <summary>
        /// Retourne une carte aléatoire lors de la pige dans le sabot.
        /// Un des paquets du sabot dans lequel la pige se fait est déterminé aléatoirement dans la classe Sabot.
        /// </summary>
        /// <returns>Cartes : Aléatoire</returns>
        public Cartes CarteAleatoire()
        {
            var rand = new Random();
            int random = rand.Next() % paquet.Count();
            Cartes carteRandom = paquet.ElementAt(random);
            paquet.RemoveAt(random);
            return carteRandom;
        }

        /// <summary>
        /// Détermine si un paquet est vide. Permet de repiger lors de la distribution des cartes.
        /// </summary>
        /// <returns>Bool : False Paquet non vide.
        ///                 True Paquet vide.
        /// </returns>
        public bool EsTuVide()
        {
            if (paquet.Count() > 0)
                return false;
            else
                return true;
        }
    }
}
