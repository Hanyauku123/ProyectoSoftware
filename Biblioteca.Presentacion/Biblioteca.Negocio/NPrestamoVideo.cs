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
    public class NPrestamoVideo
    {
        public static DataTable Listar()
        {
            DPrestamoVideo Datos = new DPrestamoVideo();
            return Datos.ListarPrestamoVideo();
        }

        public static DataTable Buscar(string Valor)
        {
            DPrestamoVideo Datos = new DPrestamoVideo();
            return Datos.BuscarPrestamoVideo(Valor);
        }


        public static DataTable BuscarEliminar(string Valor)
        {
            DPrestamoVideo Datos = new DPrestamoVideo();
            return Datos.BuscarEliminar(Valor);
        }
        public static string Insertar(int codigo_video, int codigo_usuario, DateTime fechaPrestamoVideo, DateTime fechaDevolucionVideo)
        {
            DPrestamoVideo Datos = new DPrestamoVideo();
            DataTable Existe = Datos.ExistePrestamoVideo(codigo_video);
            if (Existe.Rows.Count > 0)
            {
                return "El prestamo ya existe";
            }
            else
            {
                Prestamo_video Obj = new Prestamo_video();
                Obj.codigo_video = codigo_video;
                Obj.codigo_usuario = codigo_usuario;
                Obj.fechaPrestamoVideo = fechaPrestamoVideo;
                Obj.fechaDevolucionVideo = fechaDevolucionVideo;
                return Datos.InsertarPrestamoVideo(Obj); //retorna los datos a insertar
            }

        }

        public static string Actualizar(int codigoPrestamoVideo, int codigo_video, int codigo_usuario, DateTime fechaPrestamoVideo, DateTime fechaDevolucionVideo)
        {
            DPrestamoVideo Datos = new DPrestamoVideo();
            Prestamo_video Obj = new Prestamo_video();
            Obj.codigoPrestamoVideo = codigoPrestamoVideo;
            Obj.codigo_video = codigo_video;
            Obj.codigo_usuario = codigo_usuario;
            Obj.fechaPrestamoVideo = fechaPrestamoVideo;
            Obj.fechaDevolucionVideo = fechaDevolucionVideo;
            return Datos.ActualizarPrestamoVideo(Obj);
        }

        public static string Devolver(int codigoPrestamoVideo)
        {
            DPrestamoVideo Datos = new DPrestamoVideo();
            return Datos.Devolver(codigoPrestamoVideo);
        }

        public static string Eliminar(int codigoPrestamoVideo)
        {
            DPrestamoVideo Datos = new DPrestamoVideo();
            return Datos.EliminarPrestamoVideo(codigoPrestamoVideo);
        }
    }
}
