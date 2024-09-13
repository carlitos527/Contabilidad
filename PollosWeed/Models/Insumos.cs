using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollosWeed.Models
{
    public class Insumos
    {

        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Detalle { get; set; }
        public int VrUnitario { get; set; }
        public int VrTotal { get; set; }
        public DateTime FechaEntrada { get; set; }
    }
}
