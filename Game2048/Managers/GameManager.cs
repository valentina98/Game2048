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
            int[,] matrix = new int[MatrixLenght, MatrixLenght];
           /*{
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0}
           };*/ // not nessesary, new int creates empty arr
            AddNewDigit(matrix);
            AddNewDigit(matrix);
            return matrix;
        }
        public int[,] AddNewDigit(int[,] matrix)  
        {
            Random rnd = new Random();

            int count = GetNumEmptyCells(matrix);
            int rndEmptyCellNum = rnd.Next(0, count);

            for (int i = 0; i < MatrixLenght; i++)
            {
                for (int j = 0; j < MatrixLenght; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        if (rndEmptyCellNum == 0)
                        {
                            matrix[i, j] = GetNewValue();
                            i = MatrixLenght; // breaks the outer loop
                            break;
                        }  
                        else rndEmptyCellNum--;
                    }
                }
            }
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
                    // when the cell is not 0
                    if (matrix[i, j] != 0)
                    {
                        // when the previous cell is 0
                        if (matrix[i, j - 1] == 0)
                        {
                            SwapSquares(ref matrix[i, j], ref matrix[i, j - 1]);
                            if (j > 1) j -= 2; // go back to check if the cell can be moved again (but check if it gets out of range)
                        }
                        // when the previous cell contains a number
                        else
                        {
                            // when the 2 cells are equal and the previous one is not a sum
                            if (matrix[i, j - 1] == matrix[i, j] && !digitsAreSummed)
                            {
                                matrix[i, j - 1] += matrix[i, j];
                                matrix[i, j] = 0;
                                digitsAreSummed = true;
                            }
                            // when the cell has reached its place 
                            else
                            {
                                digitsAreSummed = false;
                            }
                        }
                    }
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
                for (int j = MatrixLenght - 2; j >= 0; j--)
                {
                    // when the cell is not 0
                    if (matrix[i, j] != 0)
                    {
                        // when the previous cell is 0
                        if (matrix[i, j + 1] == 0)
                        {
                            SwapSquares(ref matrix[i, j], ref matrix[i, j + 1]);
                            if (j < MatrixLenght - 2) j += 2; // go back to check if the cell can be moved again (but check if it gets out of range)
                        }
                        // when the previous cell contains a number
                        else
                        {
                            // when the 2 cells are equal and the previous one is not a sum
                            if (matrix[i, j + 1] == matrix[i, j] && !digitsAreSummed)
                            {
                                matrix[i, j + 1] += matrix[i, j];
                                matrix[i, j] = 0;
                                digitsAreSummed = true;
                            }
                            // when the cell has reached its place 
                            else
                            {
                                digitsAreSummed = false;
                            }
                        }
                    }
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
                    // when the cell is not 0
                    if (matrix[i, j] != 0)
                    {
                        // when the previous cell is 0
                        if (matrix[i - 1, j] == 0)
                        {
                            SwapSquares(ref matrix[i, j], ref matrix[i - 1, j]);
                            if (i > 1) i -= 2; // go back to check if the cell can be moved again (but check if it gets out of range)
                        }
                        // when the previous cell contains a number
                        else
                        {
                            // when the 2 cells are equal and the previous one is not a sum
                            if (matrix[i - 1, j] == matrix[i, j] && !digitsAreSummed)
                            {
                                matrix[i - 1, j] += matrix[i, j];
                                matrix[i, j] = 0;
                                digitsAreSummed = true;
                            }
                            // when the cell has reached its place 
                            else
                            {
                                digitsAreSummed = false;
                            }
                        }
                    }
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
                    // when the cell is not 0
                    if (matrix[i, j] != 0)
                    {
                        // when the previous cell is 0
                        if (matrix[i + 1, j] == 0)
                        {
                            SwapSquares(ref matrix[i, j], ref matrix[i + 1, j]);
                            if (i < MatrixLenght - 2) i += 2; // go back to check if the cell can be moved again (but check if it gets out of range)
                        }
                        // when the previous cell contains a number
                        else
                        {
                            // when the 2 cells are equal and the previous one is not a sum
                            if (matrix[i + 1, j] == matrix[i, j] && !digitsAreSummed)
                            {
                                matrix[i + 1, j] += matrix[i, j];
                                matrix[i, j] = 0;
                                digitsAreSummed = true;
                            }
                            // when the cell has reached its place 
                            else
                            {
                                digitsAreSummed = false;
                            }
                        }
                    }
                }
            }
            return matrix;
        }

        public int FindScore (int[,] matrix)
        {
            int score = 0;
            for (int i = 0; i < MatrixLenght; i++)
            {
                for (int j = 0; j < MatrixLenght; j++)
                {
                    score += matrix[i, j];
                }
            }
            return score;
        }

        public bool CheckWin(int[,] matrix)
        {
            for (int i = 0; i < MatrixLenght; i++)
            {
                for (int j = 0; j < MatrixLenght; j++)
                {
                    if (matrix[i, j] == 2048) return true;
                }
            }
            return false;
        }

        public bool CanBeSwiped(int[,] matrix)
        {
            ///////////var mx = string.Join(matrix.Select(p => p.ToString()).ToArray())
            var mxU = SwipeUp(matrix);
            var mxD = SwipeDown(matrix);
            var mxR = SwipeRight(matrix);
            var mxL = SwipeLeft(matrix);

            var allEqual = matrix.Cast<int>().SequenceEqual(mxU.Cast<int>()) &&
                           matrix.Cast<int>().SequenceEqual(mxD.Cast<int>()) &&
                           matrix.Cast<int>().SequenceEqual(mxR.Cast<int>()) &&
                           matrix.Cast<int>().SequenceEqual(mxL.Cast<int>());

            if (allEqual) return false;
            else return true;
        }
        public int GetNumEmptyCells(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < MatrixLenght; i++)
                for (int j = 0; j < MatrixLenght; j++)
                    if (matrix[i, j] == 0)
                        count++;
            return count;
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