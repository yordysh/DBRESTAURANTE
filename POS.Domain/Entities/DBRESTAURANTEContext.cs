using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace POS.Domain.Entities
{
    public partial class DBRESTAURANTEContext : DbContext
    {
        public DBRESTAURANTEContext()
        {
        }

        public DBRESTAURANTEContext(DbContextOptions<DBRESTAURANTEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cartum> Carta { get; set; } = null!;
        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; } = null!;
        public virtual DbSet<Encargado> Encargados { get; set; } = null!;
        public virtual DbSet<Ingrediente> Ingredientes { get; set; } = null!;
        public virtual DbSet<Medidum> Medida { get; set; } = null!;
        public virtual DbSet<NivelDeDificultad> NivelDeDificultads { get; set; } = null!;
        public virtual DbSet<PedidoVentum> PedidoVenta { get; set; } = null!;
        public virtual DbSet<Plato> Platos { get; set; } = null!;
        public virtual DbSet<Recetum> Receta { get; set; } = null!;
        public virtual DbSet<Restaurante> Restaurantes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=YORDY;Database=DBRESTAURANTE;User Id=sa;Password=70836940;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cartum>(entity =>
            {
                entity.HasKey(e => e.IdCarta)
                    .HasName("PK__Carta__6C9FD04FFF1025B6");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPlatoNavigation)
                    .WithMany(p => p.Carta)
                    .HasForeignKey(d => d.IdPlato)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Carta_Plato");

                entity.HasOne(d => d.IdRestauranteNavigation)
                    .WithMany(p => p.Carta)
                    .HasForeignKey(d => d.IdRestaurante)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Carta_Restaurante");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A101F720495");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEncargadoNavigation)
                    .WithMany(p => p.Categoria)
                    .HasForeignKey(d => d.IdEncargado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Categoria_Encargado");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasKey(e => e.IdDetallePedido)
                    .HasName("PK__DetalleP__48AFFD95FBCC837F");

                entity.ToTable("DetallePedido");

                entity.Property(e => e.SubTotalPrecio).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdPlatoNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.IdPlato)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DetallePedido_Plato");
            });

            modelBuilder.Entity<Encargado>(entity =>
            {
                entity.HasKey(e => e.IdEncargado)
                    .HasName("PK__Encargad__EDCB90EA31A6A060");

                entity.ToTable("Encargado");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ingrediente>(entity =>
            {
                entity.HasKey(e => e.IdIngrediente)
                    .HasName("PK__Ingredie__3DA4DD6012042D7D");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioCompra).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<Medidum>(entity =>
            {
                entity.HasKey(e => e.IdMedida)
                    .HasName("PK__Medida__C326EE7DE375BDE6");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NivelDeDificultad>(entity =>
            {
                entity.HasKey(e => e.IdNdeDificultad)
                    .HasName("PK__NivelDeD__863F4595B57D29FC");

                entity.ToTable("NivelDeDificultad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PedidoVentum>(entity =>
            {
                entity.HasKey(e => e.IdPedidoVenta)
                    .HasName("PK__PedidoVe__7ADC86E3CF1DA20E");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.MontoFinal).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdDetallePedidoNavigation)
                    .WithMany(p => p.PedidoVenta)
                    .HasForeignKey(d => d.IdDetallePedido)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PedidoVenta_DetallePedido");
            });

            modelBuilder.Entity<Plato>(entity =>
            {
                entity.HasKey(e => e.IdPlato)
                    .HasName("PK__Plato__4C943920E08EE6E7");

                entity.ToTable("Plato");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Platos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Plato_Categoria");

                entity.HasOne(d => d.IdNdeDificultadNavigation)
                    .WithMany(p => p.Platos)
                    .HasForeignKey(d => d.IdNdeDificultad)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Plato_NivelDeDificultad");

                entity.HasOne(d => d.IdRecetaNavigation)
                    .WithMany(p => p.Platos)
                    .HasForeignKey(d => d.IdReceta)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Plato_Receta");
            });

            modelBuilder.Entity<Recetum>(entity =>
            {
                entity.HasKey(e => e.IdReceta)
                    .HasName("PK__Receta__2CEFF157E437AB4C");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdIngredienteNavigation)
                    .WithMany(p => p.Receta)
                    .HasForeignKey(d => d.IdIngrediente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Receta_Ingredientes");

                entity.HasOne(d => d.IdMedidaNavigation)
                    .WithMany(p => p.Receta)
                    .HasForeignKey(d => d.IdMedida)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Receta_Medida");
            });

            modelBuilder.Entity<Restaurante>(entity =>
            {
                entity.HasKey(e => e.IdRestaurante)
                    .HasName("PK__Restaura__29CE64FA38C5F95A");

                entity.ToTable("Restaurante");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCartaNavigation)
                    .WithMany(p => p.Restaurantes)
                    .HasForeignKey(d => d.IdCarta)
                    .HasConstraintName("FK_Restaurante_Carta");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Restaurantes)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_Restaurante_PedidoVenta");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
