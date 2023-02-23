using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class Ingrediente
    {
        public Ingrediente()
        {
            Receta = new HashSet<Receta>();
        }

        public int IdIngrediente { get; set; }
        public string? Nombre { get; set; }
        public decimal? PrecioCompra { get; set; }
        public int? StockAlmacen { get; set; }

        public virtual ICollection<Receta> Receta { get; set; }
    }
}
