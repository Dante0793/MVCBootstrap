using Microsoft.AspNetCore.Mvc;

namespace MVCBootstrap.Areas.Admin.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
