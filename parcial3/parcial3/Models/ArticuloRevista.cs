using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace parcial3.Models
{
    public class ArticuloRevista
    {
        public int ArticuloId { get; set; }
        public int RevistaId { get; set; }

        public virtual Articulo Articulo { get; set; }
        public virtual Revista Revista { get; set; }
    }
}