using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public class TicTacToe
    {
        FormMenu m_Menu;
        List<Partie> m_parties;
        List<FormPartie> m_formParties;//Demander si necessaire

        [STAThread]
        static void Main()
        {
            TicTacToe ticTacToe = new TicTacToe();
        }

        public TicTacToe()
        {
            m_Menu = new FormMenu(this);
            m_parties = new List<Partie>();
            m_formParties = new List<FormPartie>();

            Application.Run(m_Menu);
        }

        //Demander si necessaire à charles
        /**~TicTacToe()
        {
            m_formParties.ForEach(form => FermerPartie(form));
        }*/

        public void NouvellePartie()
        {
            FormPartie nouvelleFormPartie = new FormPartie(this);
            Partie nouvellePartie = new Partie(this, nouvelleFormPartie);
            nouvelleFormPartie.Partie = nouvellePartie;

            m_parties.Add(nouvellePartie);
            m_formParties.Add(nouvelleFormPartie);

            nouvelleFormPartie.Show();
        }

        public void FermerPartie(Partie partie)
        {
            m_parties.Remove(partie);
            m_formParties.Remove(partie.);
        }
    }
}
