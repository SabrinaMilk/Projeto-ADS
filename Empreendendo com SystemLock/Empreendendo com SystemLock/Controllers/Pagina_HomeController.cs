using Microsoft.AspNetCore.Mvc;

namespace SystemLock___Projeto_2024.Controllers
{
    public class Pagina_HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            return View();
        }
        public IActionResult Ajuda()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout-geral.cshtml";
            return View();
        }
        public IActionResult Contato()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout-geral.cshtml";
            return View();
        }
        public IActionResult Sobre()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout-geral.cshtml";
            return View();
        }
        public IActionResult Produtos()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout-geral.cshtml";
            return View();
        }
        public IActionResult Usuario()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout-geral.cshtml";
            return View();
        }
        public IActionResult Funcionarios()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout-geral.cshtml";
            return View();
        }
    }
}
