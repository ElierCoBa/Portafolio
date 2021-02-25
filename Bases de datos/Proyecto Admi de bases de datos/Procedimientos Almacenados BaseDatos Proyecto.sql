-- Procediminetos Almacenados


-- Procedimiento almacenado para seleccionar los poste de luz

Use Administracion_de_vecindarios
go

CREATE PROCEDURE SP_Seleccionar_Postes

AS
Begin TRANSACTION MostrarPostesDeLuz
Select * From PostesDeLuz 
IF (@@ERROR =0)
COMMIT TRANSACTION MostrarPostesDeLuz
ELSE
ROLLBACK TRANSACTION MostrarPostesDeLuz




-- Procedimiento almacenado para seleccionar un poste de luz especifico por su id

CREATE PROCEDURE SP_Consultar_PosteDeLuz_Especifico
@id as Varchar(40)
AS
Begin TRANSACTION Consultar_PosteDeLuz_Especifico
Select * From PostesDeLuz 
where id=@id
IF (@@ERROR =0)
COMMIT TRANSACTION Consultar_PosteDeLuz_Especifico
ELSE
ROLLBACK TRANSACTION Consultar_PosteDeLuz_Especifico


-- Procedimiento almacenado para insertar un poste de luz 

Create Procedure SP_InsertarPostes
@id varchar (40),
@idBloque varchar (1),
@ubicacion text

As
Begin TRANSACTION Insertar
Insert Into PostesDeLuz(id, idBloque,Ubicacion)
Values (@id, @idBloque, @ubicacion)
IF (@@ERROR =0)
COMMIT TRANSACTION Insertar
ELSE
ROLLBACK TRANSACTION Insertar




-- Procedimiento almacenado para actualizar un poste de luz especifico por su id

CREATE PROCEDURE SP_Actualizar_Un_PosteDeLuz_Especifico
@id varchar(30),
@ubicacion varchar (30)
AS
Begin TRANSACTION Actualizar
Update PostesDeLuz Set Ubicacion = @ubicacion Where id= @id
IF (@@ERROR =0)
COMMIT TRANSACTION Actualizar
ELSE
ROLLBACK TRANSACTION Actualizar


-- Procedimiento almacenado para eliminar  todo del registro poste de luz  por su id

CREATE PROCEDURE SP_Eliminar_Postes
AS
Begin TRANSACTION Eliminar_Postes
Delete  From PostesDeLuz 
IF (@@ERROR =0)
COMMIT TRANSACTION Eliminar_Postes
ELSE
ROLLBACK TRANSACTION Eliminar_Postes




-- Procedimiento almacenado para eliminar un poste de luz especifico por su id

CREATE PROCEDURE SP_Eliminar_PostesDeLuz_Especifico
@id varchar(40)

AS
Begin TRANSACTION EliminarPosteEspecifico
Delete  From PostesDeLuz where id=@id
IF (@@ERROR =0)

COMMIT TRANSACTION EliminarPosteEspecifico
ELSE
ROLLBACK TRANSACTION EliminarPosteEspecifico


select * from PostesDeLuz






-- Procedimientos Almacenados para la tabla Prioridades--


Use Administracion_de_vecindarios
go

CREATE PROCEDURE SP_Seleccionar_Prioridades

AS
Begin TRANSACTION MostrarPrioridades
Select * From Prioridades 
IF (@@ERROR =0)
COMMIT TRANSACTION MostrarPrioridades
ELSE
ROLLBACK TRANSACTION MostrarPrioridades




-- Procedimiento almacenado para seleccionar una prioridad especifico por su id

CREATE PROCEDURE SP_Consultar_Prioridad_Especifico
@id as int
AS
Begin TRANSACTION Consultar_Prioridad_Especifico
Select * From Prioridades 
where id=@id
IF (@@ERROR =0)
COMMIT TRANSACTION Consultar_Prioridad_Especifico
ELSE
ROLLBACK TRANSACTION Consultar_Prioridad_Especifico


-- Procedimiento almacenado para insertar una prioridad

Create Procedure SP_InsertarPrioridades
@id int ,
@idTarea int,
@Prioridad varchar (40)

