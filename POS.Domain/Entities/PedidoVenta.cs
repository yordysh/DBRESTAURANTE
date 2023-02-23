using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class PedidoVenta
    {
        public PedidoVenta()
        {
            Restaurantes = new HashSet<Restaurante>();
        }

        public int IdPedidoVenta { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? MontoFinal { get; set; }
        public int? IdDetallePedido { get; set; }

        public virtual DetallePedido? IdDetallePedidoNavigation { get; set; }
        public virtual ICollection<Restaurante> Restaurantes { get; set; }
    }
}
