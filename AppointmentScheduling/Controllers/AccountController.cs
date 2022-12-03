using AppointmentScheduling.Data;
using AppointmentScheduling.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheduling.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AccountController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            return View();
        }
    }
}