using Fiap.Exemplo02.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Web.Controllers
{
    public class AlunoController : Controller
    {
        private PortalContext _context = new PortalContext();

        // GET: Aluno
        public ActionResult Cadastrar()
        {
            return View("Cadastrar");
        }

        [HttpPost]
        public ActionResult Cadastrar(Aluno a)
        {
            TempData["msg"] = "Cadastrado com sucesso";
            _context.Aluno.Add(a);
            _context.SaveChanges();

            return View();
        }

        public ActionResult Listar()
        {
          List<Aluno> lista = _context.Aluno.ToList();

            return View(lista);
        }
    }
}