As
Begin TRANSACTION InsertarPrioridades
Insert Into Prioridades(id, idTarea,Prioridad)
Values (@id, @idTarea, @Prioridad)
IF (@@ERROR =0)
COMMIT TRANSACTION InsertarPrioridades
ELSE
ROLLBACK TRANSACTION InsertarPrioridades




-- Procedimiento almacenado para actualizar una prioridad especifico por su id

CREATE PROCEDURE SP_Actualizar_Prioridad_Especifico
@id int,
@Prioridad varchar (40)
AS
Begin TRANSACTION Actualizar
Update Prioridades Set Prioridad = @Prioridad Where id= @id
IF (@@ERROR =0)
COMMIT TRANSACTION Actualizar
ELSE
ROLLBACK TRANSACTION Actualizar


-- Procedimiento almacenado para eliminar  todo del registro prioridades  por su id

CREATE PROCEDURE SP_Eliminar_Prioridad
AS
Begin TRANSACTION Eliminar_Prioridad
Delete  From Prioridades
IF (@@ERROR =0)
COMMIT TRANSACTION Eliminar_Prioridad
ELSE
ROLLBACK TRANSACTION Eliminar_Prioridad




-- Procedimiento almacenado para eliminar  una prioridad especifico por su id

CREATE PROCEDURE SP_Eliminar_Prioridad_Especifico
@id int

AS
Begin TRANSACTION EliminarPrioridadEspecifico
Delete  From Prioridades where id=@id
IF (@@ERROR =0)

COMMIT TRANSACTION EliminarPrioridadEspecifico
ELSE
ROLLBACK TRANSACTION EliminarPrioridadEspecifico


select * from Prioridades



-- Procedimientos Almacenados para la tabla Proyectos--


Use Administracion_de_vecindarios
go

CREATE PROCEDURE SP_Seleccionar_Proyectos

AS
Begin TRANSACTION MostrarProyectos
Select * From Proyectos
IF (@@ERROR =0)
COMMIT TRANSACTION MostrarProyectos
ELSE
ROLLBACK TRANSACTION MostrarProyectos




-- Procedimiento almacenado para seleccionar un proyectoespecifico por su id

CREATE PROCEDURE SP_Consultar_Proyecto_Especifico
@id as int
AS
Begin TRANSACTION Consultar_Proyecto_Especifico
Select * From Proyectos 
where id=@id
IF (@@ERROR =0)
COMMIT TRANSACTION Consultar_Proyecto_Especifico
ELSE
ROLLBACK TRANSACTION Consultar_Proyecto_Especifico


-- Procedimiento almacenado para insertar un proyecto  

Create Procedure SP_Nuevo_Registro_Proyecto
@id int ,
@idvecindario varchar(6),
@idEncargado varchar (10),
@Descripcion text,
@fechaDeIncio date,
@fechaDeFinalizacion date

As
Begin TRANSACTION Nuevo_Registro
Insert Into Proyectos(id, idvecindario,idEncargado,Descripcion,fechaDeInicio,fechaDeFinalizacion)
Values (@id, @idvecindario, @idEncargado,@Descripcion,@fechaDeIncio,@fechaDeFinalizacion)
IF (@@ERROR =0)
COMMIT TRANSACTION Nuevo_Registro
ELSE
ROLLBACK TRANSACTION Nuevo_Registro




-- Procedimiento almacenado para actualizar un proyecto especifico por su id

CREATE PROCEDURE SP_Actualizar_Proyecto_Especifico
@id int,
@Descripcion text,
@fechaDeInicio date,
@fechaDeFinalizacion date


AS
Begin TRANSACTION Actualizar
Update Proyectos Set Descripcion = @Descripcion, fechaDeInicio=@fechaDeInicio, fechaDeFinalizacion=@fechaDeFinalizacion
 Where id= @id
IF (@@ERROR =0)
COMMIT TRANSACTION Actualizar
ELSE
ROLLBACK TRANSACTION Actualizar


-- Procedimiento almacenado para eliminar  todo del registro de proyectos  por su id

