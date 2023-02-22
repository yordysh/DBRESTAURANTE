using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class Restaurante
    {
        public Restaurante()
        {
            Carta = new HashSet<Cartum>();
        }

        public int IdRestaurante { get; set; }
        public string? Nombre { get; set; }
        public string? Ubicacion { get; set; }
        public int? IdCarta { get; set; }
        public int? IdPedido { get; set; }

        public virtual Cartum? IdCartaNavigation { get; set; }
        public virtual PedidoVentum? IdPedidoNavigation { get; set; }
        public virtual ICollection<Cartum> Carta { get; set; }
    }
}
