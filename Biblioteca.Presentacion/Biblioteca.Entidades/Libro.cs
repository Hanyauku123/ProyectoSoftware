using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.Entidades
{
    public class Libro
    {
        public int codigoLibro { get; set; }
        public string tituloLibro { get; set; }
        public string isbn { get; set; }
        public int nPaginas { get; set; }
        public string idiomaLibro { get; set; }
        public string autor { get; set; }
        public int nEjemplares { get; set; }
        public DateTime anioEdicion { get; set; }
        public string descripcion { get; set; }
        public int nEdicion { get; set; }
        public string ejemplar { get; set; }
        public string ubicacion { get; set; }
        public int idEditorial { get; set; }
        public int idPais { get; set; }
        public int idMateria { get; set; }

    }
}
