using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Cls_Ingredientes
    {
        List<Ingrediente> lstIngrediente = null;

        /// <summary>
        /// Clase que nos devuelve un listado con los ingredientes.
        /// </summary>
        public static DataTable listadoIngredientes()
        {
            return MenuWeek.ConsultaSQL("SELECT * FROM tb_Ingredientes");
        }
    }
}
