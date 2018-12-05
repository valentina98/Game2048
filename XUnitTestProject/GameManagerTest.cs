using Game2048.Managers;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class GameManagerTest
    {
        [Fact]
        public void SwipingLeft()
        {
            // Arrange
            GameManager GM = new GameManager();
            int[,] matrixOriginal = new int[4, 4]
           {
                {2,2,0,4},
                //{0,0,0,4},
                {4,2,2,0},
                {2,0,4,4},
                {0,2,4,2}
           };
            int[,] matrixChanged = new int[4, 4]
           {
                {4,4,0,0},
                //{4,0,0,0},
                {4,4,0,0},
                {2,8,0,0},
                {2,4,2,0}
           };
            // Act
            var result = GM.SwipeLeft(matrixOriginal);
            // Assert
            Assert.Equal(matrixChanged, result);
        }
        [Fact]
        public void SwipingUp()
        {
            // Arrange
            GameManager GM = new GameManager();
            int[,] matrixOriginal = new int[4, 4]
           {
                {2,2,0,4},
                {4,2,2,0},
                {2,0,4,4},
                {0,2,4,8}
           };
            int[,] matrixChanged = new int[4, 4]
           {
                {2,4,2,8},
                {4,2,8,8},
                {2,0,0,0},
                {0,0,0,0}
           };
            // Act
            var result = GM.SwipeUp(matrixOriginal);
            // Assert
            Assert.Equal(matrixChanged, result);
        }
        [Fact]
        public void SwipingRight()
        {
            // Arrange
            GameManager GM = new GameManager();
            int[,] matrixOriginal = new int[4, 4]
           {
                {4,2,2,0},
                {2,2,0,4},
                {2,0,4,4},
                {0,2,4,2}
           };
            int[,] matrixChanged = new int[4, 4]
           {
                {0,0,4,4},
                {0,0,4,4},
                {0,0,2,8},
                {0,2,4,2}
           };
            // Act
            var result = GM.SwipeRight(matrixOriginal);
            // Assert
            Assert.Equal(matrixChanged, result);
        }
        /*
        [Fact]
        public void SwipingDown()
        {
            // Arrange
            GameManager GM = new GameManager();
            int[,] matrixOriginal = new int[4, 4]
           {
                {4,2,0,4},
                {2,2,2,0},
                {2,0,4,4},
                {0,2,4,2}
           };
            int[,] matrixChanged = new int[4, 4]
           {
                {0,0,0,0},
                {0,0,0,0},
                {4,2,2,8},
                {4,4,8,2}
           };
            // Act
            var result = GM.SwipeDown(matrixOriginal);
            // Assert
            Assert.Equal(matrixChanged, result);
        }
        [Fact]
        public void AddingNewDigit()
        {
            // Arrange
            GameManager GM = new GameManager();
            int[,] matrixOriginal = new int[4, 4]
           {
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0}
                //{2,2,2,0},
                //{2,0,4,4},
                //{0,2,4,2}
           };
            // Act
            var result = GM.AddNewDigit(matrixOriginal);
            // Assert
            Assert.NotEqual(matrixOriginal, result);

            //////// why fails???? 
            //////// aseert for when it is full and can/cannot be swiped
        }*/
    }
}