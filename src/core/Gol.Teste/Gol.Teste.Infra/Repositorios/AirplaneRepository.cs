using Gol.Teste.Domain.Contratos.Repositorios;
using Gol.Teste.Domain.Entidades;
using Gol.Teste.Infra.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gol.Teste.Infra.Repositorios
{
    public class AirplaneRepository : GenericRepository<Airplane>, IAirplaneRepository
    {
        public AirplaneRepository(Contexto dbContext)
           : base(dbContext)
        { }

    }
}
