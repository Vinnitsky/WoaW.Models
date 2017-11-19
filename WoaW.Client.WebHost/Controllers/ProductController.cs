using Microsoft.AspNetCore.Mvc;

namespace Vue2SpaSignalR.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
