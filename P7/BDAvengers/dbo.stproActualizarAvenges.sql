CREATE PROCEDURE dbo.stproActualizarAvenges
 @ID int,
 @alias varchar(20),
 @nombre varchar(30),
 @cumple datetime,
 @imagen varchar(20)
AS
 UPDATE avenger
 SET alias = @alias, nombre = @nombre, cumple = @cumple
 WHERE (ID = @ID)