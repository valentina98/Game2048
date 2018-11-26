using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game2048.Managers
{
    public class GameManager : IGameManager
    {
        public const short MatrixLenght = 4;
        public bool IsFool { get; set; } = false;
        public int[,] InitializeMatrix()
        {
            int[,] matrix = new int[MatrixLenght, MatrixLenght]
           {
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0}
           };
            AddNewDigit(matrix);
            AddNewDigit(matrix);
            return matrix;
        }
        public int[,] AddNewDigit(int[,] matrix)
        {
            Random rnd = new Random();
            //if (matrix.IsEmpty)
            do
            {
                int I = rnd.Next(0, MatrixLenght);
                int J = rnd.Next(0, MatrixLenght);
                if (matrix[I, J] == 0)
                {
                    matrix[I, J] = GetNewValue();
                    break;
                }
            } while (true); ///// if it is full? /// I should optimize it
            return matrix;
        }
        public int[,] SwipeLeft (int[,] matrix)
        {
            bool digitsAreSummed;
            for (int i = 0; i < MatrixLenght; i++)
            {
                digitsAreSummed = false;
                for (int j = 1; j < MatrixLenght; j++)
                {
                    // when a digit can be moved
                    if (matrix[i, j] != 0 && matrix[i, j - 1] == 0)
                    {
                        SwapSquares(ref matrix[i, j], ref matrix[i, j - 1]);
                        if (j > 1) j -= 2; // to not get out of range
                    }
                    // when squares are equal, not zeroes, and the one before is not a sum
                    else if (matrix[i, j - 1] == matrix[i, j] && matrix[i, j] != 0 && !digitsAreSummed)
                    {
                        matrix[i, j - 1] += matrix[i, j];
                        matrix[i, j] = 0;
                        digitsAreSummed = true;
                    }
                    // when digits reach their place 
                    else if (matrix[i, j - 1] != 0) digitsAreSummed = false; 
                    // if digitsAreSummed ?
                }
            }
            return matrix;
        }
        public int[,] SwipeRight(int[,] matrix)
        {
            bool digitsAreSummed;
            for (int i = 0; i < MatrixLenght; i++)
            {
                digitsAreSummed = false; 
                for (int j = MatrixLenght-2; j >= 0; j--)
                {
                    // when a digit can be moved
                    if (matrix[i, j] != 0 && matrix[i, j + 1] == 0)
                    {
                        SwapSquares(ref matrix[i, j], ref matrix[i, j + 1]);
                        if (j < MatrixLenght-2) j += 2; // to not get out of range
                    }
                    // when squares are equal, not zeroes, and the one before is not a sum
                    else if (matrix[i, j + 1] == matrix[i, j] && matrix[i, j] != 0 && !digitsAreSummed)
                    {
                        matrix[i, j + 1] += matrix[i, j];
                        matrix[i, j] = 0;
                        digitsAreSummed = true;
                    }
                    // when the next square reach its place
                    else if (matrix[i, j + 1] != 0) digitsAreSummed = false;
                }
            }
            return matrix;
        }
        public int[,] SwipeUp(int[,] matrix)
        {
            bool digitsAreSummed;
            for (int j = 0; j < MatrixLenght; j++)
            {
                digitsAreSummed = false;
                for (int i = 1; i < MatrixLenght; i++)
                {
                    // when a digit can be moved
                    if (matrix[i, j] != 0 && matrix[i - 1, j] == 0)
                    {
                        SwapSquares(ref matrix[i, j], ref matrix[i - 1, j]);
                        if (i > 1) i -= 2; // to not get out of range
                    }
                    // when squares are equal, not zeroes and the one before is not a sum
                    else if (matrix[i - 1, j] == matrix[i, j] && matrix[i, j] != 0 && !digitsAreSummed)
                    {
                        matrix[i - 1, j] += matrix[i, j];
                        matrix[i, j] = 0;
                        digitsAreSummed = true;
                    }
                    // when digits reach their place 
                    else if (matrix[i - 1, j] != 0) digitsAreSummed = false;
                }
            }
            return matrix;
        }
        public int[,] SwipeDown(int[,] matrix)
        {
            bool digitsAreSummed;
            for (int j = 0; j < MatrixLenght; j++)
            {
                digitsAreSummed = false;
                for (int i = MatrixLenght - 2; i >= 0; i--)
                {
                    // when a digit can be moved
                    if (matrix[i, j] != 0 && matrix[i + 1, j] == 0)
                    {
                        SwapSquares(ref matrix[i, j], ref matrix[i + 1, j]);
                        if (i < MatrixLenght-2) i += 2; // to not get out of range
                    }
                    // when squares are equal, not zeroes and the one before is not a sum
                    else if (matrix[i + 1, j] == matrix[i, j] && matrix[i, j] != 0 && !digitsAreSummed)
                    {
                        matrix[i + 1, j] += matrix[i, j];
                        matrix[i, j] = 0;
                        digitsAreSummed = true;
                    }
                    // when digits reach their place 
                    else if (matrix[i + 1, j] != 0) digitsAreSummed = false;
                }
            }
            return matrix;
        }

        /* PRIVATE METHODS */
        private int GetNewValue()
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 100);
            if (chance < 20) return 4;
            else return 2;
        }
        private void SwapSquares(ref int sq1, ref int sq2)
        {
            int sq;
            sq = sq1;
            sq1 = sq2;
            sq2 = sq;
        }
    }
}