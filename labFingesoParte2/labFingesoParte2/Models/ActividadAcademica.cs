using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace labFingesoParte2.Models
{
    public class ActividadAcademica
    {
        [Required]
        [Display (Name ="Nombre de la actividad:")]
        public string   titulo { get; set; }

        [Required]
        [Display(Name = "Fecha de inicio:")]
        public string   fechaInicio { get; set; }

        [Required]
        [Display(Name = "Fecha de término:")]
        public String   fechaTermino { get; set; }

        [Required]
        [Display(Name = "Descripción:")]
        public string   descripcion { get; set; }

        [Required]
        [Display(Name = "Horas de realización:")]
        public float    horasDuracion { get; set; }
    }
}