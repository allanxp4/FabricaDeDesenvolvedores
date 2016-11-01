using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ProdutoController : Controller
    {

        private static List<Produto> _lista = new List<Produto>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }

        [HttpGet]//Carrega a página com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        //mvc  + tab tab = isso
        [HttpPost]
        public ActionResult Cadastrar(Produto p)
        {
            _lista.Add(p);
            //Passa a inrformação para view
            ViewBag.prod = p;
            TempData["mensagem"] = "produto Cadastrado";

            //retorna a view Sucesso.cshtml
            return RedirectToAction("Cadastrar");
            //return Content(nome + " " + valor + " " + qtd);
        }

    }
}