CREATE DATABASE ProyectoFinalNcapas
USE ProyectoFinalNcapas
--CREACION DE TABLAS CON SUS LLAVES PRIMARIAS--

CREATE TABLE LIBRO(
	codigo int primary key identity not null,
	titulo varchar(50),
	isbn varchar(30),
	npaginas int,
	idioma varchar(10),
	autor varchar(200),
	n_ejemplares int,
	anio_edicion datetime,
	descripcion text,
	n_edicion int,
	ejemplar varchar(100),
	ubicacion varchar(100),
	id_editorial int,
	id_pais int,
	id_materia int, 
	activo bit
);

CREATE TABLE PAIS(
	codigo int primary key identity not null,
	nombre varchar(20)
);

CREATE TABLE MATERIA(
	codigo int primary key identity not null,
	nombre varchar(20)
);

CREATE TABLE EDITORIAL(
	codigo int primary key identity not null,
	nombre varchar(50)
);

CREATE TABLE PRESTAMO(
	codigo_prestamo int primary key not null,
	codigo_libro int,
	codigo_usuario int,
	fecha_prestamo DATETIME,
	fecha_devolucion DATETIME,
	devuelto bit
);

CREATE TABLE USUARIO(
	codigo int primary key identity not null,
	email varchar(100),
	contrasenia varchar(100),
	nombre varchar(50),
	apellido varchar (50),
	direccion varchar(100),
	id_rol int,
	estado bit
);

CREATE TABLE PRESTAMO_VIDEO(
	codigo_prestamo_video int primary key not null,
	codigo_video int,
	codigo_usuario int,
	fecha_prestamo DATETIME,
	fecha_devolucion DATETIME,
	devuelto bit
);

CREATE TABLE VIDEO(
	codigo int primary key identity not null,
	titulo varchar(50),
	duracion varchar (10),
	idiomas varchar(20),
	subtitulos varchar(20),
	sinopsis varchar(200),
	anio datetime,
	ubicacion varchar(100),
	directo varchar(100),
	productora varchar(100),
	activo bit,
	codigo_tipo int 
);

CREATE TABLE TIPO(
	codigo int primary key identity not null,
	nombre varchar(50)
);

CREATE TABLE ROL(
	codigo int primary key identity not null,
	rol varchar(100)
)

--CREANDO LAS LLAVES FORANEAS--



ALTER TABLE LIBRO 
ADD CONSTRAINT FK_LIBRO_EDITORIAL 
FOREIGN KEY (id_editorial) REFERENCES EDITORIAL (codigo);

ALTER TABLE LIBRO 
ADD CONSTRAINT FK_LIBRO_PAIS 
FOREIGN KEY (id_pais) REFERENCES PAIS (codigo);

ALTER TABLE LIBRO 
ADD CONSTRAINT FK_LIBRO_MATERIA 
FOREIGN KEY (id_materia) REFERENCES MATERIA (codigo);

ALTER TABLE PRESTAMO 
ADD CONSTRAINT FK_PRESTAMO_LIBRO
FOREIGN KEY (codigo_libro) REFERENCES LIBRO (codigo);

ALTER TABLE PRESTAMO 
ADD CONSTRAINT FK_PRESTAMO_USUARIO 
FOREIGN KEY (codigo_usuario) REFERENCES USUARIO (codigo);

ALTER TABLE PRESTAMO_VIDEO
ADD CONSTRAINT FK_VIDEO_VIDEO
FOREIGN KEY (codigo_video) REFERENCES VIDEO (codigo);

ALTER TABLE PRESTAMO_VIDEO
ADD CONSTRAINT FK_VIDEO_USUARIO
FOREIGN KEY (codigo_usuario) REFERENCES USUARIO (codigo);

ALTER TABLE VIDEO
ADD CONSTRAINT FK_VIDEO_TIPO
FOREIGN KEY (codigo_tipo) REFERENCES TIPO (codigo);

