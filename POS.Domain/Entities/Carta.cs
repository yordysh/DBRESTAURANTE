using System;
using System.Collections.Generic;

namespace POS.Domain.Entities
{
    public class Carta
    {
        public Carta()
        {
            Restaurantes = new HashSet<Restaurante>();
        }

        public int IdCarta { get; set; }
        public string? Descripcion { get; set; }
        public int? IdRestaurante { get; set; }
        public int? IdPlato { get; set; }

        public virtual Plato? IdPlatoNavigation { get; set; }
        public virtual Restaurante? IdRestauranteNavigation { get; set; }
        public virtual ICollection<Restaurante> Restaurantes { get; set; }
    }
}
