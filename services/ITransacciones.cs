using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenUnidad2.Models;

namespace ExamenUnidad2.services
{
    public interface ITransacciones
    {
        public bool agregar(Reporte r);
        
        public List<Reporte> consultar();

        public bool eliminar(int id);

        public bool Actualizar(Reporte r);

        public Reporte obtenerReporte(int id);

        
}
}