using Inicial.DAO;
using Inicial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inicial.Controllers
{
    public class CategoriaController : Controller
    {
        CategoriaDAO categoriaDAO = new CategoriaDAO();


        //
        // GET: /Categoria/
        public ActionResult Index()
        {
            IList<CategoriaProduto> categorias = categoriaDAO.lista();
            ViewBag.Categorias = categorias;

            return View();
        }

        public ActionResult Adiciona(CategoriaProduto categoria)
        {
            categoriaDAO.inserir(categoria);
            return RedirectToAction("Index", "Categoria");
        }
	}
}