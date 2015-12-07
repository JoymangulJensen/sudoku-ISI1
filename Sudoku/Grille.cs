using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Grille
    {
        private int size;
        private int sizeTot;
        private int[,] grille;

        public int[,] Grille1
        {
            get { return grille; }
            set { grille = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Grille()
        {
            this.Size = 3;
            this.sizeTot = this.Size * this.Size;
            this.grille = new int[this.Size,this.Size];
            this.initGrille();
        }

        public Grille(int size)
        {
            this.Size = size;
            this.sizeTot = this.Size * this.Size;
            this.grille = new int[this.Size, this.Size];
            this.initGrille();
        }

        public void initGrille()
        {
            for (int i = 0; i < this.grille.GetLength(0); i++)
            {
                for (int j = 0; j < this.grille.GetLength(1); j++)
                {
                    this.grille[i, j] = 0;
                }
            }
        }

        public void test()
        {
            this.grille[0, 0] = 1;
            this.grille[0, 1] = 2;
            this.grille[0, 2] = 3;

            this.grille[1, 0] = 4;
            this.grille[1, 1] = 5;
            this.grille[1, 2] = 6;

            this.grille[2, 0] = 1;
            this.grille[2, 1] = 8;
            this.grille[2, 2] = 9;

        }

        public bool nestPasDansLigCol(int valeur, int lig, int col)
        {
            bool res = true;
            for (int i = 0; i < this.grille.GetLength(0); i++)
            {
                if (this.grille[i, col] == valeur)
                {
                    return false;
                }
            }

            for (int i = 0; i < this.grille.GetLength(1); i++)
            {
                if (this.grille[lig, i] == valeur)
                {
                    return false;
                }
            }
            return res;
        }

        public string ToString()
        {
            string s = "";
            for (int i = 0; i < this.grille.GetLength(0); i++)
            {
                for (int j = 0; j < this.grille.GetLength(1); j++)
                {
                    s += this.grille.GetValue(i, j) + " ";
                }
                s += "\n";
            }
            return s;
        }

    }
}
