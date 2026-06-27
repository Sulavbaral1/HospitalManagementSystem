using Microsoft.AspNetCore.Mvc;

namespace HospitalmanagementSystem.Controllers
{
    public class LaboratoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
