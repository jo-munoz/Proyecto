using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Proyecto.Test
{
    [TestClass]
    public class clsEventos
    {
        [TestMethod]
        public void createEventosTest()
        {
            //ARRANGE
            wsServicios.wsServicios obwsServicios = new wsServicios.wsServicios();
            
            //ACTI
            Logica.Models.clsEventos obclsEventos = new Logica.Models.clsEventos
            {
                DESCRIPCION = "Inducción de pruebas unitarias",
                PARTICIPANTES = "Luisa",
                FECHA = "2020-05-17",
                NOMBRE = "Inducción",
                RELACIONADO_CON = new Logica.Models.clsRelacionadoCon
                {
                    CODIGO = 1
                },
                TODO_DIA = "S",
                UBICACION = "DKN"
            };
            
            string json = JsonConvert.SerializeObject(obclsEventos);

            //ASSERT
            obwsServicios.createEventosWS(json);
        }
    }
}
