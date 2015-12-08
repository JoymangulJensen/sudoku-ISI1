namespace Sudoku
{
    partial class F_Sudoku
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.buttonSolution = new System.Windows.Forms.Button();
            this.Grille = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(312, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(157, 26);
            this.title.TabIndex = 1;
            this.title.Text = "Jeu du Sudoku";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSolution
            // 
            this.buttonSolution.Location = new System.Drawing.Point(352, 502);
            this.buttonSolution.Name = "buttonSolution";
            this.buttonSolution.Size = new System.Drawing.Size(75, 23);
            this.buttonSolution.TabIndex = 2;
            this.buttonSolution.Text = "Solution";
            this.buttonSolution.UseVisualStyleBackColor = true;
            this.buttonSolution.Click += new System.EventHandler(this.buttonSolution_Click);
            // 
            // Grille
            // 
            this.Grille.BackgroundImage = global::Sudoku.Properties.Resources.GrilleTrait;
            this.Grille.ColumnCount = 9;
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.26214F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.87379F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.26214F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.87379F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.Location = new System.Drawing.Point(134, 87);
            this.Grille.Name = "Grille";
            this.Grille.RowCount = 9;
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.00245F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.00245F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Grille.Size = new System.Drawing.Size(515, 409);
            this.Grille.TabIndex = 0;
            // 
            // F_Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 584);
            this.Controls.Add(this.buttonSolution);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Grille);
            this.Name = "F_Sudoku";
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Grille;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button buttonSolution;
    }
}

