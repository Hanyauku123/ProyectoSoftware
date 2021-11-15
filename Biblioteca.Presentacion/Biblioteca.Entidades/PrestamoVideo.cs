using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class PrestamoVideo
    {
        public int codigo_prestamo_video { get; set; }
        public int codigo_video { get; set; }
        public int codigo_usuario { get; set; }
        public DateTime fecha_prestamo { get; set; }
        public DateTime fecha_devolucion { get; set; }
    }
}
