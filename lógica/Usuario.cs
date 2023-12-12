using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lógica
{
    public class Usuario
    {
            String nombre;
            String apellido;
            String direccion;
            String contraseña;
            String correo;
            String email;
            String fechanacimiento;

            public Usuario(string nombre, string apellido, string direccion, string contraseña, string correo, string email, string fechanacimiento)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.direccion = direccion;
                this.contraseña = contraseña;
                this.correo = correo;
                this.email = email;
                this.fechanacimiento = fechanacimiento;
            }

            public string Nombre { get { return nombre; } set { nombre = value; } }

            public string Apellido { get { return apellido; } set { apellido = value; } }

            public string Direccion { get { return direccion; } set { direccion = value; } }

            public string Contraseña { get { return contraseña; } set { contraseña = value; } }

            public string Correo { get { return correo; } set { correo = value; } }

            public string Email { get { return email; } set { email = value; } }

            public string fechaNacimiento { get { return fechanacimiento; } set { fechanacimiento = value; } }

        }
    }


