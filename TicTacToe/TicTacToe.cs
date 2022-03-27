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
        List<FormPartie> m_formParties;

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

        public void NouvellePartie()
        {
            Partie nouvellePartie = new Partie(this);
            FormPartie nouvelleFormPartie = new FormPartie(this, nouvellePartie);

            m_parties.Add(nouvellePartie);
            m_formParties.Add(nouvelleFormPartie);

            nouvelleFormPartie.Show();
        }

        public void FermerPartie(FormPartie formPartie)
        {
            m_parties.Remove(formPartie.Partie);
            m_formParties.Remove(formPartie);
        }
    }
}
