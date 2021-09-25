using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> usuario;
 
    public RepositorioUsuario()
        {
            usuario = new List<Usuario>()
            {
                new Usuario{id=1,nombre="Carolina",apellidos= "Rendon",direccion= "Cra 33 # 6",telefono= "3185679874"},
                new Usuario{id=2,nombre="Camila",apellidos= "Samboni",direccion= "Calle 65",telefono= "31578906542"},
                new Usuario{id=3,nombre="Maria",apellidos= "Ocampo",direccion= "Barrio El Olivo",telefono= "3106789654"}
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuario;
        }
 
        public Usuario GetUsuarioWithId(int id){
            return usuario.SingleOrDefault(b => b.id == id);

            // metodo add usuario
        }
    }
}
