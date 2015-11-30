using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BLL
{
    public class Contratos:ClaseMaestra
    {
        public int ContratoId { set; get; }
        public DateTime FechaVencimiento { set; get; }
        public static double TARIFA =700;
        public int ParqueId { set; get; }
        public int ClienteId { set; get; }
        public int VehiculoId { set; get; }
        public double Total { set; get; }
        public double Balance { set; get; }
        public bool Activo { set; get; }
        private Conexion conexion = new Conexion();

        public Contratos()
        {
            ContratoId = 0;
            ParqueId = 0;
            ClienteId = 0;
            VehiculoId = 0;
            Total = 0;
            Balance = 0;
        }

        public override bool Insertar()
        {
            return conexion.Ejecutar("insert into Contratos(FechaVencimiento,Tarifa,ParqueoId,ClienteId,VehiculoId,Total,Balance,Activo)values('" + FechaVencimiento.ToString("MM/dd/yyyy") + "','" + TARIFA + "','" + ParqueId + "', '" + ClienteId + "', '" + VehiculoId + "','" + Total + "','" + Balance + "','" + Activo + "')");
        }

        public override bool Modificar(int ContratoId)
        {
            return conexion.Ejecutar("update Contratos set FechaVencimiento='" + FechaVencimiento.ToString("MM/dd/yyyy") + "', Tarifa='" + TARIFA + "', ParqueoId='" + ParqueId + "',ClienteId='" + ClienteId + "', VehiculoId='" + VehiculoId + "', Total='" + Total + "', Balance='" + Balance + "', Activo='" + Activo + "' where ContratoId='" + ContratoId+"'");
        }

        public override bool Eliminar()
        {
            return conexion.Ejecutar("delete from Contratos where ContratoId=" + ContratoId);
        }

        public override bool Buscar(int ContratoId)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Contratos where ContratoId = " + ContratoId);
            if (dt.Rows.Count > 0)
            {
                ContratoId = (int)dt.Rows[0]["ContratoId"];
                FechaVencimiento =(DateTime) dt.Rows[0]["FechaVencimiento"];
                ParqueId = (int)dt.Rows[0]["ParqueoId"];
                ClienteId = (int)dt.Rows[0]["ClienteId"];
                VehiculoId = (int)dt.Rows[0]["VehiculoId"];
                Total = (double)dt.Rows[0]["Total"];
                Activo = (bool)dt.Rows[0]["Activo"];

                retorno = true;
            }

            return retorno;
        }

        public override DataTable Listar(string Campos, string filtrowhere, string orden)
        {
            return conexion.ObtenerDatos("select " + Campos + " from Contratos where " + filtrowhere +" order by ContratoId "+orden);

        }
        
    }
}
