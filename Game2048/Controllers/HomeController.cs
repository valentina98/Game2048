using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Game2048.Models;
using Game2048.Managers;

namespace Game2048.Controllers
{
    public class HomeController : Controller
    {
        // declare the _gameManager interface
        private IGameManager _gameManager { get; set; }
        // the constructor sets the _gameManager
        public HomeController(IGameManager gameManager)
        {
            _gameManager = gameManager;
        }
        GameBoardViewModel GBVM;
        

        
        public ActionResult Index()
        {
            if (HttpContext.Session["GameBoard"] == null)
            {
                GBVM.Matrix = _gameManager.InitializeMatrix();
                HttpContext.Session["GameBoard"] = GBVM;
            }
            else
                GBVM = (int[,]HttpContext.Session["GameBoard"])

            return View(GBVM);
        }

        ///********************************/
        // https://cmatskas.com/update-an-mvc-partial-view-with-ajax/
        [HttpGet]
        public async Task<ActionResult> UpdateGameBoard()
        {
            GBVM = await this.FullAndPartialViewModel();
            return PartialView("_GameBoard", GBVM);
        }
        private async Task<GameBoardViewModel> FullAndPartialViewModel(int[,] matrix = null) // optional array param
        {
            // populate the viewModel and return it
            return GBVM;
        }
        ///********************************/


        [HttpPost]
        public async Task<ActionResult> Swipe( string direction = null)
        {//List<int> cellValues,
            //int[] cellValArr = cellValues.ToArray();
            //int[,] matrix = new int[GBVM.BoardSize, GBVM.BoardSize];
            //for (int i = 0; i < GBVM.BoardSize; i++)
            //    for (int j = 0; j < GBVM.BoardSize; j++)
            //        matrix[i, j] = cellValArr[i + j];
            GBVM = (int[,])HttpContext.Session["GameBoard"]);

            switch (direction)
            {
                case "up":
                    GBVM.Matrix = _gameManager.SwipeUp(GBVM.Matrix); 
                    // GBVM is a global variable, type GameBoardViewModel
                    break;
                case "down":
                    GBVM.Matrix = _gameManager.SwipeDown(GBVM.Matrix);
                    break;
                case "left":
                    GBVM.Matrix = _gameManager.SwipeLeft(GBVM.Matrix);
                    break;
                case "right":
                    GBVM.Matrix = _gameManager.SwipeRight(GBVM.Matrix);
                    break;
                default:
                    GBVM.Matrix = _gameManager.InitializeMatrix();
                    break;
            }
            GBVM.Score = _gameManager.FindScore(GBVM.Matrix);
            string outcome = "";
            if (GBVM.Score >= 2048)
            {
                outcome = _gameManager.Win();
            }

            int count = _gameManager.GetNumEmptyCells(GBVM.Matrix);
            if (count == 0)
                if (_gameManager.CanBeSwiped(GBVM.Matrix))
                    outcome = _gameManager.GameOver();

            GBVM.State = outcome;

            HttpContext.Session["GameBoard"] = GBVM;
            
            return PartialView("_GameBoard", GBVM);
        }

        [HttpPost]
        public ActionResult NewGame()
        {
            GBVM.Matrix = _gameManager.InitializeMatrix();
            if (GBVM.BestScore < GBVM.Score)
                GBVM.BestScore = GBVM.Score;
            
            HttpContext.Session["GameBoard"] = GBVM;

            return PartialView("_GameBoard", GBVM);
        }
  


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
