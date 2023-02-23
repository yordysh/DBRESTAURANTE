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
    public class EncargadoConfiguration : IEntityTypeConfiguration<Encargado>
    {
        public void Configure(EntityTypeBuilder<Encargado> builder)
        {
            builder.HasKey(e => e.IdEncargado)
                       .HasName("PK__Encargad__EDCB90EA31A6A060");

            builder.ToTable("Encargado");

            builder.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Dni)
                .HasMaxLength(8)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
