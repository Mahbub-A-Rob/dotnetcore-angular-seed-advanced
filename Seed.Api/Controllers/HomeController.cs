using Microsoft.AspNetCore.Mvc;

namespace Css.Api.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}