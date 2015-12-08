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

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public F_Sudoku()
        {
            InitializeComponent();
            int[,] content = new int[9,9];
            content = FillContentTest(content);


            FillGrille(Grille, content);
        }

        /// <summary>
        /// Remplie la grille avec le contenu générer par l'algorithme
        /// </summary>
        /// <param name="g"> La grille GUI</param>
        /// <param name="content">Le contenu de la grille sous forme de tableau 2D d'entier</param>
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

        /// <summary>
        /// Prépare les boutons : crée une instance et règle les propriétés graphiques
        /// </summary>
        /// <returns>Retourne le bouton à ajouter dans chaque cellule de la grille</returns>
        private Button setUpButton()
        {
            Button button = new Button();
            button.Dock = DockStyle.Fill;
            button.Padding = new Padding(0);
            button.Click += new System.EventHandler(this.button_Click);

            return button;
        }

        /// <summary>
        /// Gestion de l'évènement du clic sur une case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            int colIndex, rowIndex = 0;
            int value = int.Parse(popUpForm.Value);

            try
            {
                TableLayoutPanel t = (TableLayoutPanel)button.Parent;

                TableLayoutPanelCellPosition position = t.GetPositionFromControl(button);

                colIndex = position.Column;
                rowIndex = position.Row;

                MessageBox.Show("Vous avez édité la case aux coordonées : (" + (colIndex + 1) + ", " + (rowIndex + 1) + ")");

            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Erreur de type sur un downcast");
                throw;
            }

            if (correctValue(colIndex, rowIndex, value))
            {
                button.Text = Convert.ToString(value);
            }
            {
                MessageBox.Show("Valeur impossible !");
            }
            popUpForm.Dispose();
        }

        /// <summary>
        ///  Vérifie que la valeur saisie est correcte
        /// </summary>
        /// <param name="colIndex">Indice de colonne (0 à 8) de la case sélectionnée</param>
        /// <param name="rowIndex">Indice de ligne (0 à 8) de la case sélectionnée</param>
        /// <param name="value">Valeur choisie</param>
        /// <returns></returns>
        private bool correctValue(int colIndex, int rowIndex, int value)
        {
            // TODO : à implémenter avec le merge
            return true;
        }

        /// <summary>
        /// Méthode de test pour remplir une grille non aléatoire de Sudoku Valide
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gestion de l'évènement click du bouton afficher la solution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSolution_Click(object sender, EventArgs e)
        {
            F_Solution f_solution = new F_Solution();
            f_solution.ShowDialog(this);
        }

        /// <summary>
        /// Gestion de l'évènement click du bouton pour effacer/réinitialliser la grille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // this.FillGrille() ...
        }
    }
}
