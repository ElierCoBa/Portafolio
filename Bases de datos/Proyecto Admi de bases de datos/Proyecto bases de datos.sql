
Create Database Administracion_de_vecindarios

Use Administracion_de_vecindarios

Create table Vecindario(
Id varchar(6) primary key not null,
numeroBloques int not null
)
go

Create table Bloques(
Id varchar(1) primary key not null,
IdVecindario varchar(6) FOREIGN KEY REFERENCES Vecindario(Id) not null,
numeroDeCasas int not null,
cantidadDeHabitantes int not null 

)
go

Create table PostesDeLuz(
Id varchar(40) primary key not null,
IdBloque varchar(1) FOREIGN KEY REFERENCES Bloques(Id) not null,
Ubicacion text not null

)
go

Create table Casas(
Id varchar(2) primary key not null,
IdBloque varchar(1) FOREIGN KEY REFERENCES Bloques (Id)not null,
numeroDePersonas int not null,
Mascotas bit not null,
Direccion text not null
)
go



Create table Personas(
Id varchar(10) primary key not null,
Apellido1 varchar(40) not null, 
Apellido2 varchar(40) not null,
Nombre1 varchar(40) not null,
Nombre2 varchar(40),
fechaDeNacimiento date not null,
estadoCivil varchar(40) not null
)
go

Create table HabitantesPorCasa(
IdCasa varchar(2) FOREIGN KEY REFERENCES Casas(Id) not null,
IdPersona varchar(10) FOREIGN KEY REFERENCES Personas (Id) not null,
Categoria varchar(40) not null,
primary key(IdCasa,IdPersona)

)
go

Create table LiderDeBloque(
Id varchar(11) primary key not null,
IdPersona varchar(10) FOREIGN KEY REFERENCES Personas(Id) not null,
IdBloque varchar(1) FOREIGN KEY REFERENCES Bloques(Id) not null
)
go

Create table Proyectos(
Id int identity (1,1) primary key not null,
IdVecindario varchar(6) FOREIGN KEY REFERENCES Vecindario (Id)not null,
IdEncargado varchar(10) FOREIGN KEY REFERENCES Personas (Id) not null,
Descripcion text not null,
fechaDeInicio date not null,
fechaDeFializacion date
)
go

Create table Tareas(
Id int identity(1,1) primary key not null,
IdProyecto int FOREIGN KEY REFERENCES Proyectos(Id) not null,
Descripcion text not null
)
go

Create table Prioridades(
Id int identity(1,1) primary key not null,
IdTarea int FOREIGN KEY REFERENCES Tareas(Id) not null,
Prioridad varchar(40) not null
)
go

Create table Estados(
Id int identity(1,1) primary key not null,
IdProyecto int FOREIGN KEY REFERENCES Proyectos (Id) not null,
Estado varchar(40) not null
)

go

create table Reportes(
Id int identity(1,1) primary key not null,
IdBloque varchar(1) FOREIGN KEY REFERENCES Bloques(Id) not null,
IdReportante varchar(10) FOREIGN KEY REFERENCES Personas(Id) not null,
Fecha datetime not null,
Descripcion text not null

)
go

Create table Telefonos(
IdPersona varchar(10) FOREIGN KEY REFERENCES Personas(Id) not null,
Telefono varchar(30) not null

primary key (IdPersona, Telefono)
)

Create table Correos(
IdPersona varchar(10) FOREIGN KEY REFERENCES Personas(id) not null,
Correo varchar(40) not null

primary key (IdPersona, Correo)
)

Create table Bitacora(
 consecutivo int primary key not null  identity (1,1), 
 usuario varchar(50) not null,
 fecha_hora_transaccion datetime not null,
 tipo_evento varchar(50) not null

)
go