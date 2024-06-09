using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCRUD.Web.Data;
using StudentCRUD.Web.Models;
using System.Diagnostics;

namespace StudentCRUD.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext,
                              ILogger<HomeController> logger)
        {
            this.dbContext = dbContext;
            _logger = logger;
        }

        public ApplicationDbContext DbContext { get; }

        private readonly ILogger<HomeController> _logger;


        public async Task<IActionResult> Index()
        {
            var students = await dbContext.Students.ToListAsync();

            return View(students);
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
