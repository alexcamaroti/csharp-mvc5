using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inicial.Models
{
    public class CategoriaProduto
    {

        private int id;
        private String nome;
        private String descricao;

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

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}