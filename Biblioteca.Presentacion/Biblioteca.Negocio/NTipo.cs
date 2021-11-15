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
    public class NTipo
    {
        public static DataTable Listar()
        {
            DTipo Datos = new DTipo();
            return Datos.ListarTipo();
        }

        public static DataTable Buscar(string Valor)
        {
            DTipo Datos = new DTipo();
            return Datos.BuscarTipo(Valor);
        }

        public static string Insertar(string nombreTipo)
        {
            DTipo Datos = new DTipo();
            string Existe = Datos.ExisteTipo(nombreTipo);
            if (Existe.Equals("1"))
            {
                return "El tipo de vídeo ya existe";
            }
            else
            {
                Tipo Obj = new Tipo();
                Obj.nombreTipo = nombreTipo;
                return Datos.InsertarTipo(Obj); //retorna los datos a insertar
            }

        }

        public static string Actualizar(int codigoTipo, string nombreTipo)
        {
            DTipo Datos = new DTipo();
            Tipo Obj = new Tipo();
            Obj.codigoTipo = codigoTipo;
            Obj.nombreTipo = nombreTipo;
            return Datos.ActualizarTipo(Obj);
        }

        public static string Eliminar(int codigoTipo)
        {
            DTipo Datos = new DTipo();
            return Datos.EliminarTipo(codigoTipo);
        }
    }
}
