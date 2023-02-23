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
    public class RecetaConfiguration : IEntityTypeConfiguration<Receta>
    {
        public void Configure(EntityTypeBuilder<Receta> builder)
        {
            builder.HasKey(e => e.IdReceta)
                    .HasName("PK__Receta__2CEFF157E437AB4C");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasOne(d => d.IdIngredienteNavigation)
                .WithMany(p => p.Receta)
                .HasForeignKey(d => d.IdIngrediente)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Receta_Ingredientes");

            builder.HasOne(d => d.IdMedidaNavigation)
                .WithMany(p => p.Receta)
                .HasForeignKey(d => d.IdMedida)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Receta_Medida");
        }
    }
}
