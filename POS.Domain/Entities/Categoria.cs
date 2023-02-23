using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public  class Categoria
    {
        public Categoria()
        {
            Platos = new HashSet<Plato>();
        }

        public int IdCategoria { get; set; }
        public string? Descripcion { get; set; }
        public int? IdEncargado { get; set; }

        public virtual Encargado? IdEncargadoNavigation { get; set; }
        public virtual ICollection<Plato> Platos { get; set; }
    }
}
