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
        public FormPartie(TicTacToe jeu)
        {
            m_jeu = jeu;

            InitializeComponent();
        }

        public Partie Partie
        {
            set { m_partie = value; }
            get { return m_partie; }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            m_jeu.FermerPartie(m_partie);
        }
    }
}