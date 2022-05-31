using KanbanBoardDemo.Models;
using KanbanBoardDemo.Services;
using KanbanBoardDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KanbanBoardDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BoardService _boardService;
        public HomeController(ILogger<HomeController> logger, BoardService boardService)
        {
            _logger = logger;
            _boardService = boardService;
        }

        public IActionResult Index()
        {
            var model = _boardService.ListBoard();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(NewBoard viewModel)
        {
            _boardService.AddBoard(viewModel);

            return RedirectToAction(nameof(Index));
        }
         
        [HttpPost]
        public IActionResult Delete(BoardView boardView)
        {
            try
            {
                _boardService.DeleteBoard(boardView.Id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
