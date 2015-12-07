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
            Grille jeux = new Grille();
            jeux.test();
            this.richTextBox1.Text = jeux.ToString();
            this.textBox1.Text = jeux.nestPasDansLigCol(5,0,0).ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
