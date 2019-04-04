using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game2048.Managers
{
    // interface to inherit by GameManager class
    public interface IGameManager
    {
        int[,] InitializeMatrix();
        int[,] AddNewDigit(int[,] mx);
        int[,] SwipeLeft(int[,] mx);
        int[,] SwipeRight(int[,] mx);
        int[,] SwipeUp(int[,] mx);
        int[,] SwipeDown(int[,] mx);
        int FindScore(int[,] mx);
        bool CheckWin(int[,] mx);
        bool CanBeSwiped(int[,] mx);
        int GetNumEmptyCells(int[,] mx);
    }
}
