using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labFingesoParte2.Models
{
    public class ItemAcademico
    {
        public string   nombre { get; set; }
        public float    horasSemanalesComprometidas1 { get; set; }
        public float    horasSemanalesRealizadas1 { get; set; }
        public float    horasAnualesComprometidas1 { get; set; }
        public float    horasAnualesRealizadas1 { get; set; }
        public float    horasSemanalesComprometidas2 { get; set; }
        public float    horasSemanalesRealizadas2 { get; set; }
        public float    horasAnualesComprometidas2 { get; set; }
        public float    horasAnualesRealizadas2 { get; set; }
        public string   observacion { get; set; }
    }
}