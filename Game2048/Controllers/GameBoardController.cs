using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Game2048.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Game2048.Controllers
{
    
    public class GameBoardController : Controller
    {
        ////// sesson!
        // the logic stays in GameManager
        // shouldn't have new int[,]
        
         public int[,] Initialize()
        {
            GameManager GM = new GameManager(); 
            int[,] matrix = GM.InitializeMatrix();



            //matrix = GM.SwipeLeft(matrix);
            //Thread.Sleep(3000);
            /*switch (Console.ReadKey().Key)
            {
                case ConsoleKey.LeftArrow:
                    GM.SwipeLeft(matrix);
                    break;
            }*/
            return matrix;
        }

    }
}