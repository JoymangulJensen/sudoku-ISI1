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
    public partial class F_Solution : Form
    {
        /// <summary>
        /// Constructeur du formulaire : On rempli simplement la grille avec tous les chiffres de la solution
        /// </summary>
        public F_Solution(int[,] content)
        {
            InitializeComponent();
            // content = F_Sudoku.FillContentTest(content);
            FillGrilleSolution(GrilleSolution, content);
        }

        /// <summary>
        /// Rempli la grille solution 
        /// </summary>
        private void FillGrilleSolution(TableLayoutPanel g, int[,] contentSolution)
        {
            for (int col = 0; col < g.ColumnCount; col++)
            {
                for (int row = 0; row < g.RowCount; row++)
                {
                    Label label = new Label();
                    label.Text = Convert.ToString(contentSolution[col, row]);
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    g.Controls.Add(label, col, row);
                }
            }
        }
    }
}
