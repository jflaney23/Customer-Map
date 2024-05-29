using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerMapApp.Data;
using CustomerMapApp.Models;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace CustomerMapApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly DBContext _context;

        public CustomersController(DBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNumber,OnFacebook,Email,StreetAddress,City,State,ZipCode,Country")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(customer);
        }
    }
}