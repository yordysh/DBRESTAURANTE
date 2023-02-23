using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts
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

        public virtual DbSet<Carta> Cartas { get; set; } = null!;
        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; } = null!;
        public virtual DbSet<Encargado> Encargados { get; set; } = null!;
        public virtual DbSet<Ingrediente> Ingredientes { get; set; } = null!;
        public virtual DbSet<Medida> Medidas { get; set; } = null!;
        public virtual DbSet<NivelDeDificultad> NivelDeDificultads { get; set; } = null!;
        public virtual DbSet<PedidoVenta> PedidoVentas { get; set; } = null!;
        public virtual DbSet<Plato> Platos { get; set; } = null!;
        public virtual DbSet<Receta> Recetas { get; set; } = null!;
        public virtual DbSet<Restaurante> Restaurantes { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relation:Collection", "Modern_Spanish_CI_AS");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
