using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inicial.Models
{
    public class Produto
    {

        private int id;
        private String nome;
        private float preco;
        private CategoriaProduto categoria;
        private int? categoriaID;
        private int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public CategoriaProduto Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int? CategoriaID
        {
            get { return categoriaID; }
            set { categoriaID = value; }
        }



    }
}