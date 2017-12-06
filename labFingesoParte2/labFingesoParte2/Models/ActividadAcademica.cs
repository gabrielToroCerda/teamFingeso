using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labFingesoParte2.Models
{
    public class ActividadAcademica
    {
        public string   titulo { get; set; }
        public string   fechaInicio { get; set; }
        public string   fechaTermino { get; set; }
        public string   tipoActividad { get; set; }
        public string   descripcion { get; set; }
        public float    horasDuracion { get; set; }
    }
}