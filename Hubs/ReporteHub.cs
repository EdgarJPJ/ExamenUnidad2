using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenUnidad2.Models;
using Microsoft.AspNetCore.SignalR;

namespace ExamenUnidad2.Hubs
{
    public class ReporteHub : Hub
    {
    
       public async Task AddToGroup(string nombreGrupo)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, nombreGrupo);
        }

        
        public async Task SendReporte(string noombreGrupo, Reporte reporte)
        {
            await Clients.Group(noombreGrupo).SendAsync("EnviarReporte", reporte);
        }

    }
}