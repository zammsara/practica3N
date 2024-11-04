using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.models
{
    internal class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        // Método para validar usuario y contraseña
        public bool EsUsuarioValido(string nombreUsuario, string contrasena)
        {
            return NombreUsuario == nombreUsuario && Contrasena == contrasena;
        }
    }
}
