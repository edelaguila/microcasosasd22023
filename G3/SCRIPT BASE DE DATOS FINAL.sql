create database Polideportivo;
use Polideportivo;
create table EMPLEADOS (
id_empleados int PRIMARY KEY not null,
nombre varchar (30) not null,
apellido varchar (30) not null,
edad int not null,
telefono int not null,
correo varchar (30) not null,
cargo varchar (30) not null
);

create table ARBITRO(
arbitros int not null,
foreign key (arbitros) References EMPLEADOS(id_empleados)
);

create table DEPORTE(
id_deporte int primary key not null,
nombre varchar(30) not null,
categoria_genero varchar(30) not null,
categoria_edad varchar(30) not null
);

create table CAMPEONATO(
id_campeonato int primary key not null,
nombre varchar (30) not null,
no_equipos int not null,
fecha_inicio date not null,
fecha_final date not null,
deporte int,
creador_campeonato int not null,
foreign key (deporte) References DEPORTE(id_deporte),
foreign key (creador_campeonato) References EMPLEADOS(id_empleados)
);

create table EQUIPO(
id_equipo int primary key not null,
nombre varchar (30) not null,
no_jugadores int not null,
campeonato int,
deporte int,
foreign key (campeonato) References CAMPEONATO(id_campeonato),
foreign key (deporte) References DEPORTE(id_deporte)
);

create table ENTRENADORES(
id_entrenador int primary key not null,
nombre varchar(30) not null,
apellido varchar(30) not null,
edad int not null,
telefono int not null,
equipo int,
foreign key (equipo) references EQUIPO(id_equipo)
);

create table JUGADORES(
id_jugadores int primary key not null,
nombre varchar(30) not null,
apellido varchar(30) not null,
edad int not null,
telefono int not null,
dorsal int not null,
posicion varchar (30) not null,
equipo int,
foreign key (equipo) references EQUIPO(id_equipo)
);

create table PARTIDOS(
id_partidos int primary key not null,
nombre_equipo_local varchar (30) not null,
nombre_equipo_visitante varchar (30) not null,
fecha datetime not null,
no_jornada int not null,
arbitro_principal int not null,
no_arbitros int not null,
deporte int,
campeonato int,
foreign key (deporte) references DEPORTE(id_deporte),
foreign key (campeonato) references CAMPEONATO(id_campeonato),
foreign key (arbitro_principal) references ARBITRO(arbitros)
);

create table CANCHA(
id_cancha int primary key not null,
tipo_cancha varchar (30) not null,
partidos int,
arbitro int,
foreign key (partidos) references PARTIDOS(id_partidos),
foreign key (arbitro) references ARBITRO(arbitros)
);

Create table USUARIOS_ADMIN(
id_usuario int primary key not null,
permisos varchar (30) not null,
usuario int not null,
contraseña varchar(30) not null,
foreign key (usuario) References EMPLEADOS(id_empleados)
);

Create table USUARIOS_CLIENTE(
id_usuario int primary key not null,
usuario int not null,
contraseña varchar(30) not null,
foreign key (usuario) References ENTRENADORES(id_entrenador)

);

create table FASES(
id_fase int primary key not null,
tipo_fase varchar(30) not null,
fase int,
foreign key (fase) References CAMPEONATO(id_campeonato)
);

