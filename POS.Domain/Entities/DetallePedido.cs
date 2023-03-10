using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class DetallePedido
    {
        public DetallePedido()
        {
            PedidoVenta = new HashSet<PedidoVenta>();
        }

        public int IdDetallePedido { get; set; }
        public int? IdPlato { get; set; }
        public decimal? SubTotalPrecio { get; set; }
        public int? Cantidad { get; set; }

        public virtual Plato? IdPlatoNavigation { get; set; }
        public virtual ICollection<PedidoVenta> PedidoVenta { get; set; }
    }
}
