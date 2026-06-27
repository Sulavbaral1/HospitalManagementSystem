using Microsoft.AspNetCore.Mvc;

namespace HospitalmanagementSystem.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
