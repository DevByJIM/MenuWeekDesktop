using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class MenuWeek
    {
        
        static MySqlConnection Conexion =
            new MySqlConnection("Data source =127.0.0.1;port=3306;username=root;database=menuweek_bd;");

        private static void abrir_Conexion() //METODO PARA ABRIR CONEXION
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
        }

        private static void Cerrar_Conexion() //METODO PARA CERRAR CONEXION
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }

        /// <summary>
        /// Método que ejecuta una Consulta SQL devolviendo un DataTable con un listado.
        /// </summary>
        /// <param name="Consulta SQL"></param>
        public static DataTable ConsultaSQL(String miSQL)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da;

            try
            {
                abrir_Conexion();
                da = new MySqlDataAdapter(miSQL, Conexion);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR BUSCANDO DATOS POR SQL. \n" + ex.Message);
            }
            finally
            {
                Cerrar_Conexion();
            }
        }

        /// <summary>
        /// Método que ejecuta una Consulta SQL y devuelve True si se ha realizado sin errores.
        /// </summary>
        /// <param name="Consulta SQL"></param>
        public static Boolean EjecutarOrdenSQL(String miSQL)
        {
            MySqlCommand cmd;

            try
            {
                abrir_Conexion();
                cmd = new MySqlCommand(miSQL, Conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR EJECUTANDO UN SCRIPT SQL. \n" + ex.Message);
            }
            finally
            {
                Cerrar_Conexion();
            }

        }

        /// <summary>
        /// Método que ejecuta un Procedimiento Almacenado y devuelve un DataTable.
        /// </summary>
        /// <param name="Listado desde SP"></param>
        public static DataTable Listado(String NombreSp, List<Cls_Parametros> lst)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da;

            try
            {
                abrir_Conexion();
                da = new MySqlDataAdapter(NombreSp, Conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Cerrar_Conexion();
            }
            return dt;
        }

        /// <summary>
        /// Método que ejecuta un Procedimiento Almacenado y no devuelve nada.
        /// </summary>
        /// <param name="Ejecutar un SP"></param>
        public static void Ejecutar_SP(String NombreSP, List<Cls_Parametros> lst)
        {
            MySqlCommand cmd;

            try
            {
                abrir_Conexion();
                cmd = new MySqlCommand(NombreSP, Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                    cmd.ExecuteNonQuery();

                    //RECUPERAR LOS PARAMETROS DE SALIDA
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Cerrar_Conexion();
            }

        }

    }
}
