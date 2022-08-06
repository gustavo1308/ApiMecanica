using System;
using System.ComponentModel.DataAnnotations;

namespace AM.Domain
{
    public class Carros
    {
        [Key]
        public Guid Placa { get; set; }

        public string Fabricante { get; set; }

        public string Modelo { get; set; }

        public int AnoDeProducao { get; set; }

        public string DefeitoAConsertar { get; set; }
    }
}
