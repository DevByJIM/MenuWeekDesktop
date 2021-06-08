using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Capa_Logica
{
    public class Cls_ListaCompra
    {
        List<ListaCompra> lstListaCompra = null;

        /// <summary>
        /// Clase que nos devuelve un listado con los ingredientes.
        /// </summary>
        public static DataTable listadoListaCompra()
        {
            List<Cls_Parametros> lst = new List<Cls_Parametros>();

            lst.Add(new Cls_Parametros("clave", "jim@gmail.com2021-06-07"));
            return MenuWeek.Listado("LISTADOELEMENTOSCOMPRA", lst);
        }
    }
}
