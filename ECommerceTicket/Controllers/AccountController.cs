using Microsoft.AspNetCore.Mvc;

namespace ECommerceTicket.Controllers
{
    public class AccountController : Controller
    {
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }
    }
}
