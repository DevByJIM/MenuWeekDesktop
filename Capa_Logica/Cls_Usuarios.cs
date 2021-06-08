using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Cls_Usuarios
    {
        List<Usuario> lstUsuarios = null;

        /// <summary>
        /// Clase que nos devuelve un listado con los usuarios.
        /// </summary>
        public static DataTable listadoUsuarios()
        {
            return MenuWeek.ConsultaSQL("SELECT * FROM tb_Usuarios");
        }
    }
}
