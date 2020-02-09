using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PawsiblePals.Data;
using PawsiblePals.Models;

namespace PawsiblePals.Controllers
{
    public class HomeController : Controller
    {
        //creating ID
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<PawsiblePals.Models.Account> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, UserManager<PawsiblePals.Models.Account> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var user = _userManager.GetUserAsync(User);
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
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Feed()
        {
            return View();
        }
        public IActionResult Search()
        {

            return View();
        }
        public IActionResult Resource()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
       
        public IActionResult Donations()
        {
            return View();
        }
    }
}
