using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Proyecto.Web.Controllers
{
    public class EventosController
    {
        public List<Logica.Models.clsEventos> getEventosJsonController()
        {
            try
            {
                wsServicios.wsServicios obwsServicios = new wsServicios.wsServicios();
                string json = obwsServicios.getEventos_Json();

                List<Logica.Models.clsEventos> lstclsEventos = JsonConvert.DeserializeObject<List<Logica.Models.clsEventos>>(json);

                return lstclsEventos;
            }
            catch (Exception ex) { throw ex; }
        }

        public object getEventosXMLController()
        {
            try
            {
                wsServicios.wsServicios obwsServicios = new wsServicios.wsServicios();
                var lstclsEventos =  obwsServicios.getEventos_XML();

                return lstclsEventos;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}