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
    public class CartaConfiguration : IEntityTypeConfiguration<Carta>
    {
        public void Configure(EntityTypeBuilder<Carta> builder)
        {
            builder.HasKey(e => e.IdCarta)
                   .HasName("PK__Carta__6C9FD04FFF1025B6");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasOne(d => d.IdPlatoNavigation)
                .WithMany(p => p.Carta)
                .HasForeignKey(d => d.IdPlato)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Carta_Plato");

            builder.HasOne(d => d.IdRestauranteNavigation)
                .WithMany(p => p.Carta)
                .HasForeignKey(d => d.IdRestaurante)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Carta_Restaurante");
        }
    }
}
