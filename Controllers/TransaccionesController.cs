using ExamenUnidad2.Models;
using ExamenUnidad2.services;
using Microsoft.AspNetCore.Mvc;


namespace ExamenUnidad2.Controllers
{
    
    public class TransaccionesController : Controller
    {
        public readonly ITransacciones baseDatos;

        public TransaccionesController(ITransacciones baseDatos){
            this.baseDatos = baseDatos;
        }

        [HttpGet]
        public IActionResult getReportes(){
            return Json(baseDatos.consultar()); 
        }

        [HttpGet]
        public IActionResult getReporte(int id){
            return Json(baseDatos.obtenerReporte(id));
        }

        [HttpPost]
        public IActionResult agregarReporte([FromBody] Reporte r){
             baseDatos.agregar(r);
                return Json(new {mensaje = "Reporte agregado" });
        } 

        [HttpPost]
        public IActionResult actualizarReporte([FromBody] Reporte r){
            if(baseDatos.Actualizar(r)){
                return Json(new {mensaje = "Reporte actualizado"});
            }
            return Json(new {mensaje = "Reporte no encontrado"});
        }   
        [HttpPost]
        public IActionResult eliminarReporte(int id){
            Reporte r = baseDatos.obtenerReporte(id);
            if(baseDatos.eliminar(id)){
            return Json(new {mensaje = "Reporte eliminado:" });    
            }
            return Json(new {mensaje = "Reporte no encontrado"});
        }
}
}