ALTER TABLE USUARIO
ADD CONSTRAINT FK_USUARIO_ROL
FOREIGN KEY (id_rol) REFERENCES ROL (codigo);


--Procedimientos Listar

create proc editorial_listar
as 
select codigo,nombre from EDITORIAL 
go

create proc tipo_listar
as 
select codigo,nombre from TIPO 
go

create proc pais_listar
as 
select codigo,nombre from PAIS 
go

create proc materia_listar
as 
select codigo,nombre from MATERIA 
go

create proc listar_libro
as
select l.codigo as Codigo, l.titulo as Titulo,l.autor as Autor ,l.isbn as ISBN, l.npaginas as 'Numero_de_Paginas', m.nombre as Materia , l.idioma as Idioma, l.n_ejemplares as 'Numero_de_Ejemplares', n_edicion as 'Numero_de_Edicion', YEAR(l.anio_edicion) as 'Anio_de_Edicion', l.ubicacion as Ubicacion, e.nombre as Editorial, p.nombre as Pais
from libro l
INNER JOIN PAIS p
ON p.codigo = l.id_pais
INNER JOIN MATERIA m
ON m.codigo = l.id_pais
INNER JOIN EDITORIAL e
ON e.codigo = l.id_editorial
WHERE l.activo = 1
order by l.codigo desc
go

create proc listar_video
as
select v.codigo as Codigo, v.titulo as Titulo,v.directo as Director , v.productora as Productora, t.nombre as Tipo, v.duracion as Duracion, v.idiomas as Idiomas, v.subtitulos as Subtitulos, v.sinopsis as Sipnosis ,YEAR(v.anio) as Año 
from video v
INNER JOIN TIPO t
ON t.codigo = v.codigo_tipo
WHERE v.activo = 1
order by v.codigo desc
go

create proc listar_prestamoLibro
as
select  p.codigo_prestamo as Codigo, l.titulo as Libro,	CONCAT(u.nombre, ' ', u.apellido ) as Usuario, p.fecha_prestamo as 'Fecha_de_Prestamo', p.fecha_devolucion as 'Fecha_de_Devolucion', p.devuelto as Devuelto
from PRESTAMO p
INNER JOIN LIBRO l
ON p.codigo_libro = l.codigo
INNER JOIN USUARIO u
ON p.codigo_usuario = u.codigo
order by p.codigo_prestamo desc
go


create proc listar_prestamoVideo
as
select  pv.codigo_prestamo_video as Codigo, v.titulo as Video,	CONCAT(u.nombre, ' ', u.apellido ) as Usuario, pv.fecha_prestamo as 'Fecha_de_Prestamo', pv.fecha_devolucion as 'Fecha_de_Devolucion', pv.devuelto as Devuelto
from PRESTAMO_VIDEO pv
INNER JOIN VIDEO v
ON pv.codigo_video = v.codigo
INNER JOIN USUARIO u
ON pv.codigo_usuario = u.codigo
order by pv.codigo_prestamo_video desc
go


--Procedimientos Buscar
create proc buscar_libro
@valor varchar(50)
as
select l.codigo as Codigo, l.titulo as Titulo,l.autor as Autor ,l.isbn as ISBN, l.npaginas as 'Numero de Paginas', m.nombre as Materia , l.idioma as Idioma, l.n_ejemplares as 'Numero de Ejemplares', n_edicion as 'Numero de Edicion', YEAR(l.anio_edicion) as 'Año de Edicion', l.ubicacion as Ubicacion, e.nombre as Editorial, p.nombre as Pais
from libro l
INNER JOIN PAIS p
ON p.codigo = l.id_pais
INNER JOIN MATERIA m
ON m.codigo = l.id_pais
INNER JOIN EDITORIAL e
ON e.codigo = l.id_editorial
WHERE l.titulo like '%' + @valor + '%' or l.descripcion like '%' + @valor + '%' or l.autor like '%' + @valor + '%' or e.nombre like '%' + @valor + '%'and activo = 1
order by l.titulo asc
go


