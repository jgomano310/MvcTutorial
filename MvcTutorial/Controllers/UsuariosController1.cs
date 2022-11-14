using Microsoft.AspNetCore.Mvc;

namespace MvcTutorial.Controllers
{
    public class UsuariosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaUsuarios()
        {

            List<string> ListaUsuarios=new List<string>();
            ListaUsuarios.Add("javi");
            ListaUsuarios.Add("gómez");
            ListaUsuarios.Add("cano");
            ListaUsuarios.Add("ramirez");
            return View(ListaUsuarios);
        }
    }
}
