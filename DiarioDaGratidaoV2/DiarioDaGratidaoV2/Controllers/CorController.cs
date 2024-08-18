using Microsoft.AspNetCore.Mvc;

namespace DiarioDaGratidaoV2.Controllers
{
    public class CorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
