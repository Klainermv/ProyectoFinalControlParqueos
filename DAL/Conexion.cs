using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Conexion
    {
        
       

        private SqlConnection con = new SqlConnection(@"Data Source=ARLETTEESPINAL\SQLEXPRESS;Initial Catalog=ControlParqueosDB;Integrated Security=True");
        /// <summary>
        /// para ejecutar todos los codigos
        /// </summary>
        /// <param name="Codigo"></param>
        /// <returns></returns>
        public  bool Ejecutar(string Codigo)
        {
            bool mensaje = false;
            SqlCommand cmd = new SqlCommand();

            try
            {
                con.Open(); // abrimos la conexion
                
                cmd.Connection = con; //asignamos la conexion
                cmd.CommandText = Codigo;     //asignamos el comando
                cmd.ExecuteNonQuery(); // ejecutamos el comando

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mensaje = true;
                con.Close(); //cerramos la conexion
                // MessageBox.Show("Conexion cerrada");

            }
            return mensaje;
        }

        /// <summary>
        /// para buscar datos en la base de datos
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public DataTable ObtenerDatos(string comando)
        {
            SqlDataAdapter adp;
            DataTable dt = new DataTable();
            try
            {
                con.Open(); // abrimos la conexion
                adp = new SqlDataAdapter(comando, con);

                adp.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close(); //cerramos la conexion

            }
            return dt;
        }

       
    
    }
      
    
}