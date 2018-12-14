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
using Newtonsoft.Json;

namespace Game2048.Controllers
{

    public class GameBoardController : Controller
    {
        // declare the _gameManager interface
        private IGameManager _gameManager { get; set; }
        //
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        // the constructor injects _gameManager and _httpContextAccessor
        public GameBoardController(IGameManager gameManager, IHttpContextAccessor httpContextAccessor)
        {
            _gameManager = gameManager;
            _httpContextAccessor = httpContextAccessor;
        }
        GameBoardViewModel GBVM = new GameBoardViewModel();
        public void GbvmSessionSet(GameBoardViewModel GBVM)
        {
            _session.SetObjectAsJson("GameBoardViewModel", GBVM);
        }
        public void GbvmSessionGet()
        {
            GBVM = _session.GetObjectFromJson<GameBoardViewModel>("GameBoardViewModel");
        }

        public void Initialize()
        {
            GBVM.Matrix = _gameManager.InitializeMatrix();
            //set score
            GbvmSessionSet(GBVM);
        }
        public void Swipe(string direction)
        {
            GbvmSessionGet();
            // in the home controller/index
            //if (_session.GetString("GameBoard") == null)
            //{
            //      Initialize();
            //}
            //else
            //{
            //    GBVM = _session.GetObjectFromJson<GameBoardViewModel>("Gameboard");
            //}
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
                outcome = _gameManager.Win(); //not like that
            }

            int count = _gameManager.GetNumEmptyCells(GBVM.Matrix);
            if (count == 0)
                if (_gameManager.CanBeSwiped(GBVM.Matrix))
                    outcome = _gameManager.GameOver();

            GBVM.State = outcome;

            GbvmSessionSet(GBVM);
        }



        /////////////
        














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
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            //var deserializedList = JsonConvert.DeserializeObject<List<T>>(value);
            var deserializedIenum = JsonConvert.DeserializeObject<IEnumerable<T>>(value);

            return value == null ? default(T) :
                JsonConvert.DeserializeObject<T>(value);

            
            //deserialize "{\"BoardSize\":4,\"Matrix\":[[0,0,0,0],[0,0,2,0],[0,0,0,0],[2,0,0,0]],\"Score\":0,\"BestScore\":0,\"State\":\"\"}"
        }
    }

}