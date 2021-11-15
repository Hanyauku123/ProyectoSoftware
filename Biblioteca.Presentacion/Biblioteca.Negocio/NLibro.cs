using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocio
{
    public class NLibro
    {
        public static DataTable Listar()
        {
            DLibro Datos = new DLibro();
            return Datos.ListarLibro();
        }

        public static DataTable ListarUpdate(string Valor)
        {
            DLibro Datos = new DLibro();
            return Datos.ListarUpdate(Valor);
        }

        public static DataTable Buscar(string Valor)
        {
            DLibro Datos = new DLibro();
            return Datos.BuscarLibro(Valor);
        }

        
        public static string Insertar(string tituloLibro, string isbn, int nPaginas, string idiomaLibro, string autor, int nEjemplares, DateTime anioEdicion, string descripcion, int nEdicion, String ejemplar, String ubicacion, int idEditorial, int idPais, int idMateria)
        {
   
            DLibro Datos = new DLibro();
            DataTable Existe = Datos.BuscarLibro(tituloLibro);
            if (Existe.Rows.Count>0)
            {
                return "El libro ya existe";
            }
            else
            {
                Libro Obj = new Libro();
                Obj.tituloLibro = tituloLibro;
                Obj.isbn = isbn;
                Obj.nPaginas = nPaginas;
                Obj.idiomaLibro = idiomaLibro;
                Obj.autor = autor;
                Obj.nEjemplares = nEjemplares;
                Obj.anioEdicion = anioEdicion;
                Obj.descripcion = descripcion;
                Obj.nEdicion = nEdicion;
                Obj.ejemplar = ejemplar;
                Obj.ubicacion = ubicacion;
                Obj.idEditorial = idEditorial;
                Obj.idPais = idPais;
                Obj.idMateria = idMateria;
                return Datos.InsertarLibro(Obj); //retorna los datos a insertar
            }

        }

        public static string Actualizar(int codigoLibro, string tituloLibro, string isbn, int nPaginas, string idiomaLibro, string autor, int nEjemplares, DateTime anioEdicion, string descripcion, int nEdicion, string ejemplar, string ubicacion, int idEditorial, int idPais, int idMateria)
        {
            DLibro Datos = new DLibro();
            Libro Obj = new Libro();
            Obj.codigoLibro = codigoLibro;
            Obj.tituloLibro = tituloLibro;
            Obj.isbn = isbn;
            Obj.nPaginas = nPaginas;
            Obj.idiomaLibro = idiomaLibro;
            Obj.autor = autor;
            Obj.nEjemplares = nEjemplares;
            Obj.anioEdicion = anioEdicion;
            Obj.descripcion = descripcion;
            Obj.nEdicion = nEdicion;
            Obj.ejemplar = ejemplar;
            Obj.ubicacion = ubicacion;
            Obj.idEditorial = idEditorial;
            Obj.idPais = idPais;
            Obj.idMateria = idMateria;
            return Datos.ActualizarLibro(Obj);
        }

        public static string Eliminar(int codigoLibro)
        {
            DLibro Datos = new DLibro();
            return Datos.EliminarLibro(codigoLibro);
        }
    }
}
