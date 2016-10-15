using Inicial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inicial.DAO
{
    public class CategoriaDAO
    {
        private static IList<CategoriaProduto> categorias = new List<CategoriaProduto>();

        public IList<CategoriaProduto> lista()
        {
            gerarDadosSimulacao();
            return categorias;
        }

        private static void gerarDadosSimulacao()
        {
            if (categorias.Count == 0)
            {
                CategoriaProduto cat1 = new CategoriaProduto();
                CategoriaProduto cat2 = new CategoriaProduto();
                CategoriaProduto cat3 = new CategoriaProduto();

                cat1.Id = 1;
                cat1.Nome = "Comidas";
                cat1.Descricao = "Café da Manhã, Almoço e Jantar.";

                cat2.Id = 2;
                cat2.Nome = "Bebidas";
                cat2.Descricao = "Bebidas em geral.";

                cat3.Id = 3;
                cat3.Nome = "Informática";
                cat3.Descricao = "O melhor material tecnologico voce encontra aqui.";

                categorias.Add(cat1);
                categorias.Add(cat2);
                categorias.Add(cat3);

            }
        }

        public void inserir(CategoriaProduto categoria)
        {
            categorias.Add(categoria);
        }

        public CategoriaProduto buscarPorID(int? id)
        {
            return categorias.Where(c => c.Id.Equals(id)).Single();
        }
    }
}