using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Net_5_CustomTagHelpers.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Net_5_CustomTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //example for TrTagHelper
        public IActionResult Index()
        {
            Product vm = new()
            {
                Name ="Kayak",
                Price =275,
                CategoryId = 1
            };
            return View(vm);
        }

        //example for TableHeadTagHelper
        public IActionResult Privacy()
        {
            Product vm = new()
            {
                Name = "Kayak",
                Price = 275,
                CategoryId = 1
            };
            return View(vm);
        }

        //example for ContentWrapperTagHelper
        public IActionResult PreElementPostElement()
        {
            Product vm = new()
            {
                Name = "Kayak",
                Price = 275,
                CategoryId = 1
            };
            return View(vm);
        }

        //example for HighlightTagHelper
        public IActionResult HighlightTagHelper()
        {
            Product vm = new()
            {
                Name = "Kayak",
                Price = 275,
                CategoryId = 1
            };
            return View(vm);
        }

        //example of coordination between taghelpers
        public IActionResult coordination()
        {
            Product vm = new()
            {
                Name = "Kayak",
                Price = 275,
                CategoryId = 1
            };
            return View(vm);
        }

        //example of coordination between SelectiveTagHelper
        public IActionResult SuppressOuput()
        {
            Product vm = new()
            {
                Name = "Kayak",
                Price = 2, //set to above 100 to include element in html
                CategoryId = 1
            };
            return View(vm);
        }
    }
}
