using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace labFingesoParte2.Models
{
    public class Academico
    {
        // ATRIBUTOS
        [Required]
        [Display(Name = "Nombre de usuario:")]
        public string nombreUsuario;
        //private string contraseña;

        [Required]
        [Display(Name = "Nombre:")]
        public string nombre;

        [Required]
        [Display(Name = "RUT:")]
        public string RUT;
        public string              gradoAcademico;
        public string              departamento;
        public int                 cantidadActividades;
        public int                 estadoEvaluacion;
        public ConvenioDeDesempeño convenio;
        public List<ActividadAcademica> actividades = new List<ActividadAcademica>();

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
        public bool registrarUsuario(string actividad)
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
        public void agregarActividad(ActividadAcademica actividad)
        {
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