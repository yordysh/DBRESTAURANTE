using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public partial class Encargado
    {
        public Encargado()
        {
            Categoria = new HashSet<Categorium>();
        }

        public int IdEncargado { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Edad { get; set; }
        public string? Dni { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Categorium> Categoria { get; set; }
    }
}