create proc buscar_libroUpdate
@valor varchar(50)
as
select codigo,titulo, isbn, npaginas, idioma, autor, n_ejemplares, YEAR(anio_edicion), descripcion, n_edicion, ejemplar, ubicacion, id_editorial, id_pais, id_materia from libro
WHERE titulo = @valor and activo = 1
order by titulo
go

create proc buscar_videoUpdate
@valor varchar(50)
as
select codigo, titulo, directo, productora, codigo_tipo, YEAR(anio), duracion, idiomas, subtitulos, sinopsis, ubicacion from video
WHERE titulo = @valor and activo = 1
order by titulo asc
go

create proc buscar_video
@valor varchar(50)
as
select v.codigo as Codigo, v.titulo as Titulo,v.directo as Director , v.productora as Productora, t.nombre as Tipo, v.duracion as Duracion, v.idiomas as Idiomas, v.subtitulos as Subtitulos, v.sinopsis as Sipnosis ,YEAR(v.anio) as Año 
from video v
INNER JOIN TIPO t
ON t.codigo = v.codigo_tipo
WHERE v.titulo like '%' + @valor + '%' or v.sinopsis like '%' + @valor + '%' or v.directo like '%' + @valor + '%' or v.productora like '%' + @valor + '%' and v.activo = 1
order by v.titulo asc
go

create proc buscar_prestamoLibro
@valor varchar(50)
as
select  p.codigo_prestamo as Codigo, l.titulo as Libro,	CONCAT(u.nombre, ' ', u.apellido ) as Usuario, p.fecha_prestamo as 'Fecha de Prestamo', p.fecha_devolucion as 'Fecha de Devolucion', p.devuelto as Devuelto
from PRESTAMO p
INNER JOIN LIBRO l
ON p.codigo_libro = l.codigo
INNER JOIN USUARIO u
ON p.codigo_usuario = u.codigo
WHERE l.codigo = @valor or  l.titulo like '%' + @valor + '%' or u.nombre like '%' + @valor + '%'or u.apellido like '%' + @valor + '%' or u.email like '%' + @valor + '%' or l.titulo like '%' + @valor + '%'
order by l.titulo asc
go


create proc buscar_prestamoLibroEliminar
@valor varchar(50)
as
select  p.codigo_prestamo as Codigo, l.titulo as Libro,	CONCAT(u.nombre, ' ', u.apellido ) as Usuario, p.fecha_prestamo as 'Fecha de Prestamo', p.fecha_devolucion as 'Fecha de Devolucion', p.devuelto as Devuelto
from PRESTAMO p
INNER JOIN LIBRO l
ON p.codigo_libro = l.codigo
INNER JOIN USUARIO u
ON p.codigo_usuario = u.codigo
WHERE l.codigo = @valor or  l.titulo like '%' + @valor + '%' or u.nombre like '%' + @valor + '%'or u.apellido like '%' + @valor + '%' or u.email like '%' + @valor + '%' or l.titulo like '%' + @valor + '%' AND P.devuelto = 0
order by l.titulo asc
go



create proc usuario_login
@clave varchar(50),
@email varchar(50)
as
SELECT r.admin
from USUARIO u
INNER JOIN ROL r
ON u.id_rol =r.codigo
WHERE email = @email and u.contrasenia=@clave
go


create proc buscar_prestamoVideoEliminar
@valor varchar(50)
as
select  pv.codigo_prestamo_video as Codigo, v.titulo as Video,	CONCAT(u.nombre, ' ', u.apellido ) as Usuario, pv.fecha_prestamo as 'Fecha de Prestamo', pv.fecha_devolucion as 'Fecha de Devolucion', pv.devuelto as Devuelto
from PRESTAMO_VIDEO pv
INNER JOIN VIDEO v
ON pv.codigo_video = v.codigo
INNER JOIN USUARIO u
ON pv.codigo_usuario = u.codigo
WHERE v.codigo = @valor or v.titulo like '%' + @valor + '%' or u.nombre like '%' + @valor + '%'or u.apellido like '%' + @valor + '%'or v.titulo like '%' + @valor + '%' AND pv.devuelto = 0
order by v.titulo asc
go

