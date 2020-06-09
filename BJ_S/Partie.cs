using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace BJ_S
{
	public class Partie
	{
		public Joueurs[] tabJoueur;//tableau des joueurs present
		List<Joueurs> listeActif;//liste des joueurs participant a la manche de jeu
		Joueurs moi;//Pointeur vers les donnees du joueur local
		public Croupier croupier;//croupier de la partie
		Sabot sabot;//sabot utiliser pour la partie
		bool enLigne;//booleen servant a determiner si une partie est local ou non
		bool tour;//booleen permettant de determiner si le tour est fini
		bool fermeture;
		UI m_UI;//form de la partie

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

			fermeture = false;

			JouerManche();
		}

		//constructeur pour les parties enligne
		public Partie(string ipHost)
		{
			//moi=?
			//tabJoueurs[] feed de l'host ou genere ca propre tab?

		}

		public Joueurs Moi
		{
			get { return moi; }
		}

		/// <summary>
		/// Methode qui lance une manche de jeu
		/// </summary>
		public void JouerManche()
		{
			if (m_UI.Visible)
				Preparation();
		}

		/// <summary>
		/// Methode utiliser pour notifier le joueur qu'il doit miser ou qu'il ne jouera pas
		/// </summary>
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

		/// <summary>
		/// Permet au form d'appeler la methode miser du controlleur
		/// </summary>
		/// <param name="p_Mise"></param>
		public delegate void d_Miser(int p_Mise);

		/// <summary>
		/// Methode qui gere les mises du joueur et actualise son en caisse
		/// </summary>
		/// <param name="p_Mise">Represente la valeur miser par le joueur</param>
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

		/// <summary>
		/// Gere l'affichage du minuteur
		/// </summary>
		public void TimerTick(object source, ElapsedEventArgs e)
		{
			if (m_UI.Visible)
				m_UI.Invoke(new UI.d_MettreAJourTimer(m_UI.MettreAJourTimer), 1);
		}

		/// <summary>
		/// Methode qui verifie quel joueur a effectuer une mise et creer une liste de joueur actif
		/// </summary>
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

			if (moi.Ai)
				m_UI.Invoke(new UI.d_MettreAJourEncaisseJoueur(m_UI.MettreAJourEncaisseJoueur));

			if (m_UI.Visible)
				DistribuerCartes();
		}

		/// <summary>
		/// Methode qui distribue les cartes aux joueurs de maniere conventionel et met a jour le compte de la main de chaque joueur.
		/// </summary>
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
					croupier.ValeurMain = croupier.Compte();
					carteOuverte = true;
				}
				else
				{
					croupier.Main.RecevoirCarte(sabot.CarteDessus());
				}
			}

			for (int i = 0; i < listeActif.Count; i++)
				m_UI.Invoke(new UI.d_MettreAJourMainJoueur(m_UI.MettreAJourMainJoueur), tabJoueur[5 - (listeActif.Count - i)], listeActif.Count - (listeActif.Count - i) + (6 - listeActif.Count));

			m_UI.Invoke(new UI.d_MettreAJourMainCroupier(m_UI.MettreAJourMainCroupier), croupier, false);

			if (m_UI.Visible)
				TourJoueurH();
		}

		/// <summary>
		/// Methode qui gere le tour des joueurs pour l'hote de la partie et qui effectue les actions du croupier
		/// </summary>
		public void TourJoueurH()
		{

			string log = "";

			for (int i = 0; i < listeActif.Count; i++)
			{
				listeActif[i].Busted = false;
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
					else if (listeActif[i] == moi)
						m_UI.Invoke(new UI.d_DebloquerInterface(m_UI.DebloquerInterface), false); // m_UI.DebloquerInterface(false

					//ajouter gestion multijoueur
					//if()

				} while (tour == true && listeActif[i].ValeurMain < 21);

				if (listeActif[i] == moi)
					m_UI.Invoke(new UI.d_BloquerInterface(m_UI.BloquerInterface), false);

				if (listeActif[i].ValeurMain > 21)
					listeActif[i].Busted = true;
			}

			//tour du croupier
			croupier.ValeurMain = croupier.Compte();
			m_UI.Invoke(new UI.d_MettreAJourMainCroupier(m_UI.MettreAJourMainCroupier), croupier, true);


			Thread.Sleep(2000);

			bool tourCroupier = true;

			while (tourCroupier)
			{
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

			if (croupier.ValeurMain > 21)
				log = $" Croupier Bust ! Total : {croupier.ValeurMain}";
			else
				log = $" Croupier Stand! Total : {croupier.ValeurMain}";

			m_UI.Invoke(new UI.d_MettreAJourFileEvenement(m_UI.MettreAJourFileEvenement), log);

			if (m_UI.Visible)
				VerifierGagnant();
		}

		//Tour des joueurs pour les joueurs distant
		public void TourJoueurD() { }

		/// <summary>
		/// Methode qui distribue des cartes additionnelles aux personnes qui en font la demande
		/// </summary>
		/// <param name="joueur">Joueur qui demande a recevoir une carte</param>
		/// <param name="siege">Position dans le tableau des joueurs (tabJoueur) de la personne qui appelle la methode</param>
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

		/// <summary>
		/// Methode qui employer lorsqu'un joueur est satisfait de ces cartes et desire finir son tour
		/// </summary>
		/// <param name="joueur">Joueur qui appel la methode</param>
		public void Stand(Joueurs joueur)
		{
			string log = "";

			tour = false;

			//FeedUpdate
			log = $"{joueur.Nom} Stand ! avec un main de {joueur.ValeurMain}";
			m_UI.Invoke(new UI.d_MettreAJourFileEvenement(m_UI.MettreAJourFileEvenement), log);
		}

		/// <summary>
		/// Methode qui sert a determiner qui son les gagnants de la manche et qui distribue les gains
		/// </summary>
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

			if (m_UI.Visible)
				ViderTable();
		}

		/// <summary>
		/// Methode employe lors de la fin d'une manche a fin de reinitialiser les valeurs a leur valeur par default
		/// </summary>
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

			if(m_UI.Visible)
				JouerManche();
		}

		/// <summary>
		/// Methode qui sert a fermer l'application
		/// </summary>
		public void TerminerPartie()
		{
			tMoins1.Stop();
			tMoins1.Dispose();
			tempsAttente.Stop();
			tempsAttente.Dispose();
		}
	}
}