using Microsoft.AspNetCore.Mvc;

namespace WebApplicationCoreMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Studentadd()
        {
            return View();
        }
    }
}
