using Microsoft.AspNetCore.Mvc;

namespace MVCBootstrap.Areas.Admin.Controllers
{
    public class ServiciosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
