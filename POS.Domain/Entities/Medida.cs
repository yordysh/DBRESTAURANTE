using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class Medida
    {
        public Medida()
        {
            Receta = new HashSet<Receta>();
        }

        public int IdMedida { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Receta> Receta { get; set; }
    }
}
