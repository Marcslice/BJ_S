using System;

namespace BJ_S
{
	public class Partie
	{
		UI m_UI;
		public Partie(int type, string nomJoueur)
		{
			m_UI = new UI();
			m_UI.Show();
		}
	}
}