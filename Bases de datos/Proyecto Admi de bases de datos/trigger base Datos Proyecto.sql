-- Trigger para todas las tablas



---- Trigger Tabla Postes de Luz-------


create trigger TR_InsercionPostesDeLuz
on PostesDeLuz for insert
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER 
set @fecha = GETDATE() 
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'INSERCIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



create trigger TR_EliminacionPostesDeLuz
on PostesDeLuz for delete
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ELIMINACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora

create trigger TR_ActualizacionPostesDeLuz
on PostesDeLuz for update
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ACTUALIZACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora




---- Trigger para tabla Prioridades-------



CREATE trigger TR_InsercionPrioridades
on Prioridades for insert
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER 
set @fecha = GETDATE() 
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'INSERCIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



create trigger TR_EliminacionPrioridades
on Prioridades for delete
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ELIMINACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora

create trigger TR_ActualizacionPrioridades
on Prioridades for update
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ACTUALIZACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora






---- Trigger para la tabla proyectos-------




create trigger TR_InsercionProyectos
on Proyectos for insert
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER 
set @fecha = GETDATE() 
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'INSERCIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



create trigger TR_EliminacionProyectos
on Proyectos for delete
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ELIMINACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora

create trigger TR_ActualizacionProyectos
on Proyectos for update
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ACTUALIZACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora







-- trigger para la tabla telefono

create trigger TR_InsercionTelefonos
on Telefonos for insert
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER 
set @fecha = GETDATE() 
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'INSERCIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



create trigger TR_EliminacionTelefonos
on Telefonos for delete
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ELIMINACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora




create trigger TR_ActualizacionTelefonos
on Telefonos for update
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ACTUALIZACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



--Trigger para la tabla correo


create trigger TR_InsercionCorreos
on Correos for insert
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER 
set @fecha = GETDATE() 
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'INSERCIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



create trigger TR_EliminacionCorreos
on Correos for delete
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ELIMINACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



create trigger TR_ActualizacionCorreos
on Correos for update
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ACTUALIZACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora





-- trigger para la tabla bloque


CREATE TRIGGER tr_RegistroDeUpdate
ON Bloques
AFTER UPDATE
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'UPDATE'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

CREATE TRIGGER tr_RegistroDeDelete
ON Bloques
AFTER DELETE
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'DELETE'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

CREATE TRIGGER tr_RegistroDeinsert
ON Bloques
AFTER INSERT
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'INSERT'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO




-- TRIGGERS VECINDARIOS

Create Trigger TR_Insertar_Vecindario
on Vecindario for insert
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER 
set @fecha = GETDATE() 
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'INSERCIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



Create Trigger TR_EliminacionVecindario
on Vecindario for delete
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ELIMINACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora

create trigger TR_ActualizacionTelefonos
on Vecindario for update
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ACTUALIZACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora




-- TRIGGERS TAREAS

Create Trigger TR_Insertar_Vecindario
on Tareas for insert
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER 
set @fecha = GETDATE() 
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'INSERCIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



Create Trigger TR_EliminacionTelefonos
on Tareas for delete
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ELIMINACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora



create trigger TR_ActualizacionTelefonos
on Tareas for update
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ACTUALIZACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora





-- TRIGGERS DE LA TABLA PERSONAS

--INSERCION 

create trigger TR_InsercionPersonas
on Personas for insert
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER 
set @fecha = GETDATE() 
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'INSERCIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora

--ELIMINACION

create trigger TR_EliminacionDePersona
on Personas for delete
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ELIMINACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora

--ACTUALIZACION

create trigger TR_ActualizacionDePersonas
on Personas for update
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ACTUALIZACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora

iNSERT INTO Personas (Id,Apellido1,Apellido2,Nombre1,Nombre2,fechaDeNacimiento,estadoCivil)values('501230456','Co','Ba','Elier', '','12/04/1998','Soltero')



-- TRIGGERS DE LIDER DE BLOQUES

--INSERCION

create trigger TR_InsercionLiderDeBloque
on LiderDeBloque for insert
AS
declare @usuarioDeSistema varchar (30), @fecha datetime, @cedula int
set @usuarioDeSistema = SYSTEM_USER 
set @fecha = GETDATE() 
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'INSERCIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora

-- ELIMINACION

create trigger TR_EliminacionDeLiderDeBloque
on LiderDeBloque for delete
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ELIMINACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora

--ACTUALIZACIÓN

create trigger TR_ActualizacionDeLiderDeBloque
on LiderDeBloque for update
AS
declare @usuarioDeSistema varchar (30), @fecha datetime
set @usuarioDeSistema = SYSTEM_USER
set @fecha = GETDATE()
BEGIN TRANSACTION InsertarBitacora
insert into Bitacora values ( @usuarioDeSistema, @fecha, 'ACTUALIZACIÓN' )
IF(@@Error = 0)
COMMIT TRANSACTION InsertarBitacora
ELSE
ROLLBACK TRANSACTION InsertarBitacora




-- TRIGGERS DE BLOQUES

--Update
CREATE TRIGGER tr_RegistroDeUpdate
ON Bloques
AFTER UPDATE
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'UPDATE'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

--Delete

CREATE TRIGGER tr_RegistroDeDelete
ON Bloques
AFTER DELETE
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'DELETE'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

--Insert

CREATE TRIGGER tr_RegistroDeinsert
ON Bloques
AFTER INSERT
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'INSERT'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

--Trigger de Casas
--Update
CREATE TRIGGER tr_RegistroDeUpdate
ON Casas
AFTER UPDATE
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'UPDATE'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

--Delete


CREATE TRIGGER tr_RegistroDeDelete
ON Casas
AFTER DELETE
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'DELETE'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

--Insert
CREATE TRIGGER tr_RegistroDeinsert
ON Casas
AFTER INSERT
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'INSERT'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

--Trigger de Reportes

--Update

CREATE TRIGGER tr_RegistroDeUpdate
ON Reportes
AFTER UPDATE
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'UPDATE'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

--Delete

CREATE TRIGGER tr_RegistroDeDelete
ON Reportes
AFTER DELETE
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);
 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'DELETE'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

--Insert
CREATE TRIGGER tr_RegistroDeinsert
ON Reportes
AFTER INSERT
AS 
BEGIN
DECLARE  @usuario varchar(30),@fechaHoraDeLaTransaccion datetime,@tipoDeEvento varchar(30);


 SET @usuario =  CURRENT_USER;
 SET @fechaHoraDeLaTransaccion = GETDATE();
 SET @tipoDeEvento = 'INSERT'; 
 INSERT dbo.Bitacora(usuario,fecha_hora_transaccion,tipo_evento) 
 VALUES(@usuario,@fechaHoraDeLaTransaccion,@tipoDeEvento);
 END;
GO

