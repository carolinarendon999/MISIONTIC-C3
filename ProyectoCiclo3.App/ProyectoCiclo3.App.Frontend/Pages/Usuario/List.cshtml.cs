using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListUsuarioModel : PageModel
    {
       
        private readonly RepositorioUsuario repositorioUsuario;  //readonly---> solo lectura
        [BindProperty]
        public Usuario User {get;set;}

        public IEnumerable<Usuario> Usuario {get;set;}
 
    public ListUsuarioModel(RepositorioUsuario repositorioUsuario)
    {
        this.repositorioUsuario=repositorioUsuario;
     }
 
    public void OnGet()
    {
        Usuario=repositorioUsuario.GetAll();
    }

    public IActionResult OnPost() //envio de información
    {
        if(User.id>0)
        {
        repositorioUsuario.Delete(User.id);
        }
        return RedirectToPage("./List");
    }

    }
}
