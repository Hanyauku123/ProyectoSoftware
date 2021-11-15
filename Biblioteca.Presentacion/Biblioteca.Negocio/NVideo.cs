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
    public class NVideo
    {
            public static DataTable Listar()
            {
                DVideo Datos = new DVideo();
                return Datos.ListarVideo();
            }

            public static DataTable ListarUpdate(string Valor)
            {
            DVideo Datos = new DVideo();
            return Datos.ListarUpdate(Valor);
            }

        public static DataTable Buscar(string Valor)
            {
                DVideo Datos = new DVideo();
                return Datos.BuscarVideo(Valor);
            }

            public static string Insertar(string tituloVideo, string duracion, string idiomas, string subtitulos, string sinopsis, DateTime anio, string ubicacion, string director, string productora, int codigo_tipo)
            {
                
                DVideo Datos = new DVideo();
                DataTable Existe = Datos.BuscarVideo(tituloVideo);
                if (Existe.Rows.Count > 0)
                {
                    return "El usuario ya existe";
                }
                else
                {
                    Video Obj = new Video();
                    Obj.tituloVideo = tituloVideo;
                    Obj.duracion = duracion;
                    Obj.idiomas = idiomas;
                    Obj.subtitulos = subtitulos;
                    Obj.sinopsis = sinopsis;
                    Obj.anio = anio;
                    Obj.ubicacion = ubicacion;
                    Obj.director = director;
                    Obj.productora = productora;
                    Obj.codigo_tipo = codigo_tipo;
                    return Datos.InsertarVideo(Obj); //retorna los datos a insertar
                }

            }

            public static string Actualizar(int codigoVideo, string tituloVideo, string duracion, string idiomas, string subtitulos, string sinopsis, DateTime anio, string ubicacion, string director, string productora, int codigo_tipo)
            {
                DVideo Datos = new DVideo();
                Video Obj = new Video();
                Obj.codigoVideo = codigoVideo;
                Obj.tituloVideo = tituloVideo;
                Obj.duracion = duracion;
                Obj.idiomas = idiomas;
                Obj.subtitulos = subtitulos;
                Obj.sinopsis = sinopsis;
                Obj.anio = anio;
                Obj.ubicacion = ubicacion;
                Obj.director = director;
                Obj.productora = productora;
                Obj.codigo_tipo = codigo_tipo;
                return Datos.ActualizarVideo(Obj);
            }

            public static string Eliminar(int codigoVideo)
            {
                DVideo Datos = new DVideo();
                return Datos.EliminarVideo(codigoVideo);
            }
        }
    
}
