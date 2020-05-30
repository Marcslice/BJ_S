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
        int m_Encaisse;
        Connexions m_Connection;
        Mains m_Main;
        AI ai;

        public Joueurs(string p_Nom = "Anonyme", bool enLigne = false) 
        {
            if (p_Nom.Equals("Anonyme"))
                m_Nom = $"{p_Nom}{GenererAnonymat()}";
            else
                m_Nom = p_Nom;

            m_Encaisse = 500;
            m_Main = new Mains();

            if (enLigne)
                m_Connection = new Connexions(false,"");
        }

        public Joueurs()//ai
        {
            ai = new AI();
            m_Nom = ai.Nom;

            m_Encaisse = 500;
            m_Main = new Mains();
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

        public int Encaisse 
        {
            get { return Encaisse; }
        }

        public bool RetraitEncaisse(int p_Mise)
        {
            if ((m_Encaisse - p_Mise) >= 0)
            {
                m_Encaisse -= p_Mise;
                return true;
            }
            return false;       
        }

        public int DepotEncaisse(int p_Gain)
        {
            m_Encaisse += p_Gain;
            return m_Encaisse;
        }
    }
}
