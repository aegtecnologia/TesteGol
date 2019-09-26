using Gol.Teste.Domain.Contratos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gol.Teste.Domain.Contratos.Repositorios
{
    public interface IGenericRepository<TEntity> 
        where TEntity : class, IEntity
    {
        Task<TEntity> Get(int id);
        
        Task<IEnumerable<TEntity>> GetAll();
        
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);

        Task SaveChanges();
        Task<int> Count();
    }
}


