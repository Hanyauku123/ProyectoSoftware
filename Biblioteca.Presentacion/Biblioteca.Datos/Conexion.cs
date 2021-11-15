using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class Conexion
    {
        private string Base; //Nombre de la base de datos a la que se conectará
        private string Servidor; //Indica el nombre del servidor 
        private string Usuario; //Usuario que accederá a la base de datos 
        private string Clave; //Clave del usuario que se conectará a la base 
        private bool Seguridad; //Definirá la seguridad de como se manejará el programa

        private static Conexion Con = null; //Instancia de la clase conexion

        private Conexion() //constructor
        {
            this.Base = "ProyectoSoftware"; //Nombre de la base 
            this.Servidor = "DESKTOP-I9NCQ91"; //Nombre del servidor
            this.Usuario = "sa"; //Usuario de la base de datos
            this.Clave = "gaby123"; //Clave del usuario a la base de datos
            this.Seguridad = true;  //Indicamos que se ocupará la Autentificación de Windows
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            //La coneccion de la base de datos estará dentro de un try catch, 
            //por si sucede algún error
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";"; //metodo que est'a heredando de la clase Sqlconnection
                if (this.Seguridad) //Seguridad de Windows
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI"; //Integracion de la seguridad de Windows, para base de datos SQL Server
                }
                else //Seguridad SQL Server
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id =" + this.Usuario + "; Password =" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex; // Se captura el error 
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null) //Indica que no se tiene una instancia
            {
                Con = new Conexion(); //Crea la instancia
            }
            return Con; // retorna la instancia
        }

    }

}