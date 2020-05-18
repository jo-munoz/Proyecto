using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.Logica.BL
{
    public class clsEventos
    {
        /// <summary>
        /// CREA UN EVENTO
        /// </summary>
        /// <param name="obclsEventos">MODELO DE EVENTOS</param>
        /// <returns></returns>
        public void createEventos(Models.clsEventos obclsEventos)
        {
            try
            {
                using (Entidades.bdGeneralEntities obDatos = new Entidades.bdGeneralEntities())
                {
                    obDatos.tbEventos.Add(new Entidades.tbEventos
                    {
                        evenNombre = obclsEventos.NOMBRE,
                        evenUbicacion = obclsEventos.UBICACION,
                        evenParticipantes = obclsEventos.PARTICIPANTES,
                        evenTodoDia = obclsEventos.TODO_DIA,
                        evenFecha = obclsEventos.FECHA,
                        recoCodigo = obclsEventos.RELACIONADO_CON.CODIGO,
                        evenDescripcion = obclsEventos.DESCRIPCION
                    });
                    obDatos.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// CONSULTA TODOS LOS EVENTOS
        /// </summary>
        /// <returns></returns>
        public List<Models.clsEventos> getEventos()
        {
            try
            {
                using (Entidades.bdGeneralEntities obDatos = new Entidades.bdGeneralEntities())
                {
                    List<Models.clsEventos> lstclsEventos = (from q in obDatos.tbEventos
                                                             join tbRC in obDatos.tbRelacionadoCon on q.recoCodigo equals tbRC.recoCodigo
                                                             select new Models.clsEventos
                                                             {
                                                                 CODIGO = q.evenCodigo,
                                                                 NOMBRE = q.evenNombre,
                                                                 UBICACION = q.evenUbicacion,
                                                                 PARTICIPANTES = q.evenParticipantes,
                                                                 TODO_DIA = q.evenTodoDia.Equals("S") ? "SI" : "NO",
                                                                 FECHA = q.evenFecha,
                                                                 RELACIONADO_CON = new Models.clsRelacionadoCon
                                                                 {
                                                                     CODIGO = tbRC.recoCodigo,
                                                                     DESCRIPCION = tbRC.recoDescripcion
                                                                 },
                                                                 DESCRIPCION = q.evenDescripcion,
                                                             }).ToList();

                    return lstclsEventos;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