CREATE PROCEDURE SP_Eliminar_Proyectos
AS
Begin TRANSACTION Eliminar_Proyrctos
Delete  From Proyectos
IF (@@ERROR =0)
COMMIT TRANSACTION Eliminar_Proyectos
ELSE
ROLLBACK TRANSACTION Eliminar_Proyectos




-- Procedimiento almacenado para eliminar un proyecto  especifico por su id

CREATE PROCEDURE SP_Eliminar_Proyecto_Especifico
@id int

AS
Begin TRANSACTION EliminarProyectoEspecifico
Delete  From Proyectos where id=@id
IF (@@ERROR =0)

COMMIT TRANSACTION EliminarProyectoEspecifico
ELSE
ROLLBACK TRANSACTION EliminarProyectoEspecifico



-- procedimiento almacenado para la tabla telefono



-- procedimiento almacenado para mostrar telefonos
CREATE PROC SP_MostrarTodosTelefonos
AS
BEGIN TRANSACTION MostrarTodosTelefonos
SELECT * FROM Telefonos
IF(@@Error = 0)
COMMIT TRANSACTION MostrarTodosTelefonos
ELSE
ROLLBACK TRANSACTION MostrarTodosTelefonos


-- procedimiento almacenado para mostrar telefonos por id


CREATE PROC SP_MostrarTelefonoPorId
@elIdPersona as varchar(10)
AS
BEGIN TRANSACTION MostrarTelefonoPorId
SELECT * FROM Telefonos WHERE IdPersona = @elIdPersona 
IF(@@Error = 0)
COMMIT TRANSACTION MostrarTelefonoPorId
ELSE
ROLLBACK TRANSACTION MostrarTelefonoPorId


-- procedimiento almacenado para insertar telefonos por id


CREATE PROC SP_InsertarTelefono
@elIdPersona varchar(10), @elTelefono varchar(40)
AS
BEGIN TRANSACTION InsertarTelefono
INSERT INTO Telefonos(IdPersona, Telefono) VALUES 
(@elIdPersona,@elTelefono)
IF(@@Error = 0)
COMMIT TRANSACTION InsertarTelefono
ELSE
ROLLBACK TRANSACTION InsertarTelefono

-- procedimiento almacenado para eliminar telefonos 

CREATE PROC SP_EliminarTelefonos
@elIdPersona varchar(10)
AS
BEGIN TRANSACTION SP_EliminarTelefonos
DELETE FROM Telefonos WHERE IdPersona = @elIdPersona
IF(@@Error = 0)
COMMIT TRANSACTION SP_EliminarTelefonos
ELSE
ROLLBACK TRANSACTION SP_EliminarTelefonos


-- procedimiento almacenado para actualizar telefonos 
CREATE PROC SP_ActualizarTelefono
@elIdPersona varchar(10), @elTelefono varchar(40)
as
BEGIN TRANSACTION ActualizarTelefono
UPDATE Telefonos SET Telefono = @elTelefono
WHERE IdPersona = @elIdPersona
IF(@@Error = 0)
COMMIT TRANSACTION ActualizarTelefono
ELSE
ROLLBACK TRANSACTION ActualizarTelefono



--Procedimientos almacenados para la tabla correos




-- procedimiento almacenado para mostrar correos

CREATE PROC SP_MostrarTodosCorreos
AS
BEGIN TRANSACTION MostrarTodosCorreos
SELECT * FROM Correos
IF(@@Error = 0)
COMMIT TRANSACTION MostrarTodosCorreos
ELSE
ROLLBACK TRANSACTION MostrarTodosCorreos


-- procedimiento almacenado para mostrar correos por id

CREATE PROC SP_MostrarCorreosPorId
@elIdPersona as varchar(10)
AS
BEGIN TRANSACTION MostrarCorreosPorId
SELECT * FROM Correos WHERE IdPersona = @elIdPersona 
IF(@@Error = 0)
COMMIT TRANSACTION MostrarCorreosPorId
ELSE
ROLLBACK TRANSACTION MostrarCorreosPorId

-- procedimiento almacenado para insertar correo

