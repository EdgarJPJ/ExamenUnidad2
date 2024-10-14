using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenUnidad2.Models
{
    public class Reporte
    {
        private int id { get; set; }
        private string? nombreCliente { get; set; }
        private string? fallo { get; set; }
        
        private string? estado{ get; set; }

        private string? prioridad { get; set; }

        private string? fechaEnvio { get; set; }

        private string? fechaRespuesta { get; set; }

        private string? fechaResolucion{ get; set; }

        private string? encargado { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? NombreCliente
        {
           get=> nombreCliente;
            set=> nombreCliente = value;
        }

        public string? Fallo
        {
            get => fallo;
            set => fallo = value;
        }

        public string? Estado
        {
            get=> estado;
            set=> estado = value;
        }

        public string? Prioridad
        {
            get => prioridad;
            set => prioridad = value;

        }

        public string? FechaEnvio
        {
            get=> fechaEnvio;
            set=> fechaEnvio = value;

        }

        public string? FechaRespuesta
        {
            get => fechaRespuesta;
            set => fechaRespuesta = value;

        }

        public string? FechaResolucion
        {
           get=> fechaResolucion;
            set=> fechaResolucion = value;

        }

        public string? Encargado
        {
           get=> encargado;
            set=> encargado = value;
        }
        
        public override string ToString(){
            return "Id: " + id + "Nombre Cliente: " + nombreCliente + "Fallo: " + fallo + "Estado: " + estado + "Prioridad: " + prioridad + "Fecha de Envio: " + fechaEnvio + "Fecha de Respuesta: " + fechaRespuesta + "Fecha de Resolucion: " + fechaResolucion + "Encargado: " + encargado;
        }

    }
}