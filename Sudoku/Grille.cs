﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Grille
    {
        private int size; //nb ligne nb colonne
        private int[,] solution;
        private int[,] partielle;

        public int[,] Partielle
        {
            get { return partielle; }
            set { partielle = value; }
        }

        public int[,] Solution
        {
            get { return solution; }
            set { solution = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Grille()
        {
            this.Size = 9;
            this.solution = new int[this.Size, this.Size];
            this.initGrille();
        }

        public void generateGame()
        {
            createGrid(0, 0, this.Solution);
        }

        private bool createGrid(int x, int y, int[,] g)
        {
            if (y > 8)
            {
                y = 0;
                x++;
            }
            //sudoku of the argument is completing sudoku.
            //so return true
            if (x > 8)
            {
                return true;
            }
            List<int> possibleNumbers = new List<int>();
            for (int i = 1; i <= 9; i++)
            {
                if (this.nestPasDansLigCol(i, x, y) && this.nestPasDansCarre(i, x, y))
                {
                    possibleNumbers.Add(i);
                }
            }
            if (possibleNumbers.Count == 0)
            {
                return false; //No solution found
            }

            Random rnd = new Random();
            int[] value = possibleNumbers.OrderBy(b => rnd.Next()).ToArray();

            foreach (int val in value)
            {
                g[x, y] = val;
                if (createGrid(x, y + 1, g))
                {
                    return true;
                }
                else
                {
                    g[x, y] = 0;
                }
            }

            return false;
        }


        private void initGrille()
        {
            for (int i = 0; i < this.solution.GetLength(0); i++)
            {
                for (int j = 0; j < this.solution.GetLength(1); j++)
                {
                    this.solution[i, j] = 0;
                }
            }
        }


        public bool nestPasDansLigCol(int valeur, int lig, int col)
        {
            bool res = true;
            for (int i = 0; i < this.solution.GetLength(0); i++)
            {
                if (this.solution[i, col] == valeur)
                {
                    return false;
                }
            }

            for (int i = 0; i < this.solution.GetLength(1); i++)
            {
                if (this.solution[lig, i] == valeur)
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
                    if (this.Solution[p, q] == val)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void cacher(int c)
        {
            int i = 0;
            this.partielle = this.clone(this.Solution);
            do
            {
                Random rand = new Random();
                int lig = rand.Next(0, 9);
                int col = rand.Next(0, 9);
                if (this.partielle[lig, col] != 0)
                {
                    this.partielle[lig, col] = 0;
                    i++;
                }

            } while ((i < c));
        }

        public int[,] clone(int[,] source)
        {
            int[,] res = new int[source.GetLength(0), source.GetLength(1)];
            for (int i = 0; i < source.GetLength(0); i++)
            {
                for (int j = 0; j < source.GetLength(1); j++)
                {
                    res[i, j] = source[i, j];
                }
            }
            return res;
        }


        public string ToString(int[,] g)
        {
            string s = "";
            for (int i = 0; i < g.GetLength(0); i++)
            {
                for (int j = 0; j < g.GetLength(1); j++)
                {
                    s += g.GetValue(i, j) + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}