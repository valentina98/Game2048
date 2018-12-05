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
            var vm = await this.GetGameBoardViewModel();
            return View(vm);
        }
        [HttpGet]
        public async Task<ActionResult> GetCellValues() // should be a liststring cell
        {
            //var cellVal = int.Parse(cell);
            var model = await this.GetGameBoardViewModel();//cellVal
            return PartialView("_GameBoard", model);
        }
        private async Task<GameBoardViewModel> GetGameBoardViewModel() //int cellVal = 0
        {
            var fullAndPartialViewModel = new GameBoardViewModel(); //shouldn't be a new one
            fullAndPartialViewModel.Matrix = _gameManager.InitializeMatrix();
            // populate the viewModel and return it
            return fullAndPartialViewModel;
        }


        [HttpPost]
        public ActionResult UpdateVM(GameBoardViewModel model)
        {
            var view = GetCellValues();


            return View(view);
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
