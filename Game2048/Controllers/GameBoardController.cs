using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Game2048.Managers;
using Game2048.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Game2048.Controllers
{

    public class GameBoardController : Controller
    {
        ////// sesson!
        // the logic stays in GameManager
        // shouldn't have new int[,]

        //public int[,] Initialize()
        //{
        //    GameBoardViewModel GBVM = new GameBoardViewModel();
        //    GameManager GM = new GameManager();
        //    GBVM.Matrix = GM.InitializeMatrix();
        //    return GBVM.Matrix;
        //}
        //public ActionResult SwipeLeft()
        //{
        //    GameBoardViewModel GBVM = new GameBoardViewModel();
        //    GameManager GM = new GameManager();
        //    int[,] matrix = GBVM.Matrix;
        //    GBVM.Matrix = GM.SwipeLeft(GBVM.Matrix);
        //    UpdateScore();
        //    return View();
        //}
        //public ActionResult SwipeRight()
        //{
        //    GameBoardViewModel GBVM = new GameBoardViewModel();
        //    GameManager GM = new GameManager();
        //    GBVM.Matrix = GM.SwipeRight(GBVM.Matrix);
        //    UpdateScore();
        //    return View();
        //}
        //public ActionResult SwipeUp()
        //{
        //    GameBoardViewModel GBVM = new GameBoardViewModel();
        //    GameManager GM = new GameManager();
        //    GBVM.Matrix = GM.SwipeUp(GBVM.Matrix);
        //    UpdateScore();
        //    return View();
        //}
        //public ActionResult SwipeDown()
        //{
        //    GameBoardViewModel GBVM = new GameBoardViewModel();
        //    GameManager GM = new GameManager();
        //    GBVM.Matrix = GM.SwipeDown(GBVM.Matrix);
        //    UpdateScore();
        //    return View();
        //}
        
        //public ActionResult NewGame()
        //{
        //    //save
        //    Initialize();
        //    return View();
        //}

        ///*PRIVATE FUNCTIONS*/
        //private void UpdateScore()
        //{
        //    GameBoardViewModel GBVM = new GameBoardViewModel();
        //    GameManager GM = new GameManager();
        //    int[,] matrix = GBVM.Matrix;
        //    int score = GM.FindScore(matrix);
            
        //    GBVM.Score = score;
        //    if(score> GBVM.BestScore) GBVM.BestScore = score;

        //    if (score >= 2048) GM.Win();
        //}
    }
}