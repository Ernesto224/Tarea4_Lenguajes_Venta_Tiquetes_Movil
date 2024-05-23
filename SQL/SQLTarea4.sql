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
	numeroAsiento int,
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

create table boleto(
	idBoleto int primary key identity,
	idAsiento int,
	idConcierto int,
	constraint fk_concierto_boleto
	foreign key (idConcierto)
	references concierto(idConcierto),
	constraint fk_asiento_boleto
	foreign key (idAsiento)
	references asiento(idAsiento)
)

create table reserva(
	idUsuario int,
	idBoleto int,
	constraint fk_usuario_reserva
	foreign key (idUsuario)
	references usuario(idUsuario),
	constraint fk_boleto_reserva
	foreign key (idBoleto)
	references boleto(idBoleto),
	primary key(idUsuario, idBoleto)
)

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
-- Asientos para concierto 1
DECLARE @i INT = 1;
WHILE @i <= 30
BEGIN
    INSERT INTO asiento (numeroAsiento, idTipoZona, idConcieto, reservado)
    VALUES (@i, CASE 
                  WHEN @i <= 5 THEN 1 -- VIP
                  WHEN @i <= 10 THEN 2 -- Diamante
                  WHEN @i <= 15 THEN 3 -- General
                  WHEN @i <= 20 THEN 4 -- Platea
                  ELSE 5 -- Gramilla
                END, 1, 0);
    SET @i = @i + 1;
END;

-- Asientos para concierto 2
DECLARE @j INT = 1;
WHILE @j <= 30
BEGIN
    INSERT INTO asiento (numeroAsiento, idTipoZona, idConcieto, reservado)
    VALUES (@j, CASE 
                  WHEN @j <= 5 THEN 1 -- VIP
                  WHEN @j <= 10 THEN 2 -- Diamante
                  WHEN @j <= 15 THEN 3 -- General
                  WHEN @j <= 20 THEN 4 -- Platea
                  ELSE 5 -- Gramilla
                END, 2, 0);
    SET @j = @j + 1;
END;

-- Asientos para concierto 3
DECLARE @k INT = 1;
WHILE @k <= 30
BEGIN
    INSERT INTO asiento (numeroAsiento, idTipoZona, idConcieto, reservado)
    VALUES (@k, CASE 
                  WHEN @k <= 5 THEN 1 -- VIP
                  WHEN @k <= 10 THEN 2 -- Diamante
                  WHEN @k <= 15 THEN 3 -- General
                  WHEN @k <= 20 THEN 4 -- Platea
                  ELSE 5 -- Gramilla
                END, 3, 0);
    SET @k = @k + 1;
END;

-- Asientos para concierto 4
DECLARE @l INT = 1;
WHILE @l <= 30
BEGIN
    INSERT INTO asiento (numeroAsiento, idTipoZona, idConcieto, reservado)
    VALUES (@l, CASE 
                  WHEN @l <= 5 THEN 1 -- VIP
                  WHEN @l <= 10 THEN 2 -- Diamante
                  WHEN @l <= 15 THEN 3 -- General
                  WHEN @l <= 20 THEN 4 -- Platea
                  ELSE 5 -- Gramilla
                END, 4, 0);
    SET @l = @l + 1;
END;

--BOLETO
-- Boletos para concierto 1
DECLARE @m INT = 1;
WHILE @m <= 30
BEGIN
    INSERT INTO boleto (idAsiento, idConcieto)
    VALUES (@m, 1);
    SET @m = @m + 1;
END;

--RESERVA
-- Supongamos que tenemos 10 usuarios y 120 boletos (30 por cada concierto)

-- Inserts de reserva: 3 boletos por cada usuario
DECLARE @numBoletos INT = 3;
DECLARE @maxUsuarios INT = 10;
DECLARE @h INT = 1;
DECLARE @d INT = 1;
DECLARE @maxBoletos INT = 120;

WHILE @h <= @maxUsuarios
BEGIN
    DECLARE @counter INT = 0;
    
    WHILE @counter < @numBoletos AND @d <= @maxBoletos
    BEGIN
        INSERT INTO reserva (idUsuario, idBoleto) 
        VALUES (@h, @d);
        
        SET @d = @d + 1;
        SET @counter = @counter + 1;
    END
    
    SET @h = @h + 1;
END;
