using Gol.Teste.Domain.Contratos.Entidades;
using Gol.Teste.Domain.Contratos.Repositorios;
using Gol.Teste.Infra.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gol.Teste.Infra.Repositorios
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity>
      where TEntity : class, IEntity
    {
        protected readonly Contexto _dbContext;

        
        protected GenericRepository(Contexto dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public virtual async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
        public virtual async Task<TEntity> Get(int id)
        {
            return await _dbContext.Set<TEntity>()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbContext.Set<TEntity>()
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual async Task Create(TEntity entity)
        {
            entity.DataCadastro = DateTime.Now;
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public virtual async Task Update(TEntity entity)
        {
            var existing = await Get(entity.Id);

            if (existing != null)
            {
                entity.DataAlteracao = DateTime.Now;
                entity.DataCadastro = existing.DataCadastro;

                _dbContext.Entry(existing).CurrentValues.SetValues(entity);
            }
        }

        public virtual async Task Delete(int id)
        {
            var entity = await Get(id);
            if (entity != null) _dbContext.Set<TEntity>().Remove(entity);
        }

        public virtual async Task<int> Count()
        {
            return await _dbContext.Set<TEntity>().CountAsync();
        }

       
    }
}


