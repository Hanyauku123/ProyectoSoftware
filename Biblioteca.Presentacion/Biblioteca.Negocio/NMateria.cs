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
    public class NMateria
    {
        public static DataTable Listar()
        {
            DMateria Datos = new DMateria();
            return Datos.ListarMateria();
        }

        public static DataTable Buscar(string Valor)
        {
            DMateria Datos = new DMateria();
            return Datos.BuscarMateria(Valor);
        }

        public static string Insertar(string nombreMateria)
        {
            DMateria Datos = new DMateria();
            string Existe = Datos.ExisteMateria(nombreMateria);
            if (Existe.Equals("1"))
            {
                return "La materia ya existe";
            }
            else
            {
                Materia Obj = new Materia();
                Obj.nombreMateria = nombreMateria;
                return Datos.InsertarMateria(Obj); //retorna los datos a insertar
            }

        }

        public static string Actualizar(int codigoMateria, string nombreMateria)
        {
            DMateria Datos = new DMateria();
            Materia Obj = new Materia();
            Obj.codigoMateria = codigoMateria;
            Obj.nombreMateria = nombreMateria;
            return Datos.ActualizarMateria(Obj);
        }

        public static string Eliminar(int codigoMateria)
        {
            DMateria Datos = new DMateria();
            return Datos.EliminarMateria(codigoMateria);
        }
    }
}
