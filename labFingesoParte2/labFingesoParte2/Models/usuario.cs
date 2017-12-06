using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace labFingesoParte2.Models
{
    public class Usuario
    {
        // ATRIBUTOS
        [Required]
        [Display(Name = "nombreUsuario")]
        private string nombreUsuario;
        //private string contraseña;

        [Required]
        [Display(Name = "nombre")]
        protected string nombre;

        [Required]
        [Display(Name = "rut")]
        protected string RUT;

        // MÉTODOS

        // gets
        public string getNombreUsuario()
        {
            return this.nombreUsuario;
        }
        /*
        public string getContraseña()
        {
            return this.contraseña;
        }*/
        public string getNombre()
        {
            return this.nombre;
        }
        public string getRUT()
        {
            return this.RUT;
        }

        // sets
        public void setNombreUsuario(string nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }
        /*
        public void setContraseña(string contraseña)
        {
            this.contraseña = contraseña;
        }*/
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setRUT(string RUT)
        {
            this.RUT = RUT;
        }

        // métodos
        public bool validarUsuario()
        {
            return true;
        }
        public void notificar()
        {
        }
    }
}