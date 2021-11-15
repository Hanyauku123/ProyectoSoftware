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
    public class NEditorial
    {
        public static DataTable Listar()
        {
            DEditorial Datos = new DEditorial();
            return Datos.ListarEditorial();
        }

        public static DataTable Buscar(string Valor)
        {
            DEditorial Datos = new DEditorial();
            return Datos.BuscarEditorial(Valor);
        }

        public static string Insertar(string nombreEditorial)
        {
            DEditorial Datos = new DEditorial();
            string Existe = Datos.ExisteEditorial(nombreEditorial);
            if (Existe.Equals("1"))
            {
                return "La editorial ya existe";
            }
            else
            {
                Editorial Obj = new Editorial();
                Obj.nombreEditorial = nombreEditorial;
                return Datos.InsertarEditorial(Obj); //retorna los datos a insertar
            }

        }

        public static string Actualizar(int codigoEditorial, string nombreEditorial)
        {
            DEditorial Datos = new DEditorial();
            Editorial Obj = new Editorial();
            Obj.codigoEditorial = codigoEditorial;
            Obj.nombreEditorial = nombreEditorial;
            return Datos.ActualizarEditorial(Obj);
        }

        public static string Eliminar(int codigoEditorial)
        {
            DEditorial Datos = new DEditorial();
            return Datos.EliminarEditorial(codigoEditorial);
        }

    }
}
