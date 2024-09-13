using System;
using System.ComponentModel.DataAnnotations;

namespace PollosWeed.Models
{
    public class Cronograma
    {
        public int Id { get; set; }
        public int PollosId { get; set; }
        public string TipoProducto { get; set; }
        public int InsumosId { get; set; }
        public string Insumo { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Semana { get; set; }
        public string Lunes { get; set; }
        public string Martes { get; set; }
        public string Miercoles { get; set; }
        public string Jueves { get; set; }
        public string Viernes { get; set; }
        public string Sabado { get; set; }
        public string Domingo { get; set; }
    }
}
