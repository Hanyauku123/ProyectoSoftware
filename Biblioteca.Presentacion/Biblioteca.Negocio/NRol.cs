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
    public class NRol
    {
        public static DataTable Listar()
        {
            DRol Datos = new DRol();
            return Datos.ListarRol();
        }

        public static DataTable Buscar(string Valor)
        {
            DRol Datos = new DRol();
            return Datos.BuscarRol(Valor);
        }

        public static string Insertar(string rol, bool estado)
        {
            DRol Datos = new DRol();
            string Existe = Datos.ExisteRol(rol);
            if (Existe.Equals("1"))
            {
                return "El rol ya existe";
            }
            else
            {
                Rol Obj = new Rol();
                Obj.rol = rol;
                Obj.estado = estado;
                return Datos.InsertarRol(Obj); //retorna los datos a insertar
            }

        }

        public static string Actualizar(int rolId, string rol, bool estado)
        {
            DRol Datos = new DRol();
            Rol Obj = new Rol();
            Obj.rolId = rolId;
            Obj.rol = rol;
            Obj.estado = estado;
            return Datos.ActualizarRol(Obj);
        }

        public static string Eliminar(int rolId)
        {
            DRol Datos = new DRol();
            return Datos.EliminarRol(rolId);
        }
    }
}
