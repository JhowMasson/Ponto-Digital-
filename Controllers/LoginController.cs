using Microsoft.AspNetCore.Mvc;

namespace CSharpi_Html.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}