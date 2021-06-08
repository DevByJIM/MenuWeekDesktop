using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    class Usuario
    {
        private String mail;
        private String nombre;
        private String apellido;
        private String password;
        private String icono;
        private DateTime altaFecha;
        private int grupo;
        private DateTime fechor;

        public string Mail { get => mail; set => mail = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Password { get => password; set => password = value; }
        public string Icono { get => icono; set => icono = value; }
        public DateTime AltaFecha { get => altaFecha; set => altaFecha = value; }
        public int Grupo { get => grupo; set => grupo = value; }
        public DateTime Fechor { get => fechor; set => fechor = value; }
    }
}
