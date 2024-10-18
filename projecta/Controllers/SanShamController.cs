using Microsoft.AspNetCore.Mvc;

namespace projecta.Controllers
{
    public class SanShamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

