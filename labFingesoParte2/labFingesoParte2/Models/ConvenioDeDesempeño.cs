using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using System.IO;
namespace labFingesoParte2.Models
{
    public class ConvenioDeDesempeño
    {
        // ATRIBUTOS
        private int         año;
        private float       calificacion;
        private float       precalificacion;
        private int         estado;
        private float       horasPromedioSemanalesPrometidas;
        private float       horasPromedioSemanalesRealizadas;
        private float       horasPromedioAnualesPrometidas;
        private float       horasPromedioAnualesRealizadas;
        private List<ItemAcademico>   items = new List<ItemAcademico>();
        // MÉTODOS
        // get
        public int getAño()
        {
            return this.año;
        }
        public float getCalificacion()
        {
            return this.calificacion;
        }
        public float getPrecalificacion()
        {
            return this.precalificacion;
        }
        public int getEstado()
        {
            return this.estado;
        }
        public float getHorasPromedioSemanalesPrometidas()
        {
            return this.horasPromedioSemanalesPrometidas;
        }
        public float getHorasPromedioSemanalesRealizadas()
        {
            return this.horasPromedioSemanalesRealizadas;
        }
        public float getHorasPromedioAnualesPrometidas()
        {
            return this.horasPromedioAnualesPrometidas;
        }
        public float getHorasPromedioAnualesRealizadas()
        {
            return this.horasPromedioAnualesRealizadas;
        }

        public List<ItemAcademico> getItems()
        {
            return this.items;
        }

        // set
        public void setAño(int año)
        {
            this.año = año;
        }
        public void setCalificacion(float calificacion)
        {
            this.calificacion = calificacion;
        }
        public void setPrecalificacion(float precalificacion)
        {
            this.precalificacion = precalificacion;
        }
        public void setEstado(int estado)
        {
            this.estado = estado;
        }
        public void setHorasPromedioSemanalesPrometidas(float horasPromedioSemanalesPrometidas)
        {
            this.horasPromedioSemanalesPrometidas = horasPromedioSemanalesPrometidas;
        }
        public void setHorasPromedioSemanalesRealizadas(float horasPromedioSemanalesRealizadas)
        {
            this.horasPromedioSemanalesRealizadas = horasPromedioSemanalesRealizadas;
        }
        public void setHorasPromedioAnualesPrometidas(float horasPromedioAnualesPrometidas)
        {
            this.horasPromedioAnualesPrometidas = horasPromedioAnualesPrometidas;
        }
        public void setHorasPromedioAnualesRealizadas(float horasPromedioAnualesRealizadas)
        {
            this.horasPromedioAnualesRealizadas = horasPromedioAnualesRealizadas;
        }
        
        // métodos
        public float calcularHorasSemanales()
        {
            return 0;
        }
        public float calcularHorasAnuales()
        {
            return 0;
        }
        public float compararHoras()
        {
            return 0;
        }
        public bool generarRegistro(string academico)
        {
            bool confirmacion;
            try
            {
                StreamWriter archivo = File.AppendText("BDConvenio.txt");
                archivo.WriteLine(academico + ";" + año + ";" + calificacion + ";" + precalificacion + ";" + estado + ";" + horasPromedioSemanalesPrometidas + ";" + horasPromedioSemanalesRealizadas + ";" + horasPromedioAnualesPrometidas + ";" + horasPromedioAnualesRealizadas);
                confirmacion = true;
            }
            catch
            {
                confirmacion = false;
            }
            return confirmacion;
        }
        public bool borrarHorasSemanales()
        {
            return true;
        }
        public bool borrarHorasAnuales()
        {
            return true;
        }
        public void agregarItem(ItemAcademico item)
        {
            this.items.Add(item);
        }
    }
}