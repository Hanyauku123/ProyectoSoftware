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
    public class DVideo
    {
        public DataTable ListarVideo()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("listar_video", SqlCon);
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
                SqlCommand Comando = new SqlCommand("buscar_videoUpdate", SqlCon);
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

        public DataTable BuscarVideo(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("buscar_video", SqlCon);
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

        public string InsertarVideo(Video Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("insertar_video", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.tituloVideo;
                Comando.Parameters.Add("@duracion", SqlDbType.VarChar).Value = Obj.duracion;
                Comando.Parameters.Add("@idiomas", SqlDbType.VarChar).Value = Obj.idiomas;
                Comando.Parameters.Add("@subtitulos", SqlDbType.VarChar).Value = Obj.subtitulos;
                Comando.Parameters.Add("@sinopsis", SqlDbType.VarChar).Value = Obj.sinopsis;
                Comando.Parameters.Add("@anio", SqlDbType.DateTime).Value = Obj.anio;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@directo", SqlDbType.VarChar).Value = Obj.director;
                Comando.Parameters.Add("@productora", SqlDbType.VarChar).Value = Obj.productora;
                Comando.Parameters.Add("@codigo_tipo", SqlDbType.Int).Value = Obj.codigo_tipo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el vídeo!";
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

        public string ActualizarVideo(Video Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("actualizar_video", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = Obj.codigoVideo;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.tituloVideo;
                Comando.Parameters.Add("@duracion", SqlDbType.VarChar).Value = Obj.duracion;
                Comando.Parameters.Add("@idiomas", SqlDbType.VarChar).Value = Obj.idiomas;
                Comando.Parameters.Add("@subtitulos", SqlDbType.VarChar).Value = Obj.subtitulos;
                Comando.Parameters.Add("@sinopsis", SqlDbType.VarChar).Value = Obj.sinopsis;
                Comando.Parameters.Add("@anio", SqlDbType.DateTime).Value = Obj.anio;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@directo", SqlDbType.VarChar).Value = Obj.director;
                Comando.Parameters.Add("@productora", SqlDbType.VarChar).Value = Obj.productora;
                Comando.Parameters.Add("@codigo_tipo", SqlDbType.Int).Value = Obj.codigo_tipo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el video!";
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

        public string EliminarVideo(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("eliminar_video", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = Id;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el vídeo!";
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

        public string ExisteVideo(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("video_existe", SqlCon);
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
