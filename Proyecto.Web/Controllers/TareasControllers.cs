using System;
using System.Collections.Generic;
using System.Data;

namespace Proyecto.Web.Controllers
{
    public class TareasControllers
    {
        /// <summary>
        /// OBTIENE REGISTROS ESTADO TAREAS
        /// </summary>
        /// <returns>DATA ESTADO TAREAS</returns>
        public DataSet getConsultarEstadoTareasController()
        {
            try
            {
                Logica.BL.clsEstadoTarea obclsEstadoTarea = new Logica.BL.clsEstadoTarea();
                return obclsEstadoTarea.getConsultarEstadoTareas();
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// OBTIENE REGISTROS PRIORIDAD
        /// </summary>
        /// <returns>DATA PRIORIDAD</returns>
        public DataSet getConsultarPrioridadController()
        {
            try
            {
                Logica.BL.clsPrioridad obclsPrioridad = new Logica.BL.clsPrioridad();
                return obclsPrioridad.getConsultarPrioridad();
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// CREA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas"></param>
        /// <returns>MENSAJE</returns>
        public string addTareasController(Logica.Models.clsTareas obclsTareas)
        {
            try
            {
                Logica.BL.clsTareas obclsTarea = new Logica.BL.clsTareas();
                return obclsTarea.addTareas(obclsTareas);
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// MODIFICA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREA</param>
        /// <returns></returns>
        public string updateTareasController(Logica.Models.clsTareas obclsTareas)
        {
            try
            {
                Logica.BL.clsTareas obclsTarea = new Logica.BL.clsTareas();
                return obclsTarea.updateTareas(obclsTareas);
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// ELIMINA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREA</param>
        /// <returns></returns>
        public string deleteTareasController(Logica.Models.clsTareas obclsTareas)
        {
            try
            {
                Logica.BL.clsTareas obclsTarea = new Logica.BL.clsTareas();
                return obclsTarea.deleteTareas(obclsTareas);
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// CONSULTA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas"></param>
        /// <returns></returns>
        public List<Logica.Models.clsTareas> getTareasController()
        {
            try
            {
                Logica.BL.clsTareas obclsTarea = new Logica.BL.clsTareas();
                return obclsTarea.getTareas();
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// CONSULTA TODAS LAS TAREAS
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREA</param>
        /// <returns></returns>
        public List<Logica.Models.clsTareas> getTareasController(Logica.Models.clsTareas obclsTareas)
        {
            try
            {
                Logica.BL.clsTareas obclsTarea = new Logica.BL.clsTareas();
                return obclsTarea.getTareas(obclsTareas);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}