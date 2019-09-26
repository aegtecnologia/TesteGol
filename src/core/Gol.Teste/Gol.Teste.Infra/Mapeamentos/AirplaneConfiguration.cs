using Gol.Teste.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gol.Teste.Infra.Mapeamentos
{
    internal sealed class AirplaneConfiguration : EntityConfiguration<Airplane>
    {
        #region Overriden Methods

        public override void Configure(EntityTypeBuilder<Airplane> builder)
        {
            builder.ToTable("Airplane");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseSqlServerIdentityColumn();
            builder.Property(c => c.Codigo).HasMaxLength(10).IsRequired();
            builder.Property(c => c.Modelo).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Passageiros).IsRequired();
            
            builder.Property(c => c.DataCadastro).IsRequired();
            builder.Property(c => c.DataAlteracao);
        }

        #endregion
    }
}