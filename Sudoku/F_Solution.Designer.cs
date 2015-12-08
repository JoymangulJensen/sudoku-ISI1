namespace Sudoku
{
    partial class F_Solution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrilleSolution = new System.Windows.Forms.TableLayoutPanel();
            this.titleSolution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GrilleSolution
            // 
            this.GrilleSolution.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.GrilleSolution.ColumnCount = 9;
            this.GrilleSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.Location = new System.Drawing.Point(55, 63);
            this.GrilleSolution.Name = "GrilleSolution";
            this.GrilleSolution.RowCount = 9;
            this.GrilleSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GrilleSolution.Size = new System.Drawing.Size(515, 409);
            this.GrilleSolution.TabIndex = 1;
            // 
            // titleSolution
            // 
            this.titleSolution.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleSolution.AutoSize = true;
            this.titleSolution.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSolution.Location = new System.Drawing.Point(262, 19);
            this.titleSolution.Name = "titleSolution";
            this.titleSolution.Size = new System.Drawing.Size(96, 26);
            this.titleSolution.TabIndex = 2;
            this.titleSolution.Text = "Solution";
            this.titleSolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Solution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 496);
            this.Controls.Add(this.titleSolution);
            this.Controls.Add(this.GrilleSolution);
            this.Name = "F_Solution";
            this.Text = "F_Solution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GrilleSolution;
        private System.Windows.Forms.Label titleSolution;
    }
}