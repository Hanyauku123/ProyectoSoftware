using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Biblioteca.Entidades;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class DLibro
    {
        public DataTable ListarLibro()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("listar_libro", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable ListarUpdate(string valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("buscar_libroUpdate", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }


        public DataTable BuscarLibro(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("buscar_libro", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string InsertarLibro(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("insertar_libro", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.tituloLibro;
                Comando.Parameters.Add("@isbn", SqlDbType.VarChar).Value = Obj.isbn;
                Comando.Parameters.Add("@npaginas", SqlDbType.Int).Value = Obj.nPaginas;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idiomaLibro;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.autor;
                Comando.Parameters.Add("@n_ejemplares", SqlDbType.Int).Value = Obj.nEjemplares;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.DateTime).Value = Obj.anioEdicion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                Comando.Parameters.Add("@n_edicion", SqlDbType.Int).Value = Obj.nEdicion;
                Comando.Parameters.Add("@ejemplar", SqlDbType.VarChar).Value = Obj.ejemplar;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@id_editorial", SqlDbType.Int).Value = Obj.idEditorial;
                Comando.Parameters.Add("@id_pais", SqlDbType.Int).Value = Obj.idPais;
                Comando.Parameters.Add("@id_materia", SqlDbType.Int).Value = Obj.idMateria;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el libro!";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string ActualizarLibro(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("actualizar_libro", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = Obj.codigoLibro;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.tituloLibro;
                Comando.Parameters.Add("@isbn", SqlDbType.VarChar).Value = Obj.isbn;
                Comando.Parameters.Add("@npaginas", SqlDbType.Int).Value = Obj.nPaginas;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idiomaLibro;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.autor;
                Comando.Parameters.Add("@n_ejemplares", SqlDbType.Int).Value = Obj.nEjemplares;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.DateTime).Value = Obj.anioEdicion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                Comando.Parameters.Add("@n_edicion", SqlDbType.Int).Value = Obj.nEdicion;
                Comando.Parameters.Add("@ejemplar", SqlDbType.VarChar).Value = Obj.ejemplar;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@id_editorial", SqlDbType.Int).Value = Obj.idEditorial;
                Comando.Parameters.Add("@id_pais", SqlDbType.Int).Value = Obj.idPais;
                Comando.Parameters.Add("@id_materia", SqlDbType.Int).Value = Obj.idMateria;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el libro!";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string EliminarLibro(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("eliminar_libro", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = Id;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el libro!";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string ExisteLibro(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
