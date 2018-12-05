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
        
        // when opened index page
        [HttpGet]
        public async Task<ActionResult> Index()
        {

            var vm = await this.FullAndPartialViewModel();
            return View(vm);
        }
        [HttpGet]
        public async Task<ActionResult> UpdateGameBoard(List<int> cellValues) // async get
        {
            var VM = await this.FullAndPartialViewModel();

            int[] cellValArr = cellValues.ToArray();
            int[,] matrix = new int[VM.BoardSize, VM.BoardSize];
            for (int i = 0; i < VM.BoardSize; i++)
                for (int j = 0; j < VM.BoardSize; j++)
                    matrix[i,j] = cellValArr[i+j];
            
            VM.Matrix = matrix;

            return PartialView("_GameBoard", VM);
        }
        private async Task<GameBoardViewModel> FullAndPartialViewModel(int[,] matrix = null) // optional array param
        {
            var fullAndPartialViewModel = new GameBoardViewModel(); //shouldn't be a new one
            if (matrix != null)
            {
                fullAndPartialViewModel.Matrix = matrix;
            }
            else
            {
                fullAndPartialViewModel.Matrix = _gameManager.InitializeMatrix();
            } /*  ??????????? How to pass the hidden inputs to the matrix  */
            
            // populate the viewModel and return it
            return fullAndPartialViewModel;
        }
        //[HttpPost]
        //public ActionResult UpdateVM(GameBoardViewModel model)
        //{
        //    var view = GetCellValues();
        //    return View(view);
        //}
        [HttpPost]
        public async Task<ActionResult> Index(int[,] matrix)
        {
            var model = await this.FullAndPartialViewModel(matrix);
            model.Matrix = matrix;
            return PartialView("_GameBoard", model);
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
