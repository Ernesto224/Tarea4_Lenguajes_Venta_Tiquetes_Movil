use Alexa_Tarea3_Lenguajes_2024
GO

create table usuario(
	idUsuario int primary key identity,
	nombre nvarchar(20),
	apellido nvarchar(30),
	fechaNacimiento date,
	correoElectronico nvarchar(30),
	contrasenia nvarchar(18)
)

create table concierto(
	idConcierto int primary key identity,
	imagenArtista nvarchar(200),
	nombreArtista nvarchar(30),
	fechaEvento datetime,
	ubicacionConcierto nvarchar(200)
)

create table tipoZona(
	idTipoZona int primary key identity,
	nombreZona nvarchar(15),
	precioAsiento decimal(18,2)
)

create table asiento(
	idAsiento int primary key identity,
	codigoAsiento nvarchar(10),
	idTipoZona int,
	idConcierto int,
	reservado bit default(0),
	constraint fk_tipoZona_asiento
	foreign key (idTipoZona)
	references tipoZona(idTipoZona),
	constraint fk_concierto_asiento
	foreign key (idConcierto)
	references concierto(idConcierto)
)

CREATE TABLE reserva (
    idUsuario INT,
    idAsiento INT,
    fechaDeCompra DATETIME,
    PRIMARY KEY (idUsuario, idAsiento),
    FOREIGN KEY (idUsuario) REFERENCES usuario(idUsuario),
    FOREIGN KEY (idAsiento) REFERENCES asiento(idAsiento)
);

--INSERTS
--------------------------------------------------------------------------------------------
--USUARIOS
INSERT INTO usuario (nombre, apellido, fechaNacimiento, correoElectronico, contrasenia)
VALUES ('Juan', 'Perez', '1990-01-15', 'juan.perez@example.com', 'password123');

INSERT INTO usuario (nombre, apellido, fechaNacimiento, correoElectronico, contrasenia)
VALUES ('Maria', 'Lopez', '1985-03-22', 'maria.lopez@example.com', 'password456');

INSERT INTO usuario (nombre, apellido, fechaNacimiento, correoElectronico, contrasenia)
VALUES ('Carlos', 'Hernandez', '1992-07-18', 'carlos.hernandez@example.com', 'password789');

INSERT INTO usuario (nombre, apellido, fechaNacimiento, correoElectronico, contrasenia)
VALUES ('Ana', 'Garcia', '1995-11-25', 'ana.garcia@example.com', 'password012');

INSERT INTO usuario (nombre, apellido, fechaNacimiento, correoElectronico, contrasenia)
VALUES ('Luis', 'Martinez', '1988-09-30', 'luis.martinez@example.com', 'password345');

--CONCIERTOS
INSERT INTO concierto (imagenArtista, nombreArtista, fechaEvento, ubicacionConcierto)
VALUES ('https://thisis-images.spotifycdn.com/37i9dQZF1DZ06evO2h1EQ0-default.jpg', 'Artista 1', '2024-07-15 20:00:00', 'Estadio Nacional');

INSERT INTO concierto (imagenArtista, nombreArtista, fechaEvento, ubicacionConcierto)
VALUES ('https://www.mondosonoro.com/wp-content/uploads/2015/03/linkin-park-899x600.jpg', 'Artista 2', '2024-08-10 19:00:00', 'Palacio de los Deportes');

INSERT INTO concierto (imagenArtista, nombreArtista, fechaEvento, ubicacionConcierto)
VALUES ('https://www.metalblade.com/us/mainpics/amon-amarth.jpg', 'Artista 3', '2024-09-05 21:00:00', 'Arena Ciudad de México');

INSERT INTO concierto (imagenArtista, nombreArtista, fechaEvento, ubicacionConcierto)
VALUES ('https://imagenes.elpais.com/resizer/v2/FIXCFAVRNRAJXLD4RKU4LAVU4U.jpg?auth=c0aada5e5522c755c79a8ea6f1bcf3fb793e246aed3e7c9d070dc0c6ac787724&width=414', 'Artista 4', '2024-10-12 18:00:00', 'Foro Sol');

--ZONAS
INSERT INTO tipoZona (nombreZona, precioAsiento)
VALUES ('VIP', 150.00);

INSERT INTO tipoZona (nombreZona, precioAsiento)
VALUES ('Diamante', 120.00);

INSERT INTO tipoZona (nombreZona, precioAsiento)
VALUES ('General', 80.00);

INSERT INTO tipoZona (nombreZona, precioAsiento)
VALUES ('Platea', 100.00);

INSERT INTO tipoZona (nombreZona, precioAsiento)
VALUES ('Gramilla', 60.00);

--ASIENTO
-- Insertar asientos en la tabla asiento
-- Concierto 1, Tipos de zona 1 a 5 (excluyendo tipo de zona 5)
INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('A1', 1, 1, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('A2', 1, 1, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('B1', 2, 1, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('B2', 2, 1, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('C1', 3, 1, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('C2', 3, 1, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('D1', 4, 1, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('D2', 4, 1, 1);

-- Concierto 2, Tipos de zona 1 a 5 (excluyendo tipo de zona 4)
INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('E1', 1, 2, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('E2', 1, 2, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('F1', 2, 2, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('F2', 2, 2, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('G1', 3, 2, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('G2', 3, 2, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('H1', 5, 2, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('H2', 5, 2, 1);

-- Concierto 3, Tipos de zona 1 a 5 (excluyendo tipo de zona 3)
INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('I1', 1, 3, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('I2', 1, 3, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('J1', 2, 3, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('J2', 2, 3, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('K1', 4, 3, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('K2', 4, 3, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('L1', 5, 3, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('L2', 5, 3, 1);

-- Concierto 4, Tipos de zona 1 a 5 (excluyendo tipo de zona 2)
INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('M1', 1, 4, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('M2', 1, 4, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('N1', 3, 4, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('N2', 3, 4, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('O1', 4, 4, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('O2', 4, 4, 1);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('P1', 5, 4, 0);

INSERT INTO asiento (codigoAsiento, idTipoZona, idConcierto, reservado)
VALUES ('P2', 5, 4, 1);
