using System;

namespace PollosWeed.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int WeedId { get; set; } // Cambiado para coincidir con la columna de la base de datos
        public int CantidadVendida { get; set; }

        public DateTime FechaVenta { get; set; }
        public int PrecioTotal { get; set; } // El total ya multiplicado por 10,000

        public Venta(int id, int weedId, int cantidadVendida, DateTime fechaVenta, int precioTotal)
        {
            Id = id;
            WeedId = weedId; // Cambiado para coincidir con la columna de la base de datos
            CantidadVendida = cantidadVendida;
            FechaVenta = fechaVenta;
            PrecioTotal = precioTotal;
        }
    }
}
