using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace labFingesoParte2.Models
{
    public class Director : Academico
    {
        // ATRIBUTOS
        private string fechaInicio;
        private string fechaTermino;

        // MÉTODOS

        // set
        public void setFechaInicio(string fechaInicio)
        {
            this.fechaInicio = fechaInicio;
        }
        public void setFechaTermino(string fechaTermino)
        {
            this.fechaTermino = fechaTermino;
        }

        // get
        public string getFechaInicio()
        {
            return this.fechaInicio;
        }
        public string getFechaTermino()
        {
            return this.fechaTermino;
        }

        // métodos
        public bool crearUsuario(string nombreUsuario, string contraseña, string nombre, string RUT)
        {
            bool confirmacion;
            try
            {
                StreamWriter archivo = File.AppendText("BDUsuarios.txt");
                archivo.WriteLine(nombreUsuario + ";" + contraseña + ";" + nombre + ";" + RUT);
                confirmacion = true;
            }
            catch 
            {
                confirmacion = false;
            }
            return confirmacion;
        }
        public bool borrarUsuario()
        {
            return true;
        }
        public bool actualizarUsuario()
        {
            return true;
        }
        public bool examinarConvenio()
        {
            return true;
        }
        public void observacionesConvenio()
        {
        }
    }
}