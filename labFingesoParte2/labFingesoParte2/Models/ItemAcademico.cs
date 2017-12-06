using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labFingesoParte2.Models
{
    public class ItemAcademico
    {
        public string   nombre { get; set; }
        public float    horasSemanalesComprometidas { get; set; }
        public float    horasSemanalesRealizadas { get; set; }
        public float    horasAnualesComprometidas { get; set; }
        public float    horasAnualesRealizadas1{ get; set; }
        public string   observacion { get; set; }
    }
}