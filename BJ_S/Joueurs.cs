using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ_S
{
    class Joueurs
    {
        string m_Nom;
        double m_Encaisse;
        Connexions m_Connection;
        Mains m_Main;

        public Joueurs(string p_Nom = "Anonyme", bool enLigne = false) 
        {
            if (p_Nom.Equals("Anonyme"))
                m_Nom = $"{p_Nom}{GenererAnonymat()}";
            else
                m_Nom = p_Nom;

            m_Encaisse = 500.00;
            m_Main = new Mains();

            if (enLigne)
                m_Connection = new Connexions();
        }

        int GenererAnonymat() 
        {
            Random rnd = new Random();
            return rnd.Next(1, 1000);
        }

        public string Nom 
        {
            get { return m_Nom; }
        }
    }
}
