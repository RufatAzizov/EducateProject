
using Microsoft.AspNetCore.Mvc;

namespace Educate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
