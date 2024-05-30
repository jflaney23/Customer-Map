using Microsoft.AspNetCore.Mvc;
using CustomerMapApp.Data;
using CustomerMapApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerMapApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBContext _context;

        public HomeController(DBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _context.Customers.ToListAsync();
            return View(customers);
        }
    }
}