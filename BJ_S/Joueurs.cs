﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ_S
{
    public class Joueurs
    {
        string m_Nom;
        int m_Encaisse;
        int mise;
        Connexions m_Connection;
        Mains main;
        int valeurMain;
        bool esTuAI;
        bool busted;
        public AI ai;


        public Joueurs(string p_Nom = "Anonyme", bool enLigne = false) 
        {
            esTuAI = false;
            if (p_Nom.Equals("Anonyme"))
                m_Nom = $"{p_Nom}{GenererAnonymat()}";
            else
                m_Nom = p_Nom;

            m_Encaisse = 500;
            main = new Mains();
            valeurMain = 0;

            if (enLigne)
                m_Connection = new Connexions(false,"");
        }

        public Joueurs()//ai
        {
            esTuAI = true;
            m_Encaisse = 500;
            main = new Mains();
            valeurMain = 0;

            ai = new AI(this);
            m_Nom = ai.Nom;
        }

        public int Mise
        {
            get { if (esTuAI) { return (mise = ai.Miser(m_Encaisse)); } else { return mise; } }
            set { mise = value; }
        }

        public bool Ai
        {
            get { return esTuAI; }
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

        int GenererAnonymat() 
        {
            Random rnd = new Random();
            return rnd.Next(1, 1000);
        }

        public string Nom 
        {
            get { return m_Nom; }
            set { m_Nom = value; }
        }

        public int Encaisse 
        {
            get { return Encaisse; }
        }

        public bool Busted
        {
            get {return busted; }
            set {busted = value; }
        }

        public bool RetraitEncaisse(int p_Mise)//le retrait est effectuer par la partie mais le joueur peut miser dans le temps aloue
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