CREATE PROC SP_InsertarCorreo
@elIdPersona varchar(10), @elCorreo varchar(40)
AS
BEGIN TRANSACTION InsertarCorreo
INSERT INTO Correos(IdPersona, Correo) VALUES 
(@elIdPersona,@elCorreo)
IF(@@Error = 0)
COMMIT TRANSACTION InsertarCorreo
ELSE
ROLLBACK TRANSACTION InsertarCorreo


-- procedimiento almacenado para eliminar correo


CREATE PROC SP_EliminarCorreos
@elIdPersona varchar(10)
AS
BEGIN TRANSACTION EliminarCorreos
DELETE FROM Correos WHERE IdPersona = @elIdPersona
IF(@@Error = 0)
COMMIT TRANSACTION EliminarCorreos
ELSE
ROLLBACK TRANSACTION EliminarCorreos



-- procedimiento almacenado para actualizar correo


CREATE PROC SP_ActualizarCorreo
@elIdPersona varchar(10), @elCorreo varchar(40)
as
BEGIN TRANSACTION ActualizarCorreo
UPDATE Correos SET Correo = @elCorreo
WHERE IdPersona = @elIdPersona
IF(@@Error = 0)
COMMIT TRANSACTION ActualizarCorreo
ELSE
ROLLBACK TRANSACTION ActualizarCorreo




--PROCEDIMIENTOS ALMACENADOS DE LA TABLA VECINDARIOS
Use Administracion_de_vecindarios

CREATE PROCEDURE SP_Consultar_Todos_Los_Vecindarios
AS
Select * From Vecindario 

EXECUTE SP_Consultar_Todos_Los_Vecindarios

CREATE PROCEDURE SP_Consultar_Vecindario_Especifico
@id as Varchar(50)
AS
Select * From Vecindario 
where Id=@id

EXECUTE SP_Consultar_Vecindario_Especifico '1'

Create Procedure SP_Nuevo_Vecindario
@id varchar (6),
@bloque int
As
Insert Into Vecindario(Id, numeroBloques)
Values (@id, @bloque)

Execute SP_Nuevo_Vecindario '5', '2'

Create Procedure SP_Eliminar_Todos_Los_Vecindarios
As
Delete From Vecindario

Execute SP_Eliminar_Todos_Los_Vecindarios

Create Procedure SP_Eliminar_Un_Vecindario_Especifico
@id varchar (30)
As
Delete From Vecindario Where Id = @id

Execute SP_Eliminar_Un_Vecindario_Especifico '5'



--PROCEDIMIENTOS ALMACENADOS DE LA TABLA TAREAS
Use Administracion_de_vecindarios

CREATE PROCEDURE SP_Consultar_Todas_Las_Tareas
AS
Select * From Tareas 

EXECUTE SP_Consultar_Todas_Las_Tareas

CREATE PROCEDURE SP_Consultar_Tarea_Especifica
@id as Varchar(50)
AS
Select * From Tareas 
where Id=@id

EXECUTE SP_Consultar_Tarea_Especifica '1'

Create Procedure SP_Nueva_Tarea
@id int,
@idProyecto int,
@descripcion text
As
Insert Into Tareas(Id, IdProyecto, Descripcion)
Values (@id, @idProyecto, @descripcion)

Execute SP_Nueva_Tarea '5', '2', 'Vigilancia nocturna'

Create Procedure SP_Eliminar_Todas_Las_Tareas
As
Delete From Tareas

Execute SP_Eliminar_Todas_Las_Tareas

Create Procedure SP_Eliminar_Una_Tarea_Especifica
@id int
As
Delete From Tareas Where Id = @id

Execute SP_Eliminar_Un_Vecindario_Especifico '5'


-- Procedimientos para la tabla lideres de bloque



USE Administracion_de_vecindarios

-- PROC-  MOSTRAR TODOS LOS LIDERES DE BLOQUE 
CREATE PROC SP_MostrarTodosLosLideresDeBloque
AS
BEGIN TRANSACTION MostrarTodosLosLideresDeBloque
IF (@@ERROR) = 0
COMMIT TRANSACTION MostrarTodosLosLideresDeBloque
ELSE 
ROLLBACK TRANSACTION MostrarTodosLosLideresDeBloque


