using PollosWeed.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PollosWeed.Class
{
    public class WeedManager
    {
        private List<Weed> productos;

        public WeedManager()
        {
            productos = new List<Weed>();
        }

        // Agregar un nuevo producto
        public void AgregarProducto(Weed producto)
        {
            productos.Add(producto);
        }

        // Registrar una venta
        public void RegistrarVenta(int idProducto, int cantidadVendida, DateTime fechaVenta)
        {
            var producto = productos.FirstOrDefault(p => p.Id == idProducto);
            if (producto != null)
            {
                if (cantidadVendida > producto.CantidadRestante)
                {
                    throw new Exception("Cantidad vendida excede la cantidad restante.");
                }
                producto.RegistrarVenta(cantidadVendida, fechaVenta);
            }
            else
            {
                throw new Exception("Producto no encontrado.");
            }
        }

        // Calcular ganancias totales
        public decimal CalcularGanancias()
        {
            decimal ganancias = 0;
            foreach (var producto in productos)
            {
                ganancias += producto.Precio * (producto.Cantidad - producto.CantidadRestante);
            }
            return ganancias;
        }

        // Obtener el reporte de productos
        public List<Weed> ObtenerReporte()
        {
            return productos;
        }
    }
}
