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
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A101F720495");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasOne(d => d.IdEncargadoNavigation)
                .WithMany(p => p.Categoria)
                .HasForeignKey(d => d.IdEncargado)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Categoria_Encargado");
        }
    }
}
