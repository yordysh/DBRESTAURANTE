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
    public class PlatoConfiguration : IEntityTypeConfiguration<Plato>
    {
        public void Configure(EntityTypeBuilder<Plato> builder)
        {
            builder.HasKey(e => e.IdPlato)
                     .HasName("PK__Plato__4C943920E08EE6E7");

            builder.ToTable("Plato");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Precio).HasColumnType("decimal(5, 2)");

            builder.HasOne(d => d.IdCategoriaNavigation)
                .WithMany(p => p.Platos)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Plato_Categoria");

            builder.HasOne(d => d.IdNdeDificultadNavigation)
                .WithMany(p => p.Platos)
                .HasForeignKey(d => d.IdNdeDificultad)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Plato_NivelDeDificultad");

            builder.HasOne(d => d.IdRecetaNavigation)
                .WithMany(p => p.Platos)
                .HasForeignKey(d => d.IdReceta)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Plato_Receta");
        }
    }
}
