using Inicial.DAO;
using Inicial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inicial.Controllers
{
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            IList<Produto> produtos = dao.lista();
            ViewBag.Produtos = produtos;
            return View();
        }
	}
}