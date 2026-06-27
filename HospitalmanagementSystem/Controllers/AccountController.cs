using Microsoft.AspNetCore.Mvc;

namespace HospitalmanagementSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
