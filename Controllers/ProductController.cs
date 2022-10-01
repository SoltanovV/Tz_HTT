using Microsoft.AspNetCore.Mvc;

namespace Tz_HTT.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
