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
        public F_Solution()
        {
            InitializeComponent();
            int[,] content = new int[9, 9];
            content = F_Sudoku.FillContentTest(content);
            FillGrilleSolution(GrilleSolution, content);
        }

        // Rempli la grille solution 
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
