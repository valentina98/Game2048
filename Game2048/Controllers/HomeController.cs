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
                GBVM = new GameBoardViewModel();
                GBVM.Matrix = _gameManager.InitializeMatrix();
                //_session.SetObjectAsJson("GameBoard", GBVM);
                _session.SetString("GameBoard", JsonConvert.SerializeObject(GBVM));
                //var value = _session.GetString("GameBoard");
            }
            else
            {
                //https://stackoverflow.com/questions/44192365/jsonconvert-deserializeobjectienumerablebook
                GBVM = JsonConvert.DeserializeObject<GameBoardViewModel>(_session.GetString("GameBoard"));
                //GBVM = _session.GetObjectFromJson<GameBoardViewModel>("Gameboard");
            }
            return View(GBVM);
        }

        ///********************************/
        //// https://cmatskas.com/update-an-mvc-partial-view-with-ajax/
        //[HttpGet]
        //public async Task<ActionResult> UpdateGameBoard()
        //{
        //    GameBoardViewModel GBVM = _session.GetObjectFromJson<GameBoardViewModel>("Gameboard");

        //    GBVM = await this.FullAndPartialViewModel();
        //    return PartialView("_GameBoard", GBVM);
        //}
        //private async Task<GameBoardViewModel> FullAndPartialViewModel(int[,] matrix = null) // optional array param
        //{
        //    // populate the viewModel and return it

        //    GameBoardViewModel GBVM = _session.GetObjectFromJson<GameBoardViewModel>("Gameboard");

        //    return GBVM;
        //}
        ///********************************/


        [HttpPost]
        public ActionResult Swipe(string direction = null) //async Task<ActionResult>
        {
            //GameBoardViewModel GBVM = _session.GetObjectFromJson<GameBoardViewModel>("Gameboard");
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
                    //GBVM.Matrix = _gameManager.InitializeMatrix();
                    GBVM.Matrix = _gameManager.SwipeUp(GBVM.Matrix);  // it is null
                    break;
            }
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

            //_session.SetObjectAsJson("GameBoard", GBVM);
            var value = _session.GetString("GameBoard");
            GBVM = JsonConvert.DeserializeObject<GameBoardViewModel>(value);

            return PartialView("_GameBoard", GBVM);
        }

        //[HttpPost]
        //public ActionResult NewGame()
        //{
        //    GameBoardViewModel GBVM = _session.GetObjectFromJson<GameBoardViewModel>("Gameboard");
        //    //
        //    GBVM.Matrix = _gameManager.InitializeMatrix();
        //    if (GBVM.BestScore < GBVM.Score)
        //        GBVM.BestScore = GBVM.Score;


        //    return PartialView("_GameBoard", GBVM);
        //}



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
//    ///////////////
//    public static class SessionExtensions
//    {
//        public static void SetObjectAsJson(this ISession session, string key, object value)
//        {
//            session.SetString(key, JsonConvert.SerializeObject(value));
            
//        }

//        public static T GetObjectFromJson<T>(this ISession session, string key)
//        {
//            var value = session.GetString(key);

//            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
//        }
//    }
//}
