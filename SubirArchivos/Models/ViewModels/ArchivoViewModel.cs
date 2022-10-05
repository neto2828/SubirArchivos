using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

 
namespace SubirArchivos.Models.ViewModels
{
    public class ArchivoViewModel
    {
        [Required]
        [DisplayName("Archivo 1")]
        public IFormFile? Archivo1 {get;set;}
        [Required]
        [DisplayName("Archivo 2")]
        public IFormFile? Archivo2 { get; set; }
        [Required]
        [DisplayName("Cadena")]
        public string? Cadena { get; set; }
    }
}
