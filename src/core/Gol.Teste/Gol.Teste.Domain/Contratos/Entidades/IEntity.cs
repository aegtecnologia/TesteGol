using System;
using System.Collections.Generic;
using System.Text;

namespace Gol.Teste.Domain.Contratos.Entidades
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime DataCadastro { get; set; }
        DateTime? DataAlteracao { get; set; }
    }
}
