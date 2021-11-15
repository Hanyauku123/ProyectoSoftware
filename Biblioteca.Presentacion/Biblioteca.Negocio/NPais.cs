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
    public class NPais
    {
        public static DataTable Listar()
        {
            DPais Datos = new DPais();
            return Datos.ListarPais();
        }

        public static DataTable Buscar(string Valor)
        {
            DPais Datos = new DPais();
            return Datos.BuscarPais(Valor);
        }

        public static string Insertar(string nombrePais)
        {
            DPais Datos = new DPais();
            string Existe = Datos.ExistePais(nombrePais);
            if (Existe.Equals("1"))
            {
                return "El país ya existe";
            }
            else
            {
                Pais Obj = new Pais();
                Obj.nombrePais = nombrePais;
                return Datos.InsertarPais(Obj); //retorna los datos a insertar
            }

        }

        public static string Actualizar(int codigoPais, string nombrePais)
        {
            DPais Datos = new DPais();
            Pais Obj = new Pais();
            Obj.codigoPais = codigoPais;
            Obj.nombrePais = nombrePais;
            return Datos.ActualizarPais(Obj);
        }

        public static string Eliminar(int codigoPais)
        {
            DPais Datos = new DPais();
            return Datos.EliminarPais(codigoPais);
        }
    }
}
