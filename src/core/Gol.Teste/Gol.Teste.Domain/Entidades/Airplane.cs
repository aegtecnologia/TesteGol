using System;
using System.Collections.Generic;
using System.Text;

namespace Gol.Teste.Domain.Entidades
{
    public class Airplane : Entity
    {
        public string Codigo { get; set; }
        public string Modelo { get; set; }
        public int Passageiros { get; set; }
    }
}
