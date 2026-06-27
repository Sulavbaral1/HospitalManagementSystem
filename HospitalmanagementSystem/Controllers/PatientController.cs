using Microsoft.AspNetCore.Mvc;

namespace HospitalmanagementSystem.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
