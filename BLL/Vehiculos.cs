using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Vehiculos:ClaseMaestra
    {
        public int VehiculoId { set; get; }
        public int MarcaId { set; get; }
        public int ModeloId { set; get; }
        public string Placa { set; get; }
        public int AnioFabricacion { set; get; }
        public int ClienteId { set; get; }
        private Conexion conexion = new Conexion();

        public Vehiculos()
        {
            VehiculoId = 0;
            MarcaId = 0;
            ModeloId = 0;
            Placa = "";
            AnioFabricacion = 0;
        }

        public override bool Insertar()
        {
            return conexion.Ejecutar("insert into Vehiculos(Placa,MarcaId,ModeloId,AnioFabricacion,ClienteId)values('" + Placa + "','" + MarcaId + "','" + ModeloId + "','" + AnioFabricacion + "','" + ClienteId + "')");
        }

        public override bool Modificar(int VehiculoId)
        {
            return conexion.Ejecutar("update Vehiculos set Placa='" + Placa + "', MarcaId= '" + MarcaId + "', ModeloId='" + ModeloId + "', AnioFabricacion='" + AnioFabricacion + "',ClienteId='" + ClienteId + "' where VehiculoId=" + VehiculoId);
        }

        public override bool Eliminar()
        {
            return conexion.Ejecutar("delete from Vehiculos where VehiculoId=" + VehiculoId);
        }

        public override bool Buscar(int VehiculoId)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from Vehiculos where VehiculoId = " + VehiculoId);
            if (dt.Rows.Count > 0)
            {
                VehiculoId = (int)dt.Rows[0]["VehiculoId"];
                Placa = dt.Rows[0]["Placa"].ToString();
                ModeloId = (int)dt.Rows[0]["ModeloId"];
                MarcaId =(int) dt.Rows[0]["MarcaId"];
                AnioFabricacion = (int)dt.Rows[0]["AnioFabricacion"];
                ClienteId = (int)dt.Rows[0]["ClienteId"];

                retorno = true;
            }

            return retorno;
        }

        public override DataTable Listar(string Campos, string filtrowhere, string orden)
        {
            return conexion.ObtenerDatos("select " + Campos + " from Vehiculos where " + filtrowhere+" order by VehiculoId "+orden);

        }
    }
}
