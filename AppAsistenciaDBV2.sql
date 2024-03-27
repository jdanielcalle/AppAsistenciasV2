create database AppAsistenciasDBV2;
use AppAsistenciasDBV2;
-- Tabla de los profesores
create table Profesores(
ProfesorID int primary key,
Cedula int not null,
Nombre varchar(50) not null,
Pin int not null,
Email varchar(50) not null
foreign key (ProfesorID) references Profesores(ProfesorID));
-- Insertar datos a la tabla de profesores
insert into Profesores (ProfesorID, Cedula, Nombre, Pin, Email)
values
    (1, 123456789, 'Daniel Saldarriaga', 1234, 'daniel.saldarriaga@gmail.com'),
    (2, 987654321, 'Yudy Quintro', 5678, 'yudy.quintero@gmail.com');
-- Tabla de los estudiantes
create table Estudiantes(
EstudianteID int identity(1,1) primary key,
TipoIdentificacion varchar(2) not null check (TipoIdentificacion in ('cc', 'ti')),
Identificacion int not null,
Nombre varchar(50) not null,
Pin int not null,
Email varchar(50) not null,
foreign key (EstudianteID) references Estudiantes(EstudianteID));
-- Insertar datos a la tabla de estudiantes
insert into Estudiantes (TipoIdentificacion, Identificacion, Nombre, Pin, Email)
values
    ('cc', 123456789, 'Daniel Calle', 4404, 'daniel.calle@gmail.com'),
    ('cc', 987654321, 'Sofia Montes', 4267, 'sofia.montes@gmail.com'),
    ('ti', 111223344, 'Daniel Villegas', 5962, 'daniel.villegas@gmail.com'),
    ('ti', 555667788, 'Carlos García', 5391, 'carlos.garcia@gmail.com'),
    ('cc', 999888777, 'Isaias Munera', 2273, 'isaias.munera@gmail.com'),
    ('cc', 666555444, 'Valentina Silva', 1386, 'valentina.silva@gmail.com'),
    ('ti', 333222111, 'Valentina Rivas', 7670, 'valentina.rivas@gmail.com'),
    ('ti', 777888999, 'Carlos Castaño', 8913, 'carlos.castaño@gmail.com');
-- Tabla de los cursos
create table Cursos(
CursoID int identity(1,1) primary key,
NombreCurso varchar(50) not null,
ProfesorID int,
foreign key (CursoID) references Cursos(CursoID),
foreign key (ProfesorID) references Profesores(ProfesorID));
-- Insertar datos a la tabla de cursos
insert into Cursos (NombreCurso, ProfesorID)
values
    ('Pensamiento Algorítmico', 1),
    ('Bases de Datos', 1),
    ('Cálculo Diferencial', 2),
    ('Circuitos Digitales', 2);
-- Tabla de asistencias
create table Asistencia(
AsistenciaID int identity(1,1) primary key,
CursoID int,
EstudianteID int,
FechaAsistencia date not null,
EstadoAsistencia varchar(50) not null,
foreign key (CursoID) references Cursos(CursoID),
foreign key (EstudianteID) references Estudiantes(EstudianteID));
-- Insertar datos a la tabla de asistencias
-- Curso 1 - Pensamiento Algorítmico
insert into Asistencia (CursoID, EstudianteID, FechaAsistencia, EstadoAsistencia)
values
    (1, 1, '2023-11-15', 'Presente'),
    (1, 2, '2023-11-15', 'Presente');
-- Curso 2 - Bases de Datos
insert into Asistencia (CursoID, EstudianteID, FechaAsistencia, EstadoAsistencia)
values
    (2, 3, '2023-11-15', 'Presente'),
    (2, 4, '2023-11-15', 'Presente');
-- Curso 3 - Cálculo Diferencial
insert into Asistencia (CursoID, EstudianteID, FechaAsistencia, EstadoAsistencia)
values
    (3, 5, '2023-11-15', 'Presente'),
    (3, 6, '2023-11-15', 'Presente');
-- Curso 4 - Circuitos Digitales
insert into Asistencia (CursoID, EstudianteID, FechaAsistencia, EstadoAsistencia)
values
    (4, 7, '2023-11-15', 'Presente'),
    (4, 8, '2023-11-15', 'Presente');
-- Tabla de inscripciones
create table Inscripciones (
InscripcionID int identity(1,1) primary key,
EstudianteID int,
CursoID int,
foreign key (EstudianteID) references Estudiantes(EstudianteID),
foreign key (CursoID) references Cursos(CursoID),
unique (EstudianteID, CursoID));
-- Inscribe estudiantes en cursos
insert into Inscripciones (EstudianteID, CursoID)
values
    (1, 1), -- Daniel Calle en Curso (Pensamiento Algorítmico)
    (2, 2), -- Sofia Montes en Curso (Bases de Datos)
    (3, 3), -- Daniel Villegas en Curso (Cálculo Diferencial)
    (4, 4), -- Carlos Garcia en Curso (Circuitos Digitales)
    (5, 1), -- Isaias Munera en Curso (Pensamiento Algorítmico)
    (6, 2), -- Valentina Silva en Curso (Bases de Datos)
    (7, 3), -- Valentina Rivas en Curso (Cálculo Diferencial)
    (8, 4); -- Carlos Castaño en Curso (Circuitos Digitales)
-- Hacer consultas
select * from Profesores
select * from Estudiantes
-- Consultar los estudiantes que estudian solo pensamiento algoritmico o bases de datos
select Identificacion, Nombre, Email, NombreCurso
from Estudiantes
inner join Inscripciones on Estudiantes.EstudianteID = Inscripciones.EstudianteID
inner join Cursos on Inscripciones.CursoID = Cursos.CursoID
where Cursos.NombreCurso in ('Pensamiento Algorítmico', 'Bases de Datos');