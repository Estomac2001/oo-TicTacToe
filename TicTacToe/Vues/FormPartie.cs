using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormPartie : Form
    {
        TicTacToe m_jeu;
        Partie m_partie;
        public FormPartie(TicTacToe jeu, Partie partie)
        {
            m_jeu = jeu;
            m_partie = partie;

            InitializeComponent();
        }

        public Partie Partie
        {
            get { return m_partie; }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            m_jeu.FermerPartie(this);
        }
    }
}
