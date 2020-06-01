using System;
using System.Timers;

namespace BJ_S
{
	public class Partie
	{
		Joueurs[] tabJoueur;
		Joueurs moi;
		Croupier croupier;
		Sabot sabot;
		bool enLigne;

		public Partie(int nbJoueur, int nbAi, bool enLigne)
		{
			
			tabJoueur = new Joueurs[nbJoueur + nbAi];
			for(int i = 0; i < nbJoueur; i++)
			{
				string m_nom = ""; //place holder
				tabJoueur[i] = new Joueurs(m_nom, true);
			}

			if(nbAi > 0)
			{
				for(int i = nbJoueur; i < nbJoueur + nbAi; i++)
				{
					tabJoueur[i] = new Joueurs();
				}
			}

			moi = tabJoueur[0];

			this.enLigne = enLigne;

			sabot = new Sabot();
			croupier = new Croupier();
		}

		//pour les parties enligne
		public Partie(string ipHost)
		{
			//moi=?
			//tabJoueurs[] feed de l'host ou genere ca propre tab?

		}

		static System.Timers.Timer tempsAttente;

		public void AvantTour()
		{
			Console.WriteLine("Vous avez 30 secondes pour miser");//place holder
			tempsAttente = new System.Timers.Timer(30000);
			tempsAttente.Elapsed += DebutTour;

		}

		public void DebutTour(object source, ElapsedEventArgs e)
		{

		}

		////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		UI m_UI;
		public Partie(int type, string nomJoueur)
		{
			m_UI = new UI();
			m_UI.Show();
		}

		void PartieTerminer() {
			m_UI.Close();
			//FermerEtReleaseLesSockets
		}
	}
}