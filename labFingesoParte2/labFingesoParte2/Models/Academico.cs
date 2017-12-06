using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace labFingesoParte2.Models
{
    public class Academico : Usuario
    {
        // ATRIBUTOS
        private string              gradoAcademico;
        private string              departamento;
        private int                 cantidadActividades;
        private int                 estadoEvaluacion;
        private ConvenioDeDesempeño convenio;
        private List<ActividadAcademica> actividades = new List<ActividadAcademica>();

        // MÉTODOS

        // get
        public string getGradoAcademico()
        {
            return this.gradoAcademico;
        }
        public string getDepartamento()
        {
            return this.departamento;
        }
        public int getCantidadActividades()
        {
            return this.cantidadActividades;
        }
        public int getEstadoEvaluacion()
        {
            return this.estadoEvaluacion;
        }
        public ConvenioDeDesempeño getConvenio()
        {
            return this.convenio;
        }

        public List<ActividadAcademica> getActividades()
        {
            return this.actividades;
        }

        // set
        public void setGradoAcademico(string gradoAcademico)
        {
            this.gradoAcademico = gradoAcademico;
        }
        public void setDepartamento(string departamento)
        {
            this.departamento = departamento;
        }
        public void setCantidadActividades(int cantidadActividades)
        {
            this.cantidadActividades = cantidadActividades;
        }
        public void setEstadoEvaluacion(int estadoEvaluacion)
        {
            this.estadoEvaluacion = estadoEvaluacion;
        }
        public void setConvenio(ConvenioDeDesempeño convenio)
        {
            this.convenio = convenio;
        }
        // métodos
        public int asignarConvenio()
        {
            return 0;
        }
        public bool asignarActividad(string actividad)
        public void agregarActividad(ActividadAcademica actividad)
        {
            bool confirmacion;
            try
            {
                StreamWriter archivo = File.AppendText("BDActividades.txt");
                archivo.WriteLine(nombre + ";" + departamento + ";"+ gradoAcademico+ ";"+ RUT+ ";"+ actividad);
                archivo.Close();
                confirmacion = true;
            }
            catch
            {
                confirmacion = false;
            }
            return confirmacion;
            this.actividades.Add(actividad);
        }
        public void crearInforme()
        {
        }
        public void borrarInforme()
        {
        }
        public void creaListaDeActividades()
        {
        }
        public void subirArchivo()
        {
        }
    }
}