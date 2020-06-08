using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace BJ_S
{
	public class Partie
	{
		public Joueurs[] tabJoueur;
		List<Joueurs> listeActif;
		Joueurs moi;
		public Croupier croupier;
		Sabot sabot;
		bool enLigne;
		bool tour;
		UI m_UI;
		System.Timers.Timer tempsAttente, tMoins1;

		public Partie(int nbJoueur, int nbAi, bool enLigne, string nomJoueur)
		{

			tabJoueur = new Joueurs[nbJoueur + nbAi];

			for (int i = 0; i < nbJoueur; i++)
				tabJoueur[i] = new Joueurs();

			if (nbAi > 0)
			{
				for (int i = nbJoueur; i < nbJoueur + nbAi; i++)
				{
					tabJoueur[i] = new Joueurs(AI: true);
				}
			}

			moi = tabJoueur[0];
			moi.Nom = nomJoueur;

			this.enLigne = enLigne;

			sabot = new Sabot();
			croupier = new Croupier();

			m_UI = new UI(this);
			m_UI.Show();

			m_UI.Invoke(new UI.d_BloquerInterface(m_UI.BloquerInterface), true);
			for (int i = 0; i < tabJoueur.Length; i++)
				m_UI.Invoke(new UI.d_MettreAJourNomSiege(m_UI.MettreAJourNomSiege), i + 1, tabJoueur[i].Nom);

			//do
			//{
			JouerManche();
			//} while (moi.Encaisse > 0);

		}

		//pour les parties enligne
		public Partie(string ipHost)
		{
			//moi=?
			//tabJoueurs[] feed de l'host ou genere ca propre tab?

		}

		public Joueurs Moi
		{
			get { return moi; }
		}

		public void JouerManche()
		{
			Preparation();
		}

		public void Preparation()
		{
			listeActif = new List<Joueurs>();

			m_UI.Invoke(new UI.d_ResetTimer(m_UI.ResetTimer));

			m_UI.Invoke(new UI.d_DebloquerMise(m_UI.DebloquerMise));

			m_UI.Invoke(new UI.d_AfficherTimer(m_UI.AfficherTimer), true);

			tempsAttente = new System.Timers.Timer();
			tempsAttente.Interval = 10000;
			tempsAttente.Elapsed += ConfirmerMise;
			tempsAttente.AutoReset = false;

			tMoins1 = new System.Timers.Timer();
			tMoins1.Interval = 1000;
			tMoins1.Elapsed += TimerTick;
			tMoins1.AutoReset = true;

			tMoins1.Enabled = true;
			tempsAttente.Enabled = true;
		}

		public delegate void d_Miser(int p_Mise);

		public void Miser(int p_Mise)
		{
			Mise f;
			if (moi.RetraitEncaisse(p_Mise))
			{
				moi.Mise = p_Mise;
				m_UI.Invoke(new UI.d_MettreAJourEncaisseJoueur(m_UI.MettreAJourEncaisseJoueur));
				m_UI.Invoke(new UI.d_BloquerMise(m_UI.BloquerMise));
			}
			else
			{
				f = new Mise();
				f.ShowDialog(m_UI);
			}
		}

		public void TimerTick(object source, ElapsedEventArgs e)
		{
			m_UI.Invoke(new UI.d_MettreAJourTimer(m_UI.MettreAJourTimer), 1);
		}

		public void ConfirmerMise(object source, ElapsedEventArgs e)
		{
			tempsAttente.Stop();
			tMoins1.Stop();

			tempsAttente.Dispose();
			tMoins1.Dispose();

			for (int i = 0; i < tabJoueur.Length; i++)
			{
				if (tabJoueur[i].Mise > 0)
					listeActif.Add(tabJoueur[i]);

				m_UI.Invoke(new UI.d_BloquerMise(m_UI.BloquerMise));
				m_UI.Invoke(new UI.d_AfficherTimer(m_UI.AfficherTimer), false);
			}

			DistribuerCartes();
		}

		public void DistribuerCartes()
		{
			bool carteOuverte = false;

			for (int j = 0; j < 2; j++)
			{
				for (int i = 0; i < listeActif.Count; i++)
				{
					listeActif[i].Main.RecevoirCarte(sabot.CarteDessus());
					listeActif[i].ValeurMain = listeActif[i].Main.Compte();
				}

				if (!carteOuverte)
				{
					croupier.Main.RecevoirCarte(sabot.CarteDessus());
					croupier.ValeurMain = croupier.Main.Compte();
					carteOuverte = true;
				}
				else
				{
					croupier.Main.RecevoirCarte(sabot.CarteDessus());
				}
			}

			for (int i = 0; i < listeActif.Count; i++)
				m_UI.Invoke(new UI.d_MettreAJourMainJoueur(m_UI.MettreAJourMainJoueur), tabJoueur[5 - (listeActif.Count - i)], listeActif.Count - (listeActif.Count - i) + (6-listeActif.Count));

			m_UI.Invoke(new UI.d_MettreAJourMainCroupier(m_UI.MettreAJourMainCroupier), croupier, false);

			TourJoueurH();
		}

		public void TourJoueurH()
		{

			string log = "";

			for (int i = 0; i < listeActif.Count; i++)
			{
				tour = true;

				do
				{
					if (listeActif[i].Ai)
					{
						int milSec = 2000;
						Thread.Sleep(milSec);

						switch (listeActif[i].ai.HitorStand())
						{
							case 1:
								Hit(tabJoueur[5 - (listeActif.Count - i)], 5 - (listeActif.Count - i) + 1);
								break;
							case 2:
								Stand(tabJoueur[5 - (listeActif.Count - i)]);
								break;
						}
					}
					if (listeActif[i] == moi)
						m_UI.Invoke(new UI.d_DebloquerInterface(m_UI.DebloquerInterface), false); // m_UI.DebloquerInterface(false

					//cas multi
					//for(int j = 1; j < listActif.count; j++)
					//if(listActif[i] != listActif[j])

				} while (tour == true && listeActif[i].ValeurMain < 21);
				if (listeActif[i] == moi)
					m_UI.Invoke(new UI.d_BloquerInterface(m_UI.BloquerInterface), false);

				if (listeActif[i].ValeurMain > 21)
					listeActif[i].Busted = true;
			}

			croupier.ValeurMain = croupier.Compte();
			m_UI.Invoke(new UI.d_MettreAJourMainCroupier(m_UI.MettreAJourMainCroupier), croupier, true);


			Thread.Sleep(2000);

			bool tourCroupier = true;

			while (tourCroupier)
			{//a envoyer a marc
				switch (croupier.HitOrStand())
				{
					case 1:
						croupier.Main.RecevoirCarte(sabot.CarteDessus());
						croupier.ValeurMain = croupier.Compte();
						break;
					case 2:
						tourCroupier = false;
						break;
				}

				m_UI.Invoke(new UI.d_MettreAJourMainCroupier(m_UI.MettreAJourMainCroupier), croupier, true);

				log = $" Croupier Hit! et reçoit {croupier.Main[croupier.Main.NombresDeCarte() - 1].Valeur} Total : {croupier.Compte()}";
				m_UI.Invoke(new UI.d_MettreAJourFileEvenement(m_UI.MettreAJourFileEvenement), log);

				Thread.Sleep(2000);
			}

			if (croupier.Compte() > 21)
				log = $" Croupier Bust ! Total : {croupier.Compte()}";
			else
				log = $" Croupier Stand! Total : {croupier.Compte()}";

			m_UI.Invoke(new UI.d_MettreAJourFileEvenement(m_UI.MettreAJourFileEvenement), log);

			VerifierGagnant();
		}

		public void TourJoueurD()
		{

		}

		public void Hit(Joueurs joueur, int siege)
		{
			string log = "";

			joueur.Main.RecevoirCarte(sabot.CarteDessus());
			joueur.ValeurMain = joueur.Main.Compte();

			m_UI.Invoke(new UI.d_MettreAJourMainJoueur(m_UI.MettreAJourMainJoueur), joueur, siege);

			//FeedUpdate
			if (joueur.ValeurMain > 21)
				log = $"{joueur.Nom} Hit et Bust ! Total {joueur.ValeurMain}";
			else
				log = $"{joueur.Nom} Hit ! et reçoit {joueur.Main[joueur.Main.NombresDeCarte() - 1].Valeur}. Total {joueur.ValeurMain}";

			m_UI.Invoke(new UI.d_MettreAJourFileEvenement(m_UI.MettreAJourFileEvenement), log);
		}

		public void Stand(Joueurs joueur)
		{
			string log = "";

			tour = false;

			//FeedUpdate
			log = $"{joueur.Nom} Stand ! avec un main de {joueur.ValeurMain}";
			m_UI.Invoke(new UI.d_MettreAJourFileEvenement(m_UI.MettreAJourFileEvenement), log);
		}

		public void VerifierGagnant()
		{
			for (int i = 0; i < listeActif.Count; i++)
			{
				int mise = listeActif[i].Mise;

				if (!listeActif[i].Busted)
				{
					if (listeActif[i].ValeurMain > croupier.ValeurMain || croupier.ValeurMain > 21)
						listeActif[i].DepotEncaisse(2 * mise);
					else if (listeActif[i].ValeurMain == croupier.ValeurMain)
						listeActif[i].DepotEncaisse(mise);
				}
			}

			m_UI.Invoke(new UI.d_MettreAJourEncaisseJoueur(m_UI.MettreAJourEncaisseJoueur));

			ViderTable();
		}

		public void ViderTable()
		{
			for (int i = 0; i < listeActif.Count; i++)
			{
				listeActif[i].Main = new Mains();
				listeActif[i].ValeurMain = 0;

				m_UI.Invoke(new UI.d_MettreAJourMainJoueur(m_UI.MettreAJourMainJoueur), tabJoueur[5 - (listeActif.Count - i)], listeActif.Count - (listeActif.Count - i) + (6 - listeActif.Count));

				listeActif[i].Mise = 0;
			}

			croupier.Main = new Mains();
			croupier.ValeurMain = 0;

			m_UI.Invoke(new UI.d_MettreAJourMainCroupier(m_UI.MettreAJourMainCroupier), croupier, true);
			m_UI.Invoke(new UI.d_ReinitialiserFileEvenement(m_UI.ReinitialiserFileEvenement));

			JouerManche();
		}

		public void TerminerPartie()
		{
			tMoins1.Stop();
			tMoins1.Dispose();
			tempsAttente.Stop();
			tempsAttente.Dispose();
		}
	}
}