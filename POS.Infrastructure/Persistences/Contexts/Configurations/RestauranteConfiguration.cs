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
    public class RestauranteConfiguration : IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.HasKey(e => e.IdRestaurante)
                   .HasName("PK__Restaura__29CE64FA38C5F95A");

            builder.ToTable("Restaurante");

            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.IdCartaNavigation)
                .WithMany(p => p.Restaurantes)
                .HasForeignKey(d => d.IdCarta)
                .HasConstraintName("FK_Restaurante_Carta");

            builder.HasOne(d => d.IdPedidoNavigation)
                .WithMany(p => p.Restaurantes)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK_Restaurante_PedidoVenta");

        }
    }
}
