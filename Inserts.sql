DELETE FROM rol   
DBCC CHECKIDENT ('ROL', RESEED, 0)  
DELETE FROM usuario   
DBCC CHECKIDENT ('usuario', RESEED, 0)  
DELETE FROM editorial   
DBCC CHECKIDENT ('editorial', RESEED, 0)  
DELETE FROM materia   
DBCC CHECKIDENT ('materia', RESEED, 0)
DELETE FROM pais   
DBCC CHECKIDENT ('pais', RESEED, 0)
DELETE FROM libro   
DBCC CHECKIDENT ('libro', RESEED, 0)
DELETE FROM PRESTAMO   
DBCC CHECKIDENT ('Prestamo', RESEED, 0)
DELETE FROM TIPO
DBCC CHECKIDENT ('tipo', RESEED, 0)
DELETE FROM VIDEO   
DBCC CHECKIDENT ('video', RESEED, 0)
DELETE FROM PRESTAMO_VIDEO   
DBCC CHECKIDENT ('prestamo_video', RESEED, 0)

INSERT INTO rol(rol, estado, admin) VALUES ('Admin', 1, 1),('Porfa', 1,0);
INSERT INTO usuario(email, contrasenia, nombre, apellido, direccion, id_rol) VALUES('admin@email.com', 'admin', 'Francisco', 'Pouzeaud', 'Direccion falsa', 1), ('admin1@email.com', 'admin', 'Cecilia', 'Salguero', 'Direccion falsa', 1 ),('profesor@email.com', 'profesor', 'Gabriel', 'Gonzalez', 'Direccion falsa', 2),('profesor1@email.com', 'profesor', 'Juan', 'Perez', 'Direccion falsa',2 )
INSERT INTO EDITORIAL(nombre) values('La ceiba'), ('Santillana'), ('Conquistador')
INSERT INTO MATERIA(nombre) values('Estudios Sociales'), ('Ciencias'), ('Matematica'), ('Lenguaje')
INSERT INTO	PAIS(nombre) values('El Salvador'), ('Mexico'), ('Japon')
INSERT INTO LIBRO (titulo, isbn, npaginas, idioma, autor, n_ejemplares,anio_edicion, descripcion, n_edicion, ejemplar, ubicacion, id_editorial, id_pais, id_materia, activo) 
values ('Historia de El Salvador', 1234567, 456, 'Español', 'Juan', 5, 2002, 'Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto.', 5, 1, 'Primera Planta', 1, 1, 1, 1),
	   ('Biologia 1', 4345355, 1009, 'Ingles', 'Carlos', 4, 2003, 'Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto.', 3, 3, 'Primera Planta', 1, 1, 2, 1),
	   ('Algebra Vectorial y Matrices', 4938494, 555, 'Español', 'Bodoque', 10, 2021, 'Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto.', 2, 4, 'Segunda Planta', 2, 2, 3, 1),
	   ('Japones Para Principiantes', 8976633, 123, 'Japones', 'Tulio', 9, 2010, 'Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto.', 8, 7, 'Tercera Planta', 3, 3, 4, 1)
INSERT INTO PRESTAMO(codigo_usuario, codigo_libro, fecha_prestamo , fecha_devolucion, devuelto) values (3,1, '05-05-2021','05-06-2021', 1), (4,2, '04-05-2021','04-06-2021', 1)
INSERT INTO TIPO(nombre)values('DVD'), ('Blue Ray')
INSERT INTO VIDEO(titulo, directo, productora, codigo_tipo, anio, duracion, idiomas, subtitulos, sinopsis, ubicacion, activo)VALUES('Harry Potter y la Orden del Fenix', 'David Yates', 'Warner Bros', 1, 2007, '2 horas', 'Ingles, Español','Ingles, Español' , 'Lorem ipsum', 'Primera Planta', 1), ('El Señor de los Anillos', 'Peter Jackson', 'Warner Bros', 2, 2001, '3 horas', 'Ingles, Español','Ingles, Español' , 'Lorem ipsum', 'Segunda Planta', 1)
INSERT INTO PRESTAMO_VIDEO(codigo_usuario, codigo_video, fecha_prestamo , fecha_devolucion, devuelto) values (3,1, '05-05-2021','05-06-2021', 1), (4,2, '04-05-2021','04-06-2021', 1)
