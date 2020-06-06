using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ_S
{
    public class Croupier
    {
        Mains main;
        int valeurMain;

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
    }
}
