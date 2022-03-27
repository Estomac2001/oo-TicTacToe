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

        public Partie(TicTacToe jeu)
        {
            m_jeu = jeu;
            m_plateau = new Plateau();
            m_x = new Joueur();
            m_o = new Joueur();
        }
    }
}
