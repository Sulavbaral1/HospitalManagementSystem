using Microsoft.AspNetCore.Mvc;

namespace HospitalCarePro.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}