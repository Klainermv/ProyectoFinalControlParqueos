using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BLL
{
    public class Modelos: ClaseMaestra
    {
        public int ModeloId { set; get; }
        public string Descripcion { set; get; }
        private Conexion conexion = new Conexion();

        public Modelos()
        {
            ModeloId = 0;
            Descripcion = "";

        }

        public override bool Insertar()
        {
            return conexion.Ejecutar("insert into Modelos(Descripcion)values('" + Descripcion + "')");
        }

        public override bool Modificar(int ModeloId)
        {
            return conexion.Ejecutar("update Modelos set Descripcion='" + Descripcion + "' where ModeloId=" + ModeloId);
        }

        public override bool Eliminar()
        {
            return conexion.Ejecutar("delete from Modelos where ModeloId=" + ModeloId);
        }

        public override bool Buscar(int ModeloId)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Modelos where ModeloId = " + ModeloId);
            if (dt.Rows.Count > 0)
            {
                ModeloId = (int)dt.Rows[0]["ModeloId"];
                Descripcion = dt.Rows[0]["Descripcion"].ToString();
              

                retorno = true;
            }

            return retorno;
        }

        public override DataTable Listar(string Campos, string filtrowhere, string orden)
        {
            return conexion.ObtenerDatos("select " + Campos + " from Modelos where " + filtrowhere + " order by ModeloId " + orden);

        }
    }
}
