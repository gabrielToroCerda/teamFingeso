using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labFingesoParte2.Models
{
    public class ComisionDeDepartamento
    {
        // ATRIBUTOS
        private string      departamento;
        private int         año;
        private Director    director;

        // MÉTODOS

        // set
        public void setDepartamento(string departamento)
        {
            this.departamento = departamento;
        }
        public void setAño(int año)
        {
            this.año = año;
        }
        public void setDirector(Director director)
        {
            this.director = director;
        }

        // get 
        public string getDepartamento()
        {
            return this.departamento;
        }
        public int getAño()
        {
            return this.año;
        }
        public Director getDirector()
        {
            return director;
        }
        // métodos
        public bool pertenece()
        {
            return true;
        }
        public bool ponerPrecalificacion()
        {
            return true;
        }
        public void creaActaDePrecalificaion()
        {
        }
        public bool borrarActaDePrecalificacion()
        {
            return true;
        }
    }
}