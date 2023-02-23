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
    public class NivelDeDificultadConfiguration : IEntityTypeConfiguration<NivelDeDificultad>
    {
        public void Configure(EntityTypeBuilder<NivelDeDificultad> builder)
        {
            builder.HasKey(e => e.IdNdeDificultad)
                   .HasName("PK__NivelDeD__863F4595B57D29FC");

            builder.ToTable("NivelDeDificultad");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
}
