using ExeRibeiroCipriano.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeRibeiroCipriano.Controllers
{
    public class FuncionarioController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastroFunc(Funcionario funcionario)
        {
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult SelectFunc(FormCollection funcionario)
        {
      
            ViewBag.codigo = funcionario["codigo"];
            ViewBag.nome = funcionario["nome"];
            ViewBag.funcao = funcionario["funcao"];

            return View();
        }
    }
}