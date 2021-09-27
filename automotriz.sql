create database automotriz;
use Automotriz;

create table accesos(
idaccesos varchar(50) primary key,
lectura boolean,
escritura boolean,
eliminacion boolean,
acctualizacion boolean
);

create table usuarios(
idusuarios int primary key auto_increment, 
nombre varchar(50),
apellidop varchar(50),
apellidom varchar(50),
fechanacimiento varchar(50),
rfc varchar(50),
fkidaccesos varchar(50),
foreign key(fkidaccesos) references accesos(idaccesos)
);

create table productos(
codigobarras varchar(50) primary key,
nombre varchar(50), 
descripcion varchar (100),
marca varchar(50)
);

create table herramientas(
codigoherramientas varchar(50) primary key,
nombre varchar(50),
medida varchar(50),
marca varchar(50),
descripcion varchar(100) 
);

insert into accesos values
('Administador', true,true,true,true),
('Usuarios', true,true,false,false),
('Invitado', false,false,false,false);
