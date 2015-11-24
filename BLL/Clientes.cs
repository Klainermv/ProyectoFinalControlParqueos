using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Clientes: ClaseMaestra
    {
        public int ClienteId { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public string Cedula { set; get; }
        public string Telefono { set; get; }
        public DateTime FechaIngreso { set; get; }
        private Conexion conexion = new Conexion();

        public Clientes()
        {
            ClienteId = 0;
            Nombres = "";
            Apellidos = "";
            Cedula = "";
            Telefono = "";
        }

        public override bool Insertar()
        {
            return conexion.Ejecutar("insert into Clientes(Nombres,Apellidos,Cedula,Telefono,FechaIngreso)values('"+Nombres+"','"+Apellidos+"','"+Cedula+"','"+Telefono+"','"+FechaIngreso.ToString("MM/dd/yyyy")+"')");
        }

        public override bool Modificar(int ClienteId)
        {
            return conexion.Ejecutar("update Clientes set Nombres='" + Nombres + "',Apellidos= '" + Apellidos + "',Cedula='" + Cedula + "',Telefono='" + Telefono + "',FechaIngreso='" + FechaIngreso.ToString("MM/dd/yyyy") + "' where ClienteId=" + ClienteId);
        }

        public override bool Eliminar()
        {
            return conexion.Ejecutar("delete from Clientes where ClienteId="+ClienteId);
        }

        public override bool Buscar(int ClienteId)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Clientes where ClienteId = " + ClienteId);
            if (dt.Rows.Count > 0)
            {
                ClienteId = (int)dt.Rows[0]["ClienteId"];
                Nombres = dt.Rows[0]["Nombres"].ToString();
                Apellidos = dt.Rows[0]["Apellidos"].ToString();
                Cedula = dt.Rows[0]["Cedula"].ToString();
                Telefono = dt.Rows[0]["Telefono"].ToString();
                FechaIngreso = (DateTime)dt.Rows[0]["FechaIngreso"];

                retorno = true;
            }

            return retorno;
        }

        public override DataTable Listar(string Campos, string filtrowhere, string orden)
        {
            return conexion.ObtenerDatos("select " + Campos + " from Clientes where " + filtrowhere+" order by ClienteId "+orden);

        }
    }
}
