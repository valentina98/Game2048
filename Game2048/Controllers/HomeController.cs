using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Game2048.Models;
using Game2048.Managers;
using Microsoft.AspNetCore.Http; // Needed for the SetString and GetString extension methods
using Newtonsoft.Json;

namespace Game2048.Controllers
{
    public class HomeController : Controller
    {
        // declare the _gameManager interface
        private IGameManager _gameManager { get; set; }
        //
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        // the constructor injects _gameManager and _httpContextAccessor
        public HomeController(IGameManager gameManager, IHttpContextAccessor httpContextAccessor)
        {
            _gameManager = gameManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public ActionResult Index()
        {
            GameBoardViewModel GBVM;

            if (_session.GetString("GameBoard") == null)
            {
                GBVM = new GameBoardViewModel() { Matrix = _gameManager.InitializeMatrix() };
                _session.SetString("GameBoard", JsonConvert.SerializeObject(GBVM));
            }
            else
            {
                //https://stackoverflow.com/questions/44192365/jsonconvert-deserializeobjectienumerablebook
                GBVM = JsonConvert.DeserializeObject<GameBoardViewModel>(_session.GetString("GameBoard"));
            }
            return View(GBVM);
        }

        [HttpPost]
        public ActionResult Swipe(string direction) //async Task<ActionResult>
        {
            GameBoardViewModel GBVM = JsonConvert.DeserializeObject<GameBoardViewModel>(_session.GetString("GameBoard"));
            
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
                    //GBVM.Matrix = _gameManager.SwipeUp(GBVM.Matrix);  
                    break;
            }
            _gameManager.AddNewDigit(GBVM.Matrix);

            GBVM.Score = _gameManager.FindScore(GBVM.Matrix);

            if (GBVM.Score >= 2048)
            {
                //GBVM.State = _gameManager.Win();
                GBVM.State = "You Win!";
            }

            int count = _gameManager.GetNumEmptyCells(GBVM.Matrix);
            if (count == 0)
            {
                if (_gameManager.CanBeSwiped(GBVM.Matrix))
                {
                    //GBVM.State = _gameManager.GameOver();
                    GBVM.State = "Game Over!";
                }
            }

            _session.SetString("GameBoard", JsonConvert.SerializeObject(GBVM));
            return PartialView("_GameBoard", GBVM);
        }

        [HttpPost]
        public ActionResult NewGame()
        {
            GameBoardViewModel GBVM = JsonConvert.DeserializeObject<GameBoardViewModel>(_session.GetString("GameBoard"));
            
            GBVM.Matrix = _gameManager.InitializeMatrix();
            if (GBVM.BestScore < GBVM.Score)
                GBVM.BestScore = GBVM.Score;
            

            _session.SetString("GameBoard", JsonConvert.SerializeObject(GBVM));
            return PartialView("_GameBoard", GBVM);
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            ViewBag.Message = HttpContext.Session.GetString("Test"); /////////////
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