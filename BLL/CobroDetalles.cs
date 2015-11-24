using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CobroDetalles
    {
        public int CobroDetalleId { set; get; }
        public int ContratoId { set; get; }
        public float Total { set; get; }

        public CobroDetalles()
        {
            CobroDetalleId=0;
            ContratoId = 0;
            Total = 0;
        }

        public CobroDetalles(int ContratoId, float Total)
        {
            this.ContratoId = ContratoId;
            this.Total = Total;
            this.CobroDetalleId = CobroDetalleId;
        }
    }
}
