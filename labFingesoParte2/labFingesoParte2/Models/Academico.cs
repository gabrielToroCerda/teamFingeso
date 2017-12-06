using System;
using System.Collections;
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
        private ArrayList           actividades;

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