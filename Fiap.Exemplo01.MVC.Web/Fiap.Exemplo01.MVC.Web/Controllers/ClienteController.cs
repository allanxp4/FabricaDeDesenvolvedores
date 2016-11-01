using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ClienteController : Controller
    {

        private static List<Cliente> _lista = new List<Cliente>();
        //CRIAR UMA LISTA DE CASADO, SOLTEIRO, ETC
        private static List<string> _lista2 = new List<string>() {"","Solteiro(a)", "Casado(a)", "Divorciado(a)"};

        [HttpGet]
        public ActionResult Cadastrar()
        {

            ViewBag.Civil = new SelectList(_lista2);

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente c)
        {
            _lista.Add(c);
           
            TempData["mensagem"] = "Cadastrado com sucesso";

            return RedirectToAction("Cadastrar");
        }

  
        public ActionResult Listar(Cliente cliente)
        {

           
            return View(_lista);
        }


    }
}