create proc buscar_prestamoVideo
@valor varchar(50)
as
select  pv.codigo_prestamo_video as Codigo, v.titulo as Video,	CONCAT(u.nombre, ' ', u.apellido ) as Usuario, pv.fecha_prestamo as 'Fecha de Prestamo', pv.fecha_devolucion as 'Fecha de Devolucion', pv.devuelto as Devuelto
from PRESTAMO_VIDEO pv
INNER JOIN VIDEO v
ON pv.codigo_video = v.codigo
INNER JOIN USUARIO u
ON pv.codigo_usuario = u.codigo
WHERE v.codigo = @valor or v.titulo like '%' + @valor + '%' or u.nombre like '%' + @valor + '%'or u.apellido like '%' + @valor + '%'or v.titulo like '%' + @valor + '%' 
order by v.titulo asc
go

create proc prestamo_existe
@codigo int
as
SELECT * FROM PRESTAMO WHERE codigo_libro = @codigo AND devuelto = 0
go

create proc prestamoVideo_existe
@codigo int
as
SELECT * FROM PRESTAMO_VIDEO WHERE codigo_video = @codigo AND devuelto = 0
go

create proc buscar_usuario
@valor varchar(50)
as
SELECT u.codigo as Codigo , u.email as Email, u.nombre as Nombre, u.apellido as Apellido, u.direccion as Direccion
from USUARIO u
WHERE u.email like '%' + @valor + '%' or u.nombre like '%' + @valor + '%'or u.apellido like '%' + @valor + '%'
go

--Procedimiento Insertar
create proc insertar_libro
    @titulo varchar(50),
    @isbn varchar(30),
	@npaginas int,
    @idioma varchar(10),
    @autor varchar(200),
    @n_ejemplares int,
    @anio_edicion datetime,
	@descripcion text,
    @n_edicion int,
	@ejemplar varchar(100),
	@ubicacion varchar(100),
	@id_editorial int,
	@id_pais int,
	@id_materia int
 
as
insert into libro(titulo, isbn, npaginas, idioma, autor, n_ejemplares,anio_edicion, descripcion, n_edicion, ejemplar, ubicacion, id_editorial, id_pais, id_materia, activo) 
values (@titulo, @isbn, @npaginas, @idioma, @autor, @n_ejemplares, YEAR(@anio_edicion), @descripcion, @n_edicion, @ejemplar, @ubicacion, @id_editorial, @id_pais, @id_materia, 1)
go

CREATE PROCEDURE insertar_video
    @titulo varchar(50),
    @duracion varchar(10),
	@idiomas varchar(20),
	@subtitulos varchar(20),
	@sinopsis varchar(200),
	@anio datetime,
	@ubicacion varchar(100),
	@directo varchar(100),
	@productora varchar(100),
	@codigo_tipo int
    AS
    INSERT INTO video(titulo, directo, productora, codigo_tipo, anio, duracion, idiomas, subtitulos, sinopsis, ubicacion, activo)
        VALUES (@titulo, @directo, @productora, @codigo_tipo, YEAR(@anio), @duracion, @idiomas, @subtitulos, @sinopsis, @ubicacion, 1)
    GO


create proc insertar_prestamoLibro
    @codigo_libro int,
	@codigo_usuario int,
	@fecha_prestamo datetime,
	@fecha_devolucion datetime
 
as
insert into PRESTAMO(codigo_libro, codigo_usuario, fecha_prestamo, fecha_devolucion, devuelto) 
values (@codigo_libro, @codigo_usuario, @fecha_prestamo, @fecha_devolucion, 0)
go


create proc insertar_prestamoVideo
    @codigo_video int,
	@codigo_usuario int,
	@fecha_prestamo datetime,
	@fecha_devolucion datetime
 
