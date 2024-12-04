using Microsoft.AspNetCore.Mvc;

namespace Empreendendo_com_SystemLock.Controllers
{
    public class AcessosController : Controller
    {
     

        //=====ABA PARA FUNCIONARIO=============================
        public IActionResult Criar_Perfil_Funcionario()
        {
            return View();
        }
        public IActionResult Perfil_Administrador()
        {
            return View();
        }
        public IActionResult Perfil_Funcionario()
        {
            return View();
        }

        //=====ABA PARA CLIENTE
        public IActionResult _Criar_Perfil_Cliente()
        {
            return View();
        }
        public IActionResult _Perfil_Cliente()
        {
            return View();
        }



        public IActionResult Retornar()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout-geral.cshtml";
            return RedirectToAction("Usuario", "Pagina_Home");

        }
    }
}
