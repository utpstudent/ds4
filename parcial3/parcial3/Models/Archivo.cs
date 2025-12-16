using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace parcial3.Models
{
    public class Archivo
    {
        [Key]
        public int ArchivoID { get; set; }

        [Required]
        [Display(Name = "Nombre del archivo")]
        public string NombreArchivo { get; set; }

        [Required]
        public string Ruta { get; set; }

        public int ArticuloID { get; set; }

        [Display(Name = "Fecha de subida")]
        [DataType(DataType.DateTime)]
        public DateTime FechaSubida { get; set; }

        [ForeignKey("ArticuloID")]
        public virtual Articulo Articulo { get; set; }
    }
}