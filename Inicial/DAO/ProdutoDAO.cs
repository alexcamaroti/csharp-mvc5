﻿using Inicial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inicial.DAO
{
    public class ProdutoDAO
    {
        public IList<Produto> lista()
        {
            IList<Produto> produtos = new List<Produto>();
            CategoriaProduto cat1 = new CategoriaProduto();
            CategoriaProduto cat2 = new CategoriaProduto();

            Produto prd1 = new Produto();
            Produto prd2 = new Produto();
            Produto prd3 = new Produto();
            Produto prd4 = new Produto();


            cat1.Id = 1;
            cat1.Nome = "Comidas";
            cat1.Descricao = "Café da Manhã, Almoço e Jantar.";

            cat2.Id = 2;
            cat2.Nome = "Bebidas";
            cat2.Descricao = "Bebidas em geral.";

            prd1.Categoria = cat1;
            prd1.CategoriaID = cat1.Id;
            prd1.Id = 1;
            prd1.Nome = "Arroz";
            prd1.Preco = 3.20F;
            prd1.Quantidade = 1080;

            prd2.Categoria = cat1;
            prd2.CategoriaID = cat1.Id;
            prd2.Id = 2;
            prd2.Nome = "Feijão";
            prd2.Preco = 9.80F;
            prd2.Quantidade = 780;

            prd3.Categoria = cat2;
            prd3.CategoriaID = cat2.Id;
            prd3.Id = 3;
            prd3.Nome = "Guaraná Jesus";
            prd3.Preco = 2.20F;
            prd3.Quantidade = 720;

            prd4.Categoria = cat1;
            prd4.CategoriaID = cat1.Id;
            prd4.Id = 4;
            prd4.Nome = "Batata Palha";
            prd4.Preco = 5.30F;
            prd4.Quantidade = 330;

            produtos.Add(prd1);
            produtos.Add(prd2);
            produtos.Add(prd3);
            produtos.Add(prd4);

            return produtos;
        }
    }
}