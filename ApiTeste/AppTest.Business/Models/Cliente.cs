using System;
using System.Collections.Generic;
using System.Text;

namespace AppTest.Business.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public bool Ativo { get; set; }
    }
}
