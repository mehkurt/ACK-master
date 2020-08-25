using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ACK.WebUI.Models;
using ACK.Data.Models;

namespace ACK.WebUI.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private ACKContext db;

        public HomeController(ILogger<HomeController> logger, ACKContext db) {
            this.db = db;
            _logger = logger;
        }

        public IActionResult Index() {
            var model = db.Products.FirstOrDefault();
            return View(model);
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
