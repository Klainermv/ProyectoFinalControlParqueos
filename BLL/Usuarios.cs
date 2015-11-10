using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Usuarios
    {
        public int UsuarioId { set; get; }
        public string NombreUsuario { set; get; }
        public string Contrasenia { set; get; }
        public int Activo { set; get; }
        

        private Conexion conexion = new Conexion();

        public Usuarios()
        {
            UsuarioId = 0;
            NombreUsuario = "";
            Contrasenia = "";
            Activo = 0;
           
        }

        public bool Insertar()
        {
            return conexion.Ejecutar("Insert into Usuarios(NombreUsuario,Contrasenia,Activo)values('"+NombreUsuario+"','"+Contrasenia+"','"+Activo+"')");
        }

        public bool Modificar(int UsuarioId)
        {
            return conexion.Ejecutar("Update Usuarios set NombreUsuario='"+NombreUsuario+"', Contrasenia='"+Contrasenia+"',Activo='"+Activo+"' where UsuarioId="+UsuarioId);
        }

        public bool Eliminar()
        {
            return conexion.Ejecutar("Delete from Usuarios where UsuarioId="+UsuarioId);
        }

        public bool Buscar(int UsuarioId)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Usuarios where UsuarioId = " + UsuarioId);
            if (dt.Rows.Count > 0)
            {
                UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                Contrasenia = dt.Rows[0]["Contrasenia"].ToString();
                Activo = (int)dt.Rows[0]["Activo"];

                retorno = true;
            }
            else
            {
                retorno = false;
            } 
            return retorno;
        }

        public DataTable Listar(string Campos, string filtrowhere)
        {
            return conexion.ObtenerDatos("select " + Campos + " from Usuarios where " + filtrowhere);

        }

        public bool IniciarSesion(string NombreUsuario, string Contrasenia)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Usuarios where  NombreUsuario='" + NombreUsuario + "' and Contrasenia='" + Contrasenia + "'");
            if (dt.Rows.Count > 0)
            {
  
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
