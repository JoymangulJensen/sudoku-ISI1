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
    public partial class F_Sudoku : Form
    {

        public F_Sudoku()
        {
            InitializeComponent();
            int[,] content = new int[9,9];
            content = FillContentTest(content);


            FillGrille(Grille, content);
        }


        private void FillGrille(TableLayoutPanel g, int[,] content)
        {
            for (int col = 0; col < g.ColumnCount; col ++)
            {
                for (int row = 0; row < g.RowCount; row ++)
                {
                    Button button = setUpButton();
                    button.Text = Convert.ToString(content[col, row]);
                    g.Controls.Add(button, col, row);
                }
            }
        }

        private Button setUpButton()
        {
            Button button = new Button();
            button.Dock = DockStyle.Fill;
            button.Padding = new Padding(0);
            button.Click += new System.EventHandler(this.button_Click);

            return button;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            F_PopUp popUpForm = new F_PopUp(button.Text);
            popUpForm.ShowDialog(this);

            /* Ajouter deux boutons Annulé et Validé pour utiliser ce code
            if (popUpForm.ShowDialog(this) == DialogResult.OK)
            {
                // Bouton validé cliqué
                // button.Text = popUpForm.Value;
            }
            else
            {
                // Bouton annulé cliqué
            }
            */

            TableLayoutPanel t = (TableLayoutPanel)button.Parent;

            TableLayoutPanelCellPosition pos = t.GetPositionFromControl(button);

            MessageBox.Show("Vous avez édité la case aux coordonées : (" + (pos.Column + 1) + ", " + (pos.Row + 1) + ")");

            // lancer Vérifs

            button.Text = popUpForm.Value;
            popUpForm.Dispose();
        }

        public static int[,] FillContentTest(int[,] content)
        {
            for (int col = 0; col < content.GetLength(0); col++)
            {
                for (int row = 0; row < content.GetLength(1); row++)
                {
                    content[col, row] = ((col + row) % 9) + 1;
                }
            }
            return content;
        }

        private void buttonSolution_Click(object sender, EventArgs e)
        {
            F_Solution f_solution = new F_Solution();
            f_solution.ShowDialog(this);
        }
    }
}
