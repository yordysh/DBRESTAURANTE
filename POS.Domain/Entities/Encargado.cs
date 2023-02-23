using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public class Encargado
    {
        public Encargado()
        {
            Categoria = new HashSet<Categoria>();
        }

        public int IdEncargado { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Edad { get; set; }
        public string? Dni { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Categoria> Categoria { get; set; }
    }
}
