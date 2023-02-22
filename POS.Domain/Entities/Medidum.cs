using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class Medidum
    {
        public Medidum()
        {
            Receta = new HashSet<Recetum>();
        }

        public int IdMedida { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Recetum> Receta { get; set; }
    }
}
