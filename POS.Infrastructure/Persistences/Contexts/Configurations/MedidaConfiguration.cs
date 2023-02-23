using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class MedidaConfiguration : IEntityTypeConfiguration<Medida>
    {
        public void Configure(EntityTypeBuilder<Medida> builder)
        {
            builder.HasKey(e => e.IdMedida)
                   .HasName("PK__Medida__C326EE7DE375BDE6");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
