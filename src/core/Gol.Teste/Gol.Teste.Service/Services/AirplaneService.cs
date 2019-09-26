using Gol.Teste.Domain.Contratos.Repositorios;
using Gol.Teste.Domain.Contratos.Servicos;
using Gol.Teste.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Gol.Teste.Service.Services
{
    public class AirplaneService : IAirplaneService
    {

        private IAirplaneRepository _repository;

        public AirplaneService(IAirplaneRepository rep)
        {
            _repository = rep;
        }
       
        public async Task<Airplane> BuscarPorId(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<IEnumerable<Airplane>> BuscarTodos()
        {
            return await _repository.GetAll();
        }

        public async Task Excluir(int id)
        {
            await _repository.Delete(id);
        }

        public async Task Salvar(Airplane aviao)
        {
            if (aviao.Id == 0)
                await _repository.Create(aviao);
            else
                await _repository.Update(aviao);
        }
    }
}
