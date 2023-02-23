using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class Restaurante
    {
        public Restaurante()
        {
            Carta = new HashSet<Carta>();
        }

        public int IdRestaurante { get; set; }
        public string? Nombre { get; set; }
        public string? Ubicacion { get; set; }
        public int? IdCarta { get; set; }
        public int? IdPedido { get; set; }

        public virtual Carta? IdCartaNavigation { get; set; }
        public virtual PedidoVenta? IdPedidoNavigation { get; set; }
        public virtual ICollection<Carta> Carta { get; set; }
    }
}
