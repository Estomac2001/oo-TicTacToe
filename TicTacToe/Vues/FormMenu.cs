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
    public partial class FormMenu : Form
    {
        TicTacToe m_jeu;
        public FormMenu(TicTacToe jeu)
        {
            m_jeu = jeu;

            InitializeComponent();
        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            m_jeu.NouvellePartie();
        }
    }
}
