using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class Plato
    {
        public Plato()
        {
            Carta = new HashSet<Cartum>();
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public int IdPlato { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public int? IdNdeDificultad { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdReceta { get; set; }

        public virtual Categorium? IdCategoriaNavigation { get; set; }
        public virtual NivelDeDificultad? IdNdeDificultadNavigation { get; set; }
        public virtual Recetum? IdRecetaNavigation { get; set; }
        public virtual ICollection<Cartum> Carta { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
