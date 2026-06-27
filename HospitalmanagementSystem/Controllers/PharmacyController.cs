using Microsoft.AspNetCore.Mvc;

namespace HospitalmanagementSystem.Controllers
{
    public class PharmacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