as
insert into PRESTAMO_VIDEO(codigo_video, codigo_usuario, fecha_prestamo, fecha_devolucion, devuelto) 
values (@codigo_video, @codigo_usuario, @fecha_prestamo, @fecha_devolucion, 0)
go

--Procedimiento Actualizar
create proc actualizar_libro
		
    @codigo int,
	@titulo varchar(50),
    @isbn varchar(30),
	@npaginas int,
    @idioma varchar(10),
    @autor varchar(200),
    @n_ejemplares int,
    @anio_edicion datetime,
	@descripcion text,
    @n_edicion int,
	@ejemplar varchar(100),
	@ubicacion varchar(100),
	@id_editorial int,
	@id_pais int,
	@id_materia int
    AS
    update libro set titulo=@titulo, isbn=@isbn, npaginas=@npaginas, idioma=@idioma, autor=@autor, n_ejemplares=@n_ejemplares,
	anio_edicion=@anio_edicion, descripcion=@descripcion, n_edicion=@n_edicion, ejemplar=@ejemplar, ubicacion=@ubicacion, id_editorial=@id_editorial,
	id_pais=@id_pais, id_materia=@id_materia
    where codigo=@codigo
    go


	CREATE PROCEDURE actualizar_video
	@codigo int,
    @titulo varchar(50),
    @duracion varchar(10),
	@idiomas varchar(20),
	@subtitulos varchar(20),
	@sinopsis varchar(200),
	@anio datetime,
	@ubicacion varchar(100),
	@directo varchar(100),
	@productora varchar(100),
	@codigo_tipo int
    AS
    update video set titulo=@titulo, directo=@directo, productora=@productora, codigo_tipo=@codigo_tipo, anio=@anio, duracion=@duracion, idiomas=@idiomas, subtitulos=@subtitulos, sinopsis=@sinopsis, ubicacion=@ubicacion
    where codigo=@codigo
	GO


	create proc actualizar_prestamoLibro
	@codigo_prestamo int,
    @codigo_libro int,
	@codigo_usuario int,
	@fecha_prestamo datetime,
	@fecha_devolucion datetime,
	@devuelto bit
 
as
update PRESTAMO set codigo_libro=@codigo_libro, codigo_usuario=@codigo_usuario, fecha_prestamo=@fecha_prestamo, fecha_devolucion=@fecha_devolucion, devuelto = @devuelto
where codigo_prestamo=@codigo_prestamo
go


	create proc devolver_libro
	@codigo_prestamo int
as
update PRESTAMO set  devuelto = 1
where codigo_prestamo=@codigo_prestamo
go

create proc devolver_video
	@codigo_prestamo_video int
as
update PRESTAMO_VIDEO set  devuelto = 1
where codigo_prestamo_video=@codigo_prestamo_video
go

create proc actualizar_prestamoVideo
    @codigo_prestamo_video int,
    @codigo_video int,
	@codigo_usuario int,
	@fecha_prestamo datetime,
	@fecha_devolucion datetime,
	@devuelto bit
 
as
update PRESTAMO_VIDEO set codigo_video=@codigo_video, codigo_usuario=@codigo_usuario, fecha_prestamo=@fecha_prestamo, fecha_devolucion = @fecha_devolucion, devuelto = @devuelto
where codigo_prestamo_video=@codigo_prestamo_video
go
--Procedimiento Eliminar
create proc eliminar_libro
@codigo int
as
UPDATE LIBRO set activo = 0
where codigo=@codigo
go


create proc eliminar_video
@codigo int
as
UPDATE VIDEO set activo = 0
where codigo=@codigo
go

create proc eliminar_prestamoLibro
@codigo int
as
delete from PRESTAMO
where codigo_prestamo=@codigo
go

create proc eliminar_prestamoVideo
@codigo int
as
delete from PRESTAMO_VIDEO
where codigo_prestamo_video=@codigo
go