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
    public partial class F_PopUp : Form
    {

        private TableLayoutPanel table;

        /// <summary>
        /// Formulaire Pop Up permettant d'éditer une case : affiche un pavé numérique
        /// </summary>
        /// <param name="previousValue"> Valeur de la case avant édition</param>
        public F_PopUp(String previousValue)
        {
            InitializeComponent();
            this.value = previousValue;
            this.genererGrille();
        }

        /// <summary>
        /// Génère la grille de sélection d'un chiffre
        /// </summary>
        private void genererGrille()
        {
            this.table = new TableLayoutPanel();
            table.Dock = DockStyle.Fill;
            table.ColumnCount = 3;
            table.RowCount = 3;

            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));

            this.Controls.Add(table);

            int index = 1;
            for (int col = 0; col < table.ColumnCount; col++)
            {
                for (int row = 0; row < table.RowCount; row++)
                {
                    Button button = new Button();
                    button.Text = Convert.ToString(index++);
                    button.Dock = DockStyle.Fill;
                    button.Click += new EventHandler(popUp_button_Click);
                    table.Controls.Add(button, row, col);
                }
            }
        }

        /// <summary>
        /// Gestion de l'évèment Click sur un bouton : on récupère la valeur et on cache le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popUp_button_Click(object sender, EventArgs e)
        {
            this.value = ((Button)sender).Text;
            this.Hide();
        }

        /// <summary>
        /// Future valeur de la case, par défaut vide
        /// </summary>
        private String value = "";

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}
