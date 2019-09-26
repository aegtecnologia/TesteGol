using Gol.Teste.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gol.Teste.Domain.Contratos.Servicos
{
    public interface IAirplaneService
    {
        Task<IEnumerable<Airplane>> BuscarTodos();
        Task<Airplane> BuscarPorId(int id);
        Task Salvar(Airplane aviao);
        Task Excluir(int id);     
    }
}
