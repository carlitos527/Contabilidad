using System;

namespace PollosWeed.Models
{
    public class KillPollos
    {
        public int Id { get; set; }
        public int PollosId { get; set; }
        public DateTime FechaMuerte { get; set; }
        public string Motivo { get; set; }
        public int Bajas { get; set; }
    }
}
