using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BLL
{
    public class Marcas : ClaseMaestra
    {
        public int MarcaId { set; get; }
        public string Descripcion { set; get; }
        private Conexion conexion = new Conexion();

        public Marcas()
        {
            MarcaId = 0;
            Descripcion = "";

        }

        public override bool Insertar()
        {
            return conexion.Ejecutar("insert into Marcas(Descripcion)values('" + Descripcion + "')");
        }

        public override bool Modificar(int MarcaId)
        {
            return conexion.Ejecutar("update Marcas set Descripcion='" + Descripcion + "' where MarcaId=" + MarcaId);
        }

        public override bool Eliminar()
        {
            return conexion.Ejecutar("delete from Marcas where MarcaId=" + MarcaId);
        }

        public override bool Buscar(int MarcaId)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Marcas where MarcaId = " + MarcaId);
            if (dt.Rows.Count > 0)
            {
                MarcaId = (int)dt.Rows[0]["MarcaId"];
                Descripcion = dt.Rows[0]["Descripcion"].ToString();
              

                retorno = true;
            }

            return retorno;
        }

        public override DataTable Listar(string Campos, string filtrowhere, string orden)
        {
            return conexion.ObtenerDatos("select " + Campos + " from Marcas where " + filtrowhere + " order by MarcaId " + orden);

        }
    }
}
