using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Grille jeux = new Grille(9);
            jeux.generateGame();
            this.richTextBox1.Text = jeux.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
