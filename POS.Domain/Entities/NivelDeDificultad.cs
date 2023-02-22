using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class NivelDeDificultad
    {
        public NivelDeDificultad()
        {
            Platos = new HashSet<Plato>();
        }

        public int IdNdeDificultad { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Plato> Platos { get; set; }
    }
}
