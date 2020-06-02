using System;
using System.Collections.Generic;
using System.Timers;

namespace BJ_S
{
	public class Partie
	{
		Joueurs[] tabJoueur;
		List<Joueurs> listeActif;
		Joueurs moi;
		Croupier croupier;
		Sabot sabot;
		bool enLigne;
		bool tour;

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

		public void JouerManche()
		{
			Preparation();
			DistribuerCartes();
			TourJoueur();
			VerifierGagnant();
			ViderTable();
			//boucle pour partie
		}

		public void Preparation()
		{
			listeActif = new List<Joueurs>();

			System.Timers.Timer tempsAttente;
			Console.WriteLine("Vous avez 30 secondes pour miser");//place holder
			//joueur.miseEnable
			tempsAttente = new System.Timers.Timer(30000);
			tempsAttente.Elapsed += ConfirmerMise;
			
		}

		public void ConfirmerMise(object source, ElapsedEventArgs e)
		{
			//joueur.miseDisable
			for (int i = 0; i < tabJoueur.Length; i++)
			{
				if (tabJoueur[i].Mise > 0)
					listeActif.Add(tabJoueur[i]);
			}
		}

		public void DistribuerCartes()
		{
			bool carteOuverte = false;

			for (int j = 0; j < 2; j++)
			{
				for (int i = 0; i < listeActif.Count; i++)
				{
					listeActif[i].Main.RecevoirCarte(sabot.CarteDessus());
					listeActif[i].Main.Compte();
				}

				if (!carteOuverte)
				{
					croupier.Main.RecevoirCarte(sabot.CarteDessus());
					croupier.Main.Compte();
					carteOuverte = true;
				}
				else
					croupier.Main.RecevoirCarte(sabot.CarteDessus(), true);
			}
		}

		public void TourJoueur()
		{
			for(int i = 0; i < listeActif.Count; i++)
			{
				tour = true;

				do
				{
					//linking avec interface
					//sleepthread pour la decision de l'ai
					
					//hit definir target

				} while (tour == true && listeActif[i].ValeurMain < 21);
			}

			//busted?

			croupier.Main.RevelerCarte();
			croupier.Main.Compte();

			while(croupier.ValeurMain < 17)
			{
				croupier.Main.RecevoirCarte(sabot.CarteDessus());
				croupier.Main.Compte();
			}
		}

		 public void Hit()
		{
			moi.Main.RecevoirCarte(sabot.CarteDessus());
			moi.Main.Compte();
		}

		public void Stand()
		{
			tour = false;
		}

		public void VerifierGagnant()
		{
			for(int i = 0; i < listeActif.Count; i++)
			{
				int mise = listeActif[i].Mise;

				//busted a gerer
				if (listeActif[i].ValeurMain > croupier.ValeurMain)
					listeActif[i].DepotEncaisse(2 * mise);
				else if (listeActif[i].ValeurMain == croupier.ValeurMain)
					listeActif[i].DepotEncaisse(mise);
			}
		}

		public void ViderTable()
		{
			for(int i = 0; i < listeActif.Count; i++)
			{
				listeActif[i].Main = new Mains();
				listeActif[i].ValeurMain = 0;
				listeActif[i].Mise = 0;
			}

			croupier.Main = new Mains();
			croupier.ValeurMain = 0;
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