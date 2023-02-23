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
    public class DetallePedidoConfiguration : IEntityTypeConfiguration<DetallePedido>
    {
        public void Configure(EntityTypeBuilder<DetallePedido> builder)
        {
            builder.HasKey(e => e.IdDetallePedido)
                   .HasName("PK__DetalleP__48AFFD95FBCC837F");

            builder.ToTable("DetallePedido");

            builder.Property(e => e.SubTotalPrecio).HasColumnType("decimal(5, 2)");

            builder.HasOne(d => d.IdPlatoNavigation)
                .WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.IdPlato)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DetallePedido_Plato");
        }
    }
}
