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
        public IActionResult Index()
        {
            var vm = new GameBoardViewModel();
            vm.Matrix =  _gameManager.InitializeMatrix();
            //////////////////// ajax?
            return View(vm);
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
