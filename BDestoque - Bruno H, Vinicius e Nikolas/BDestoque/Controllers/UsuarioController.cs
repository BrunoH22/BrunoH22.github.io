using BDestoque.Data;
using BDestoque.Models;
using Microsoft.AspNetCore.Mvc;

namespace BDestoque.Controllers
{
    public class UsuarioController : Controller
    {
        BancoDados bancodados;


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cadastro()
        {
            UsuarioViewModel conta = new UsuarioViewModel();
            return View(conta);
        }
    }
}
