using Microsoft.AspNetCore.Mvc;

namespace MVCBootstrap.Areas.Admin.Controllers
{
    public class NosotrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
