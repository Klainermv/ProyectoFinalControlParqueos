using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CobroDetalles
    {
        public int CobroDetalleId { set; get; }
        public int ClienteId { set; get; }
        public float Total { set; get; }

        public CobroDetalles()
        {
            CobroDetalleId=0;
            ClienteId = 0;
            Total = 0;
        }

        public CobroDetalles(int ClienteId, float Total)
        {
            this.ClienteId = ClienteId;
            this.Total = Total;
            this.CobroDetalleId = CobroDetalleId;
        }
    }
}
