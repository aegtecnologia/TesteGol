using Gol.Teste.Domain.Contratos.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gol.Teste.Infra.Mapeamentos
{
    internal abstract class EntityConfiguration<TEntity>
       where TEntity : class, IEntity
    {
        #region Public Abstract Methods

        public virtual IEnumerable<TEntity> Seed() => new TEntity[] { };
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);

        #endregion
    }
}
