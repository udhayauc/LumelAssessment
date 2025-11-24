using Microsoft.AspNetCore.Mvc;

namespace LumelAssessment.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
