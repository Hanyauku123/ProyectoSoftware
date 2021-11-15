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
    public class NPrestamo
    {
        public static DataTable Listar()
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.ListarPrestamo();
        }

        public static DataTable Buscar(string Valor)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.BuscarPrestamo(Valor);
        }

        public static DataTable BuscarEliminar(string Valor)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.BuscarEliminar(Valor);
        }

        public static string Insertar(int codigo_libro, int codigo_usuario, DateTime fechaPrestamoLibro, DateTime fechaDevolucionLibro)
        {
            DPrestamo Datos = new DPrestamo();
            DataTable Existe = Datos.ExistePrestamo(codigo_libro);
            if (Existe.Rows.Count > 0)
            {
                return "El prestamo ya existe";
            }
            else
            {
                Prestamo Obj = new Prestamo();
                Obj.codigo_libro = codigo_libro;
                Obj.codigo_usuario = codigo_usuario;
                Obj.fechaPrestamoLibro = fechaPrestamoLibro;
                Obj.fechaDevolucionLibro = fechaDevolucionLibro;
                return Datos.InsertarPrestamo(Obj); //retorna los datos a insertar
            }

        }

        public static string Actualizar(int codigoPrestamoLibro, int codigo_libro, int codigo_usuario, DateTime fechaPrestamoLibro, DateTime fechaDevolucionLibro)
        {
            DPrestamo Datos = new DPrestamo();
            Prestamo Obj = new Prestamo();
            Obj.codigoPrestamoLibro = codigoPrestamoLibro;
            Obj.codigo_libro = codigo_libro;
            Obj.codigo_usuario = codigo_usuario;
            Obj.fechaPrestamoLibro = fechaPrestamoLibro;
            Obj.fechaDevolucionLibro = fechaDevolucionLibro;
            return Datos.ActualizarPrestamo(Obj);
        }

        public static string Devolver(int codigoPrestamoLibro)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.Devolver(codigoPrestamoLibro);
        }

        public static string Eliminar(int codigoPrestamoLibro)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.EliminarPrestamo(codigoPrestamoLibro);
        }
    }
}
