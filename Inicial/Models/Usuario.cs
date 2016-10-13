using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inicial.Models
{
    public class Usuario
    {
        private int id;
        private String nome;
        private String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
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
    }
}