-- PROC-  MOSTRAR LIDER DE BLOQUE POR ID
CREATE PROC SP_MostrarLiderDeBloquePorId
@elIdDelLider as varchar (10)
AS
BEGIN TRANSACTION MostrarLiderDeBloquePorId
SELECT * FROM LiderDeBloque WHERE Id =@elIdDelLider
IF (@@ERROR= 0)
COMMIT TRANSACTION MostrarLiderDeBloquePorId
ELSE
ROLLBACK TRANSACTION MostrarLiderDeBloquePorId

-- INSERTAR LIDER DE BLOQUE
CREATE PROC SP_InsertarLiderDeBloque
@elId varchar(10), @elIdPersona varchar (10), @elIdBloque varchar (10)
AS
BEGIN TRANSACTION InsertarLiderDeBloque
INSERT INTO LiderDeBloque (Id, IdBloque,IdPersona ) VALUES 
(@elId, @elIdBloque, @elIdPersona)
IF (@@ERROR = 0)
COMMIT TRANSACTION InsertarLiderDeBloque
ELSE
ROLLBACK TRANSACTION InsertarLiderDeBLoque

-- ELIMINAR LIDER DE BLOQUE
CREATE PROC SP_EliminarLiderDeBloque
@elId varchar (10)
AS 
BEGIN TRANSACTION EliminarLiderDeBloque
DELETE FROM LiderDeBloque WHERE Id = @elId
IF (@@ERROR = 0)
COMMIT TRANSACTION EliminarLiderDeBloque
ELSE
ROLLBACK TRANSACTION EliminarLiderDeBloque

-- ACTUALIZAR LIDER DE BLOQUE

CREATE PROC SP_ActualizarLiderDeBloque
@elId varchar(10), @elIdBloque varchar (10), @elIdPersona varchar (10)
AS
BEGIN TRANSACTION ActualizarLiderDeBloque
UPDATE LiderDeBloque SET Id = @elId
WHERE IdBloque=@elIdBloque 
IF (@@ERROR = 0) 
COMMIT TRANSACTION ActualizarLiderDeBloque
ELSE 
ROLLBACK TRANSACTION ActualizarLiderDeBloque






--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA PERSONAS

-- MOSTRAR TODAS LAS PERSONAS

CREATE PROC SP_MostrarTodasLasPersonas
AS 
BEGIN TRANSACTION MostrarTodasLasPersonas
SELECT * FROM Personas
IF (@@ERROR = 0)
COMMIT TRANSACTION MostrarTodasLasPersonas
ELSE
ROLLBACK TRANSACTION MostrarTodasLasPersonas

--MOSTRAR PERSONAS POR ID

CREATE PROC SP_MostrarPersonaPorId
@elIdPersona AS VARCHAR (10) 
AS 
BEGIN TRANSACTION MostrarPersonaPorId
SELECT * FROM Personas WHERE Id = @elIdPersona
IF (@@ERROR = 0)
COMMIT TRANSACTION MostrarPersonaPorId
ELSE 
ROLLBACK TRANSACTION MostrarPersonaPorId

-- PROC INSERTAR PERSONA
CREATE PROC SP_InsertarPersona
@elId VARCHAR (10), @elApellido1 VARCHAR (40), @elApellido2 VARCHAR (40), @elNombre1 VARCHAR (40),
@elNombre2 VARCHAR (40), @laFechaDeNacimiento DATE, @elEstadoCivil VARCHAR (40)
AS 
BEGIN TRANSACTION InsertarPersona
INSERT INTO Personas (Id, Apellido1,Apellido1, Nombre1, Nombre2, fechaDeNacimiento,estadoCivil) VALUES
(@elId, @elApellido1,@elApellido2,@elNombre1,@elNombre2,@laFechaDeNacimiento,@elEstadoCivil)
IF (@@ERROR = 0)
COMMIT TRANSACTION InsertarPersona
ELSE
ROLLBACK TRANSACTION InsertarPersona


