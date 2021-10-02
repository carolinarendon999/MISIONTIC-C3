using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Dominio;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
 
namespace ProyectoCiclo3.App.Frontend.Pages{
    public class ListServicioModel : PageModel{
        private readonly RepositorioServicio repositorioServicio;
        public IEnumerable<Servicio> Servicio {get;set;}
 
    public ListServicioModel(RepositorioServicio repositorioServicio){
        this.repositorioServicio = repositorioServicio;
     }
 
    public void OnGet(){
        Servicio = repositorioServicio.GetAll();
    }

    /*
    public IActionResult OnPost(){
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Servicio.id>0)
            {
            Servicio = repositorioServicio.Update(Servicio);
            }
            return Page();
        }

    */

    }
}
