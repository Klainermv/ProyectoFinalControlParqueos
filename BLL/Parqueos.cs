using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BLL
{
    public class Parqueos: ClaseMaestra
    {
        public int ParqueoId { set; get; }
        public bool Disponible { set; get; }
        private Conexion conexion = new Conexion();

        public Parqueos()
        {
            ParqueoId = 0;
            Disponible = false;
        }

        public override bool Insertar()
        {
            return conexion.Ejecutar("insert into Parqueos(Disponible)values('" + Disponible + "')");
        }

        public override bool Modificar(int ParqueoId)
        {
            return conexion.Ejecutar("update Parqueos set Disponible='" + Disponible + "' where ParqueoId=" + ParqueoId);
        }

        public override bool Eliminar()
        {
            return conexion.Ejecutar("delete from Parqueos where ParqueoId=" + ParqueoId);
        }

        public override bool Buscar(int ParqueoId)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Parqueos where ParqueoId = " + ParqueoId);
            if (dt.Rows.Count > 0)
            {
                ParqueoId = (int)dt.Rows[0]["ParqueoId"];
                Disponible =(bool) dt.Rows[0]["Disponible"];


                retorno = true;
            }

            return retorno;
        }

        public override DataTable Listar(string Campos, string filtrowhere, string orden)
        {
            return conexion.ObtenerDatos("select " + Campos + " from Parqueos where " + filtrowhere + " order by ParqueoId "+orden);

        }
    }
}