-- PROC ELIMINAR PERSONA
CREATE PROC SP_EliminarPersona
@elId VARCHAR (10)
AS 
BEGIN TRANSACTION EliminarPersona
DELETE FROM Personas WHERE Id = @elId
IF (@@ERROR = 0)
COMMIT TRANSACTION EliminarPersona
ELSE
ROLLBACK TRANSACTION EliminarPersona

-- PROC ACTUALIZAR PERSONA 
CREATE PROC SP_ActualizarPersona
@elId VARCHAR (10), @elApellido1 VARCHAR (40), @elApellido2 VARCHAR (40), @elNombre1 VARCHAR (40),
@elNombre2 VARCHAR (40), @laFechaDeNacimiento DATE, @elEstadoCivil VARCHAR (40)
AS 
BEGIN TRANSACTION ActualizarPersona
UPDATE Personas SET Apellido1 = @elApellido1, Apellido2 = @elApellido2, Nombre1 = @elNombre1 , Nombre2 = @elNombre2, fechaDeNacimiento = @laFechaDeNacimiento , estadoCivil = @elEstadoCivil
WHERE Id =@elId
IF (@@ERROR = 0)
COMMIT TRANSACTION ActualizarPersona
ELSE
ROLLBACK TRANSACTION ActualizarPersona

--PROC INSERTAR BLOQUE


CREATE PROC SP_InsertarBloque
@Id as varchar(1),
@IdDelVecindario as varchar(6), 
@NumeroDeCasas as int,
@CantidadDeHabitantes as int
as
BEGIN TRANSACTION InsertarBloque
INSERT INTO Bloques values(@Id,@IdDelVecindario,@NumeroDeCasas,@CantidadDeHabitantes)
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBloque
ELSE
ROLLBACK TRANSACTION InsertarBloque

--PROC ACTUALIZAR BLOQUE

CREATE PROC SP_ActualizarVecindarioDelBloque
@IdDelVecindario as varchar(6),
@IdDelBloque as varchar(1)
AS
BEGIN TRANSACTION ActulizarVecindario
Update Bloques SET IdVecindario = @IdDelVecindario WHERE Id = @IdDelBloque
IF(@@Error = 0)
COMMIT TRANSACTION ActulizarVecindario
ELSE
ROLLBACK TRANSACTION ActulizarVecindario

--PROC ELIMINAR BLOQUE

CREATE PROC SP_EliminarBloque

@IdDelBloque as varchar(1)
AS
BEGIN TRANSACTION EliminarVecindario
DELETE FROM Bloques WHERE Id = @IdDelBloque
IF(@@Error = 0)
COMMIT TRANSACTION EliminarVecindario
ELSE
ROLLBACK TRANSACTION EliminarVecindario

-- PROC MOSTRAR BLOQUES DEL VECINDARIO

CREATE PROC SP_MostrarBloquesDelVecindario
@IdDelVecindario as varchar(6)
as 
BEGIN TRANSACTION MostrarBloquesDelVecindario
SELECT * FROM Bloques Where idVecindario = @IdDelVecindario
IF(@@Error = 0)
COMMIT TRANSACTION MostrarBloquesDelVecindario
ELSE
ROLLBACK TRANSACTION MostrarBloquesDelVecindario

--PROC MOSTRAR TODOS LOS BLOQUES

CREATE PROC SP_MostrarTodosLosBloques
AS
BEGIN TRANSACTION MostrarTodosLosBloques
SELECT * FROM Bloques
IF(@@Error = 0)
COMMIT TRANSACTION MostrarTodosLosBloques
ELSE
ROLLBACK TRANSACTION MostrarTodosLosBloques

--PROC MOSTRAR HABITANTE DEL BLOQUE


CREATE PROC SP_HabitantesDelBloque
@IdDelBloque as int 
AS
BEGIN TRANSACTION MostrarHabitantesDelBloque
SELECT Bloques.cantidadDeHabitantes FROM Bloques where id=@IdDelBloque
IF(@@Error = 0)
COMMIT TRANSACTION MostrarHabitantesDelBloque
ELSE
ROLLBACK TRANSACTION MostrarHabitantesDelBloque

