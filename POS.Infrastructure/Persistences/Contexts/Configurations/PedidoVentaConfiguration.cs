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
    public class PedidoVentaConfiguration : IEntityTypeConfiguration<PedidoVenta>
    {
        public void Configure(EntityTypeBuilder<PedidoVenta> builder)
        {
            builder.HasKey(e => e.IdPedidoVenta)
                  .HasName("PK__PedidoVe__7ADC86E3CF1DA20E");

            builder.Property(e => e.Fecha).HasColumnType("datetime");

            builder.Property(e => e.MontoFinal).HasColumnType("decimal(5, 2)");

            builder.HasOne(d => d.IdDetallePedidoNavigation)
                .WithMany(p => p.PedidoVenta)
                .HasForeignKey(d => d.IdDetallePedido)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PedidoVenta_DetallePedido");
        }
    }
}
