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
            this.grille = new int[this.Size,this.Size];
            this.initGrille();
        }

        public Grille(int size)
        {
            this.Size = size;
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
            this.grille[0, 0] = 2;
            this.grille[0, 1] = 2;
            this.grille[0, 2] = 4;

            this.grille[1, 0] = 4;
            this.grille[1, 1] = 5;
            this.grille[1, 2] = 6;

            this.grille[2, 0] = 7;
            this.grille[2, 1] = 7;
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

        public bool nestPasDansCarre(int val, int lig, int col)
        {
            int gridRow = lig - (lig % 3);
            int gridColumn = col - (col % 3);
            for (int p = gridRow; p < gridRow + 3; p++)
            {
                for (int q = gridColumn; q < gridColumn + 3; q++)
                {
                    if (this.Grille1[p,q] == val)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void generateGame()
        {
            createGrid(0, 0, this.Grille1);
        }

        public bool createGrid(int x, int y, int[,] g)
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random rnd = new Random();
            int[] value = values.OrderBy(b => rnd.Next()).ToArray();

            for (int val=0;val <9; val++)
            {
                // check if number is valid
                if (nestPasDansLigCol(value[val], x, y) && nestPasDansCarre(value[val], x, y))
                {
                    g[x, y] = value[val];

                    if( y == 8)
                    {
                        y = 0;
                        createGrid(++x, y, g); return true;
                    }
                    else
                    {
                        createGrid(x, ++y, g);
                            return true;
                    }


                }
            }
            return false;
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
