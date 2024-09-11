using System;

namespace PollosWeed.Models
{
    public class Pollos
    {
        // Propiedades
        public int Id { get; set; }
        public string TipoProducto { get; set; }
        public int Cantidad { get; set; }
        public int PesoUnitario { get; set; } // Cambiado a int
        public int PesoTotal => Cantidad * PesoUnitario; // Cambiado a int
        public int PrecioUnitario { get; set; } // Cambiado a int
        public int PrecioTotal { get; set; } // Cambiado a int
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        // Método para registrar una muerte
        public void RegistrarMuerte(DateTime fechaMuerte, string motivo, int bajas)
        {
            var muerte = new MuertePollos
            {
                PollosId = this.Id,
                FechaMuerte = fechaMuerte,
                Motivo = motivo,
                Bajas = bajas
            };

            // Guardar muerte en la base de datos (esto es un ejemplo; necesitarías implementar el código real para guardar en la base de datos)
            // Database.Save(muerte);

            // Actualizar la cantidad de pollos en la base de datos
            ActualizarCantidad(bajas);
        }

        private void ActualizarCantidad(int bajas)
        {
            // Aquí deberías implementar el código para actualizar la cantidad de pollos en la base de datos
            // Por ejemplo, podrías restar las bajas de la cantidad actual en la base de datos
            // Esto es solo un ejemplo:
            // Database.UpdateCantidad(this.Id, this.Cantidad - bajas);
        }
    }

    // Clase para representar una muerte de pollo (similar a la tabla MuertesPollos)
    public class MuertePollos
    {
        public int Id { get; set; }
        public int PollosId { get; set; }
        public DateTime FechaMuerte { get; set; }
        public string Motivo { get; set; }
        public int Bajas { get; set; } // Agregado para manejar la cantidad de bajas
    }
}
