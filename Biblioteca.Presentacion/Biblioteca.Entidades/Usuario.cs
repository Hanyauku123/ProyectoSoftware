using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Usuario
    {
        public int codigoUsuario { get; set; }
        public string email { get; set; }
        public string contrasenia { get; set; }
        public string nombreUsuario { get; set; }
        public string apellidoUsuario { get; set; }
        public string direccion { get; set; }
    }
}
