using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Partie
    {
        TicTacToe m_jeu;
        Plateau m_plateau;
        Joueur m_x;
        Joueur m_o;
        FormPartie m_form;

        public Partie(TicTacToe jeu, FormPartie form)
        {
            m_jeu = jeu;
            m_form = form;
            m_plateau = new Plateau();
            m_x = new Joueur();
            m_o = new Joueur();
        }

        public FormPartie Form
        {
            set { m_form = value; }
            get { return m_form; }
        }
    }
}
