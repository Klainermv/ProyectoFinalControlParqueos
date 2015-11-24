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
        public List<CobroDetalles> CobroDetalles;
        private Conexion conexion = new Conexion();

        public Cobros()
        {
            CobroId = 0;
            Monto = 0;
            CobroDetalles = new List<CobroDetalles>();
        }

        public void AgregarCobroDetalles(int ContratoId, float Total)
        {
            this.CobroDetalles.Add(new CobroDetalles(ContratoId, Total));
        }

        public override bool Insertar()
        {
            string retorno="";
           

             retorno = "insert into Cobros(Fecha,Monto) values('"+Fecha.ToString("MM/dd/yyyy")+"','"+Monto+"')";
            
                 

                foreach (var detalle in this.CobroDetalles)
                {
                    retorno+= "insert into CobrosDetalle(CobroId,ContratoId,Total) Values('Select Max(CobroId) from Cobros','" + detalle.ContratoId + "','" + detalle.Total + "');";

                }


                return conexion.Ejecutar(retorno); 
        }


        public override bool Modificar(int CobroId)
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();

            retorno = conexion.Ejecutar(string.Format("update Cobros set Fecha='"+Fecha+"', Monto='"+Monto+"' where CobroId = '"+CobroId+"'"));


            if (retorno)
            {
                conexion.Ejecutar("Delete From CobroDetalles Where CobroId=" + this.CobroId);

                foreach (var detalle in this.CobroDetalles)
                {
                    Comando.AppendLine(String.Format("insert into CobroDetalles(CobroId,ContratoId,Total) Values('" + this.CobroId + "','" + detalle.ContratoId + "','" + detalle.Total + "');"));

                }

                retorno = conexion.Ejecutar(Comando.ToString());
            }


            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            retorno = conexion.Ejecutar("delete  from Cobros where CobroId= " + this.CobroId + "; " + "Delete From CobroDetalles Where CobroId=" + this.CobroId);

            return retorno;
        }

        public override bool Buscar(int CobroId)
        {
            DataTable dt = new DataTable();
            DataTable dtDetalles = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("select * from Cobros where CobroId='"+CobroId+"'"));
            if (dt.Rows.Count > 0)
            {
                this.CobroId = (int)dt.Rows[0]["CobroId"];
                this.Fecha =(DateTime) dt.Rows[0]["Fecha"];
                this.Monto =(float) dt.Rows[0]["Monto"];


                dtDetalles = conexion.ObtenerDatos("Select c.CobroId,cd.ContratoId,cd.Total " +
                                                    "From Cobros c " +
                                                    "Inner Join CobroDetalles cd On c.CobroId=cd.CobroId" +
                                                    "Where  c.CobroId=" + this.CobroId);

                foreach (DataRow row in dtDetalles.Rows)
                {
                    this.AgregarCobroDetalles( (int)row["ContratoId"], (float)row["Total"]);
                }
            }

            return dt.Rows.Count > 0;
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
    }
}
