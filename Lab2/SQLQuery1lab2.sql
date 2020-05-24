CREATE DATABASE Lab2

--tabla
CREATE TABLE VIDEO
(
idVideo INT NOT NULL,
titulo VARCHAR(100) NOT NULL,
repro INT NOT NULL,
url VARCHAR(100) NOT NULL,

CONSTRAINT PK_VideoIdVideo PRIMARY KEY(idVideo)
);

--stored procedure

CREATE PROCEDURE sp_video_insertar
	@idVideo INT,
	@titulo VARCHAR(100),
	@repro INT,
	@url VARCHAR(100)
AS
BEGIN
	INSERT INTO VIDEO
	VALUES(@idVideo, @titulo, @repro, @url)
END

EXEC sp_video_insertar 1, 'Obsession(Sehun Fancam)', 266585, 'https://www.youtube.com/watch?v=PdLgMNAlmLw'


CREATE PROCEDURE sp_video_editar
	@idVideo INT,
	@titulo VARCHAR(100),
	@repro INT,
	@url VARCHAR(100)
AS
BEGIN
	UPDATE VIDEO
	SET @titulo=titulo, @repro=repro, @url=url
	WHERE @idVideo=idVideo
END


CREATE PROCEDURE sp_video_eliminar
	@idVideo INT
AS
BEGIN
	DELETE FROM VIDEO
	WHERE @idVideo=idVideo
END


select * from video;