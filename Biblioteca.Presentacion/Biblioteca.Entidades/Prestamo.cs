using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Prestamo
    {
        public int codigoPrestamoLibro { get; set; }
        public int codigo_libro { get; set; }
        public int codigo_usuario { get; set; }
        public DateTime fechaPrestamoLibro { get; set; }
        public DateTime fechaDevolucionLibro { get; set; }
    }
}
