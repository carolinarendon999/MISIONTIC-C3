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
                new Usuario{id=1,nombre="Carolina",apellidos= "Rendon",direccion= "Cra 33 # 6",telefono= "3185679874",ciudad="Bogota"},
                new Usuario{id=2,nombre="Camila",apellidos= "Samboni",direccion= "Calle 65",telefono= "31578906542",ciudad="Cali"},
                new Usuario{id=3,nombre="Maria",apellidos= "Ocampo",direccion= "Barrio El Olivo",telefono= "3106789654",ciudad="Popayan"}
 
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

        //Metodos CRUD

        public Usuario Create(Usuario newUsuario)
        {
           if(usuario.Count > 0){
           newUsuario.id=usuario.Max(r => r.id) +1; 
            }else{
               newUsuario.id = 1; 
            }
           usuario.Add(newUsuario);
           return newUsuario;
        }

        public Usuario Update(Usuario newUsuario){

            var user = usuario.SingleOrDefault(b => b.id == newUsuario.id);

            if(user != null){
                user.nombre = newUsuario.nombre;
                user.apellidos = newUsuario.apellidos;
                user.direccion = newUsuario.direccion;
                user.telefono = newUsuario.telefono;
                user.ciudad = newUsuario.ciudad;
            }
        return user;
        }

        public void Delete(int id)
        {
        var user= usuario.SingleOrDefault(b => b.id == id);
        usuario.Remove(user);
        return;
        }
        
    }
}
