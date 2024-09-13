using System;

namespace PollosWeed.Models
{
    public class Weed
    {
        // Propiedades
        public int Id { get; set; } // Identificador único
        public string Producto { get; set; }
        public int Cantidad { get; set; } // Cantidad inicial
        public int Peso { get; set; } // Peso por unidad o total según lo que se registre, ahora como entero
        public int Precio { get; set; } // Precio ahora como entero
        public int CantidadRestante { get; set; } // Cantidad restante para ventas parciales
        public DateTime FechaInicio { get; set; } // Fecha de inicio de ventas
        public DateTime? FechaUltimaVenta { get; set; } // Fecha de la última venta (nullable)

        // Constructor actualizado para inicializar las propiedades
        public Weed(int id, string producto, int cantidad, int peso, int precio, DateTime fechaInicio)
        {
            Id = id;
            Producto = producto;
            Cantidad = cantidad;
            Peso = peso; // Peso ahora se maneja como entero
            Precio = precio; // Precio ahora se maneja como entero
            CantidadRestante = cantidad; // Inicialmente igual a la cantidad total
            FechaInicio = fechaInicio;
            FechaUltimaVenta = null; // Inicialmente sin ventas
        }

        // Método para actualizar la cantidad restante después de una venta
        public void RegistrarVenta(int cantidadVendida, DateTime fechaVenta)
        {
            CantidadRestante -= cantidadVendida;
            FechaUltimaVenta = fechaVenta;
        }
    }
}