--PROC INSERTAR CASA

CREATE PROC SP_InsertarCasa
@Id as varchar(2),
@IdDelBloque as varchar(1), 
@NumeroDePersonas as int,
@Mascotas as bit,
@Direccion as text
as
BEGIN TRANSACTION InsertarCasa
INSERT INTO Bloques values(@Id,@IdDelBloque,@NumeroDePersonas,@Mascotas,@Direccion)
IF(@@Error = 0)
COMMIT TRANSACTION InsertarCasa
ELSE
ROLLBACK TRANSACTION InsertarCasa

--PROC ACTUALIZAR CASA

CREATE PROC SP_ActualizarNumeroDePersonasEnCasa
@IdDelaCasa as varchar(2),
@CantidadDePersonas as int
AS
BEGIN TRANSACTION ActulizarCantidadDePersonas
Update Casas SET numeroDePersonas = @CantidadDePersonas WHERE Id = @IdDelaCasa
IF(@@Error = 0)
COMMIT TRANSACTION ActulizarCantidadDePersonas
ELSE
ROLLBACK TRANSACTION ActulizarCantidadDePersonas

--PROC ELIMINAR CASA

CREATE PROC SP_EliminarCasa

@IdDeLaCasa as varchar(1)
AS
BEGIN TRANSACTION EliminarCasa
DELETE FROM Casas WHERE Id = @IdDeLaCasa
IF(@@Error = 0)
COMMIT TRANSACTION EliminarCasa
ELSE
ROLLBACK TRANSACTION EliminarCasa

--PROC MOSTRAR DIRECCION DE LA CASA


CREATE PROC SP_MostrarDireccionDeLaCasa
@IdDeLaCasa as varchar(2)
AS
BEGIN TRANSACTION MostrarDireccionDeLaCasa
SELECT Casas.Direccion FROM Casas where id = @IdDeLaCasa
IF(@@Error = 0)
COMMIT TRANSACTION MostrarDireccionDeLaCasa
ELSE
ROLLBACK TRANSACTION MostrarDireccionDeLaCasa

--PROC ACTUALIZAR REPORTE 

CREATE PROC SP_ActualizarBloqueDelReporte
@IdDelBloque as varchar(1),
@IdDelReporte as int
AS
BEGIN TRANSACTION ActulizarBloque
Update Reportes SET IdBloque = @IdDelBloque WHERE Id = @IdDelReporte
IF(@@Error = 0)
COMMIT TRANSACTION ActulizarBloque
ELSE
ROLLBACK TRANSACTION ActulizarBloque


--PROC ELIMINAR REPORTE

CREATE PROC SP_EliminarReporte

@IdDeLReporte as int
AS
BEGIN TRANSACTION EliminarReporte
DELETE FROM Reportes WHERE Id = @IdDeLReporte
IF(@@Error = 0)
COMMIT TRANSACTION EliminarReporte
ELSE
ROLLBACK TRANSACTION EliminarReporte

--PROC INSERTAR REPORTE

CREATE PROC SP_InsertarReporte
@Id as int,
@IdDelBloque as varchar(1), 
@IdReportante as varchar(10),

@Descripcion as text
as
BEGIN TRANSACTION InsertarReporte

INSERT INTO Reportes values(@Id,@IdDelBloque,@IdReportante,GETDATE(),@Descripcion)
IF(@@Error = 0)
COMMIT TRANSACTION InsertarReporte
ELSE
ROLLBACK TRANSACTION InsertarReporte

--PROC MOSTRAR LA DESCRIPCION DEL REPORTE POR BLOQUE

CREATE PROC SP_MostrarDescripcionDelReportePorBloque
@IdDelBloque as varchar(1)
AS
BEGIN TRANSACTION MostrarDescripcion
SELECT Reportes.Descripcion FROM Reportes where IdBloque = @IdDelBloque
IF(@@Error = 0)
COMMIT TRANSACTION MostrarDescripcion
ELSE
ROLLBACK TRANSACTION MostrarDescripcion