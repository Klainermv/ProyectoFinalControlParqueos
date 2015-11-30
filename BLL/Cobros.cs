using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BLL
{
    public class Cobros: ClaseMaestra
    {
        public int CobroId { set; get; }
        public DateTime Fecha { set; get; }
        public float Monto { set; get; }
        private Conexion conexion = new Conexion();
        public int CobroDetalleId { set; get; }
        public int ClienteId { set; get; }
        public float Total { set; get; }

        public Cobros()
        {
            CobroId = 0;
            Monto = 0;
            CobroDetalleId = 0;
            ClienteId = 0;
            Total = 0;
        }


        public override bool Insertar()
        {

            return conexion.Ejecutar("insert into Cobros(Fecha,Monto) values('" + Fecha.ToString("MM/dd/yyyy") + "','" + Monto + "')"); 
        }

        public bool InsertarDetalle()
        {
            return conexion.Ejecutar("insert into CobrosDetalle(CobroId,ClienteId,Total) Values('"+CobroId+"','" + ClienteId + "','" +Total + "');"); 
        }



        public override bool Modificar(int CobroId)
        {
           

            return conexion.Ejecutar("update Cobros set Fecha='"+Fecha+"', Monto='"+Monto+"' where CobroId = '"+CobroId+"'");
        }

        public bool EliminarDetalle()
        {
            return conexion.Ejecutar("Delete From CobroDetalles Where CobroId=" + this.CobroId);
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            retorno = conexion.Ejecutar("delete  from CobrosDetalle where CobroId= " + this.CobroId + "; " + "Delete From Cobros Where CobroId=" + this.CobroId);

            return retorno;
        }

        public override bool Buscar(int CobroId)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            
            dt = conexion.ObtenerDatos(String.Format("select * from Cobros where CobroId='"+CobroId+"'"));
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                this.CobroId = (int)dt.Rows[0]["CobroId"];
                this.Fecha =(DateTime) dt.Rows[0]["Fecha"];
                this.Monto =(float) dt.Rows[0]["Monto"];

            }

            return retorno;
        }

       

        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {

            string ordenFinal = ""; //!orden.Equals("") ? " orden by  " + orden : "";
            if (!Orden.Equals(""))
                ordenFinal = " order by  " + Orden;

            return conexion.ObtenerDatos(("Select " + Campos +
                " from Cobros where " + Condicion + ordenFinal));
        }

        public bool ObtenerValor()
        {
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("Select Max(CobroId) from Cobros"));
            if (dt.Rows.Count > 0)
            {
                this.CobroId = (int)dt.Rows[0]["CobroId"];
            }

            return dt.Rows.Count > 0;
        }

        public bool MaximoCobroId()
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("select Max(CobroId) as CobroId from Cobros"));
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                CobroId = (int)dt.Rows[0]["CobroId"];


            }

            return retorno;
        }
    }
}
