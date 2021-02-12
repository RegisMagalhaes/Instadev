using Microsoft.AspNetCore.Mvc;

namespace Instadev.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}