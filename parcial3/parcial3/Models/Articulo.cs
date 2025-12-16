using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace parcial3.Models
{

    public class Articulo
    {
        [Key]
        public int ArticuloID { get; set; }

        [Required(ErrorMessage = "El título es requerido")]
        [Display(Name = "Título del artículo")]
        [StringLength(300, ErrorMessage = "El título no puede exceder 300 caracteres")]
        public string Titulo { get; set; }

        [Display(Name = "Resumen")]
        [DataType(DataType.MultilineText)]
        public string Resumen { get; set; }

        [Required(ErrorMessage = "Los autores son requeridos")]
        [Display(Name = "Autores")]
        public string Autores { get; set; }

        [Display(Name = "Palabras clave")]
        public string PalabrasClave { get; set; }

        [Display(Name = "DOI")]
        public string DOI { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; } = "En revisión";

        [Display(Name = "Fecha de publicación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaPublicacion { get; set; }

        [Display(Name = "Fecha de registro")]
        [DataType(DataType.DateTime)]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        
        public int UsuarioID { get; set; }

        

        
        [ForeignKey("UsuarioID")]
        public virtual Usuario Usuario { get; set; }

        
    }


}
