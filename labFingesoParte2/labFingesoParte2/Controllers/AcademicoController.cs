using labFingesoParte2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labFingesoParte2.Controllers
{
    public class AcademicoController : Controller
    {
        // GET: Academico
        public ActionResult InicioAcademico()
        {
            return View();
        }

        // GET: Academico/Convenio
        public ActionResult Convenio()
        {
            ConvenioDeDesempeño convenio = new ConvenioDeDesempeño();
            convenio.setHorasPromedioSemanalesPrometidas(14);
            convenio.setHorasPromedioAnualesPrometidas(convenio.getHorasPromedioSemanalesPrometidas() * 47);
            return View(convenio);
        }

        // GET: Academico/Actividades
        public ActionResult Actividades()
        {
            Academico academico = new Academico();
            ActividadAcademica act = new ActividadAcademica();
            act.titulo = "Feria de prototipos";
            act.fechaInicio = "21-11-2017";
            act.fechaTermino = "23-11-2017";
            act.descripcion = "Visité con los alumnos de mi sección la feria de prototipos informáticos realizada en estación Mapocho.";
            act.horasDuracion = 5;
            for(int i = 0; i < 5; i++)
            {
                academico.agregarActividad(act);
            }
            return View(academico);
        }

        // GET: Academico/FormularioActividad
        public ActionResult FormularioActividad()
        {
            return View();
        }

        /*
        // POST: Academico/RegistrarActividad
        [HttpPost]
        public ActionResult RegistrarActividad(RegistrarActividad)
        {
            return View();
        }*/

        // GET: Academico/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Academico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Academico/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Academico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Academico/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Academico/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Academico/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
