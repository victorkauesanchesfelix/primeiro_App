using Microsoft.AspNetCore.Mvc;

namespace primeiro_App.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nota = "Aluno Nota 10";
            ViewData["Escola"] = "E.E. Anhanguera";
            return View();
        }
    }
}
