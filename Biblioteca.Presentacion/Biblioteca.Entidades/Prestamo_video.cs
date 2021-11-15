using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Prestamo_video
    {
        public int codigoPrestamoVideo { get; set; }
        public int codigo_video { get; set; }
        public int codigo_usuario { get; set; }
        public DateTime fechaPrestamoVideo { get; set; }
        public DateTime fechaDevolucionVideo { get; set; }
    }
}
