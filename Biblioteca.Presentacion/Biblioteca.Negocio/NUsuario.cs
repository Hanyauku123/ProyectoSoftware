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
    public class NUsuario
    {
        public static DataTable Login(string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Login(Email, Clave);
        }
        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.ListarUsuario();
        }

        public static DataTable Buscar(string Valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.BuscarUsuario(Valor);
        }

        public static string Insertar(string email, string contrasenia, string nombreUsuario, string apellidoUsuario, string direccion)
        {
            DUsuario Datos = new DUsuario();
            string Existe = Datos.ExisteUsuario(email);
            if (Existe.Equals("1"))
            {
                return "El usuario ya existe";
            }
            else
            {
                Usuario Obj = new Usuario();
                Obj.email = email;
                Obj.contrasenia = contrasenia;
                Obj.nombreUsuario = nombreUsuario;
                Obj.apellidoUsuario = apellidoUsuario;
                Obj.direccion = direccion;
                return Datos.InsertarUsuario(Obj); //retorna los datos a insertar
            }

        }

        public static string Actualizar(int codigoUsuario, string email, string contrasenia, string nombreUsuario, string apellidoUsuario, string direccion)
        {
            DUsuario Datos = new DUsuario();
            Usuario Obj = new Usuario();
            Obj.codigoUsuario = codigoUsuario;
            Obj.email = email;
            Obj.contrasenia = contrasenia;
            Obj.nombreUsuario = nombreUsuario;
            Obj.apellidoUsuario = apellidoUsuario;
            Obj.direccion = direccion;
            return Datos.ActualizarUsuario(Obj);
        }

        public static string Eliminar(int codigoUsuario)
        {
            DUsuario Datos = new DUsuario();
            return Datos.EliminarUsuario(codigoUsuario);
        }
    }
}
