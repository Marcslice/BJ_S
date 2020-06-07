using System;

namespace BJ_S
{
    public class AI
    {
        Joueurs moi;
        public String Nom;

        public AI(Joueurs source)
        {
            RandNom();
            moi = source;
        }

        public Joueurs Moi
        {
            get { return moi; }
            set { moi = value; }
        }

        void RandNom()
        {
            Nom = "bob";
        }

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

        public int HitorStand()
        {//possibliliter de faire compter les cartes
            if (moi.ValeurMain < 17)
                return 1;
            else
                return 2;
        }
    }
}
