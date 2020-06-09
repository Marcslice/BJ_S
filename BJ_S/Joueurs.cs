using System;
using System.Threading;

namespace BJ_S
{

    /// <summary>
    /// Creation d'un joueur.
    /// </summary>
    public class Joueurs
    {
        int m_Encaisse, mise, valeurMain;
        bool esTuAI, busted;
        string m_Nom;

        Connexions m_Connection;
        Mains main;
        public AI ai;

        public Joueurs(string p_Nom = "", bool AI = false, bool enLigne = false)
        {
            esTuAI = AI;

            if ((p_Nom.Equals("")) && !AI)
                m_Nom = $"Anonyme{GenererAnonymat()}";
            else if (AI)
            {
                m_Nom = $"Bob{GenererAnonymat()}";
                ai = new AI(this);
            }
            else
                m_Nom = p_Nom;

            m_Encaisse = 500;
            main = new Mains();
            valeurMain = 0;

            if (enLigne)
                m_Connection = new Connexions(false, "");
        }

        public int Mise
        {
            get { if (esTuAI && mise == 0) { RetraitEncaisse(mise = ai.Miser(m_Encaisse)) ; return mise; } else { return mise; } }
            set { mise = value; }
        }

        public bool Ai
        {
            get { return esTuAI; }
        }

        /// <summary>
        /// Retourne la main du joueur. List<Cartes>
        /// </summary>
        public Mains Main
        {
            get { return main; }
            set { main = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ValeurMain
        {
            get { return valeurMain; }
            set { valeurMain = value; }
        }

        /// <summary>
        /// Génère un nombre random pour assigner aux bots ou aux joueurs sans nom.
        /// </summary>
        /// <returns>Int : Nombre Random</returns>
        int GenererAnonymat()
        {
            Thread.Sleep(200);
            Random seed = new Random();
            Random rnd = new Random(seed.Next(22, 222));
            return rnd.Next(1, 1000);
        }


        public string Nom
        {
            get { return m_Nom; }
            set { m_Nom = value; }
        }

        /// <summary>
        /// Retourne le montant en banque du joueur.
        /// </summary>
        public int Encaisse
        {
            get { return m_Encaisse; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Busted
        {
            get { return busted; }
            set { busted = value; }
        }

        /// <summary>
        /// Retire la mise du joueur de son encaisse lorsque le temps pour miser se termine.
        /// </summary>
        /// <param name="p_Mise">Montant Misé</param>
        /// <returns>True : Montant encaisse suffisant.
        ///          False : Montant encaisse insuffisant.
        /// </returns>
        public bool RetraitEncaisse(int p_Mise)
        {
            if ((m_Encaisse - p_Mise) >= 0)
            {
                m_Encaisse -= p_Mise;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Dépose le gain du joueur s'il gagne une manche.
        /// </summary>
        /// <param name="p_Gain">Montant gagné</param>
        /// <returns>Int Encaisse</returns>
        public int DepotEncaisse(int p_Gain)
        {
            m_Encaisse += p_Gain;
            return m_Encaisse;
        }
    }
}
