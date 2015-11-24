using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Usuarios:ClaseMaestra
    {
        public int UsuarioId { set; get; }
        public string NombreUsuario { set; get; }
        public string Contrasenia { set; get; }
        public bool Activo { set; get; }
        

        private Conexion conexion = new Conexion();

        public Usuarios()
        {
            UsuarioId = 0;
            NombreUsuario = "";
            Contrasenia = "";
            Activo = false;
           
        }

        public override bool Insertar()
        {
            return conexion.Ejecutar("Insert into Usuarios(NombreUsuario,Contrasenia,Activo)values('"+NombreUsuario+"','"+Contrasenia+"','"+Activo+"')");
        }

        public override bool Modificar(int UsuarioId)
        {
            return conexion.Ejecutar("Update Usuarios set NombreUsuario='"+NombreUsuario+"', Contrasenia='"+Contrasenia+"',Activo='"+Activo+"' where UsuarioId="+UsuarioId);
        }

        public override bool Eliminar()
        {
            return conexion.Ejecutar("Delete from Usuarios where UsuarioId="+UsuarioId);
        }

        public override bool Buscar(int IdBuscado)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Usuarios where UsuarioId = " + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                Contrasenia = dt.Rows[0]["Contrasenia"].ToString();
                Activo = (bool)dt.Rows[0]["Activo"];

                retorno = true;
            } 

            return retorno;
        }

        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            return conexion.ObtenerDatos("select " + Campos + " from Usuarios where " + Condicion +" order by UsuarioId "+Orden);

        }

        public bool IniciarSesion(string NombreUsuario, string Contrasenia)
        {
            
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Usuarios where  NombreUsuario='" + NombreUsuario + "' and Contrasenia='" + Contrasenia + "'");
         
            return dt.Rows.Count > 0 ;
        }
    }
}
