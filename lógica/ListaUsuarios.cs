using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lógica
{
    public class ListaUsuarios
    {
        private List<Usuario> listaUsuarios;

        public ListaUsuarios()
        {
        }

        public ListaUsuarios(List<Usuario> listaUsuarios)
        {
            listaUsuarios = listaUsuarios;
        }

        public object BuscarUsuario(String nombre, String apellido, String direccion, String contraseña, String correo, String email, String fechanacimiento)
        {
            Usuario usuarioEncontrado = null;

         foreach(var usuario in listaUsuarios)
         {

         if(usuario.Nombre== nombre)
         {

          usuarioEncontrado = usuario;
          break;
          }

       }

         return usuarioEncontrado;

        }

        internal Usuario BuscarUsuario(string nuevoUsuario)
        {
            throw new NotImplementedException();
        }

        internal void EliminarUsuario(string nombre)
        {
            throw new NotImplementedException();
        }

        internal void EditarUsuario(string nombreantiguo, string nombreactual)
        {
            throw new NotImplementedException();
        }
    }

    public class Clase3
    {
        private ListaUsuarios buscador;

        public Clase3()
        {
            this.buscador = new ListaUsuarios();

        }

        public object AgregarUsuario(string nuevoUsuario)
    {


            Usuario usuarioEncontrado = buscador.BuscarUsuario(nuevoUsuario);

    if (usuarioEncontrado==null)
     {

     return nuevoUsuario;

        }

    else

        {
            return null;
        }

      }

        public void EliminarUsuario(string nombre)
        {
            buscador.EliminarUsuario(nombre);
        }

        public void EditarUsuario(string nombreantiguo, string nombreactual)
        {
            buscador.EditarUsuario(nombreantiguo, nombreactual);
        }

    }

}
