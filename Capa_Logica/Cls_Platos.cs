using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Logica
{
    public class Cls_Platos
    {
        List<Plato> lstPlato = null;

        /// <summary>
        /// Clase que nos devuelve un listado con los ingredientes.
        /// </summary>
        public static DataTable listadoPlatos()
        {
            return MenuWeek.ConsultaSQL("SELECT * FROM tb_Platos");
        }
    }
}
