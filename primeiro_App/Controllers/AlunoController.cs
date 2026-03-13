using Microsoft.AspNetCore.Mvc;

namespace primeiro_App.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
