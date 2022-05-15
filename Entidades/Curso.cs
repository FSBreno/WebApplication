using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entidades
{
    public class Curso
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public Curso(int ID, string Nome, bool Ativo)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Ativo = Ativo;
        }

    }
}
