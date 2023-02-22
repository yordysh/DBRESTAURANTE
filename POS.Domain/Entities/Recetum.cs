using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class Recetum
    {
        public Recetum()
        {
            Platos = new HashSet<Plato>();
        }

        public int IdReceta { get; set; }
        public string? Descripcion { get; set; }
        public int? Cantidad { get; set; }
        public int? IdIngrediente { get; set; }
        public int? IdMedida { get; set; }

        public virtual Ingrediente? IdIngredienteNavigation { get; set; }
        public virtual Medidum? IdMedidaNavigation { get; set; }
        public virtual ICollection<Plato> Platos { get; set; }
    }
}
