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

        private Grille grille;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public F_Sudoku()
        {
            InitializeComponent();

            grille = new Grille();

            grille.generateGame();

            grille.cacher(30);

            // int[,] content = new int[9,9];
            // FillContentTest(content);
            
            FillGrille(Grille, grille.Partielle);
        }

        /// <summary>
        /// Remplie la grille avec le contenu générer par l'algorithme
        /// </summary>
        /// <param name="g"> La grille GUI</param>
        /// <param name="content">Le contenu de la grille sous forme de tableau 2D d'entier</param>
        private void FillGrille(TableLayoutPanel g, int[,] content)
        {
            String value = "";
            for (int col = 0; col < g.ColumnCount; col ++)
            {
                for (int row = 0; row < g.RowCount; row ++)
                {
                    Button button = setUpButton();
                    
                    if (content[col, row] == 0)
                    {
                        value = "";
                    }
                    else
                    {
                        value = Convert.ToString(content[col, row]);
                        //button.EnabledChanged += Button_EnabledChanged;
                        button.BackColor = Color.DarkGray;
                        button.Enabled = false;
                    }
                    button.Text = value;
                    g.Controls.Add(button, col, row);
                }
            }
        }

        private void Button_EnabledChanged(object sender, System.EventArgs e)
        {
            Button button1 = (Button) sender;
            // button1
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
            int valueInt;

            try
            {
                valueInt = int.Parse(popUpForm.Value);
            }
            catch (FormatException)
            {
                valueInt = 0;
            }

            try
            {
                TableLayoutPanel t = (TableLayoutPanel)button.Parent;

                TableLayoutPanelCellPosition position = t.GetPositionFromControl(button);

                colIndex = position.Column;
                rowIndex = position.Row;

                // MessageBox.Show("Vous avez édité la case aux coordonées : (" + (colIndex + 1) + ", " + (rowIndex + 1) + ")");

            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Erreur de type sur un downcast");
                throw;
            }

            if (correctValue(colIndex, rowIndex, valueInt))
            {
                button.Text = popUpForm.Value;
            }
            else
            {
                MessageBox.Show("Valeur incorrect !");
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
            if (value == 0)
            {
                return false;
            }
            // return grille.nestPasDansCarre(value, colIndex, rowIndex);
            return grille.Solution[colIndex, rowIndex] == value;
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
            F_Solution f_solution = new F_Solution(grille.Solution);
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

        /// <summary>
        /// Bouton recommencer : raffiche la solution partielle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            TableLayoutPanel g = Grille;
            for (int col = 0; col < g.ColumnCount; col++)
            {
                for (int row = 0; row < g.RowCount; row++)
                {
                    Button b = (Button) g.GetControlFromPosition(col, row);
                    if (grille.Partielle[col, row] == 0)
                    {
                        b.Text = "";
                    }
                    else
                    {
                        b.Text = Convert.ToString(grille.Partielle[col, row]);
                    }
                }
            }
        }
    }
}
