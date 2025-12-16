using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace parcial3.Models
{
    public class Revista
    {
        [Key]
        public int RevistaID { get; set; }  

        [Required(ErrorMessage = "El nombre de la revista es requerido")]
        [Display(Name = "Nombre de la revista")]
        public string Nombre { get; set; }

        [Display(Name = "ISSN")]
        public string ISSN { get; set; }

        [Display(Name = "Factor de Impacto")]
        [Range(0, 100, ErrorMessage = "El factor de impacto debe estar entre 0 y 100")]
        public decimal? FactorImpacto { get; set; }

        [Display(Name = "Cuartil")]
        [StringLength(2, ErrorMessage = "El cuartil debe ser Q1, Q2, Q3 o Q4")]
        public string Cuartil { get; set; }

        
        public int? ArticuloID { get; set; }  

        [ForeignKey("ArticuloID")]
        public virtual Articulo Articulo { get; set; }
    }
}