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
        ProdutoDAO produtoDAO = new ProdutoDAO();
        CategoriaDAO categoriaDAO = new CategoriaDAO();

        [Route("produtos",Name="ListaProdutos")]
        public ActionResult Index()
        {
            //Buscando os produtos de simulacao.
            IList<Produto> produtos = produtoDAO.lista();
            //Setando a lista de produtos para ser acessada na view.
            return View(produtos);
        }

        public ActionResult Form()
        {
            ViewBag.Categorias = categoriaDAO.lista();
            ViewBag.Produto = new Produto();
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            int codigoCategoriaInformatica = 3;
            if (produto.CategoriaID.Equals(codigoCategoriaInformatica) && produto.Preco < 100)
            {
                ModelState.AddModelError("produto.PrecoInformaticaInvalido", "O produtos de informatica precisam custar 100 reais ou mais");
            }

            if (ModelState.IsValid)
            {
            //Realizando a insercao do produto informado na view
            produtoDAO.inserir(produto);
            return RedirectToAction("Index", "Produto");
            }
            else
            {
                ViewBag.Categorias = categoriaDAO.lista();
                ViewBag.Produto = produto;
                return View("Form");
            }
        }

        [Route("produtos/{id}", Name="VisualizaProduto")]
        public ActionResult Visualiza(int id)
        {
            Produto prd = produtoDAO.buscarPorID(id);
            ViewBag.Produto = prd;
            return View();
        }

        public ActionResult decrementaQtd(int id)
        {
            Produto produto = produtoDAO.buscarPorID(id);
            produto.Quantidade--;
            produtoDAO.alterar(produto);

            return RedirectToAction("Index");

        }
	}
}