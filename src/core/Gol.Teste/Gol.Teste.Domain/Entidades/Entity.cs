using Gol.Teste.Domain.Contratos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gol.Teste.Domain.Entidades
{
    public class Entity:IEntity
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
