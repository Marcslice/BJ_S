using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ_S
{
    public class AI
    {
        Joueurs moi;
        public String Nom;

        public AI()
        { 
            RandNom();
        }

        string RandNom()
        {
            return null;
        }

        public int Miser(int enCaisse)
        {
            var rand = new Random();
            int random;
            char choixMise;

            random = rand.Next() % 100;
            if (random < 90)
                choixMise = 'n';
            else if (random < 99)
                choixMise = 'd';
            else
                choixMise = 'a';

            switch (choixMise)
            {
                case 'n': 
                    return 10;

                case 'd':
                    if(enCaisse >= 20)
                        return 20;
                    return 10;

                case 'a': 
                    return enCaisse;
            }
            return 0;
        }
    }
}
