using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Video
    {
        public int codigoVideo { get; set; }
        public string tituloVideo { get; set; }
        public string duracion { get; set; }
        public string idiomas { get; set; }
        public string subtitulos { get; set; }
        public string sinopsis { get; set; }
        public DateTime anio { get; set; }
        public string ubicacion { get; set; }
        public string director { get; set; }
        public string productora { get; set; }
        public int codigo_tipo { get; set; }
    }
}
