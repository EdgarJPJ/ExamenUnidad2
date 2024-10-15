using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenUnidad2.Models;

namespace ExamenUnidad2.services
{
    public class Transacciones : ITransacciones
    {

        List<Reporte> reportes = new List<Reporte>();

        public Transacciones()
        {
            reportes = new List<Reporte>();
        }

       public bool agregar(Reporte reporte)
    {
        if (reporte.Id == 0)
        {
            reporte.Id = reportes.Count + 1;
        }
        reportes.Add(reporte);
        return true;
    }
        public List<Reporte> consultar()
        {
            return reportes;
        }
        public Reporte obtenerReporte(int id)
        {
            return reportes.Find(r => r.Id == id);
        }

        public bool eliminar(int id)
        {
            Reporte r = reportes.Find(r => r.Id == id);
            if (r != null)
            {
                reportes.Remove(r);
                return true;
            }
            return false;
        }

        public bool Actualizar(Reporte r)
        {
            int index = reportes.FindIndex(rep => rep.Id == r.Id);
            if (index != -1)
            {
                reportes[index] = r;
                return true;
            }
            return false;
        }
    }
}

