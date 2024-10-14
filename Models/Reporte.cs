using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenUnidad2.Models
{
    public class Reporte
    {
         int id { get; set; }
        private string? nombreCliente { get; set; }
        private string? fallo { get; set; }
        
        private string? estado{ get; set; }

        private string? prioridad { get; set; }

        public string? fechaEnvio { get; set; }

        public string? fechaRespuesta { get; set; }

        public string? fechaResolucion{ get; set; }

        private string? encargado { get; set; }
    }
}