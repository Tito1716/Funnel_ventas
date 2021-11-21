create database funnel_ventas2;

use funnel_ventas2;

create table tipo_usuario(
id_tipo_usuario int primary key not null auto_increment,
nombre_tipo_usuario varchar(50)
);

create table tipo_gestion(
id_tipo_gestion int primary key not null auto_increment,
nombre_tipo_gestion varchar(50)
);

create table tipo_clase(
id_tipo_clase int primary key not null auto_increment,
nombre_tipo_clase varchar(50)
);

create table tipo_estado(
id_tipo_estado int primary key not null auto_increment,
nombre_tipo_estado varchar(50)
);


create table prox_gestion(
id_tipo_gestion int primary key not null auto_increment,
nombre_tipo_gestion varchar(50)
);

create table tipo_equipo(
id_tipo_equipo int primary key not null auto_increment,
nombre_tipo_equipo varchar(50)
);

create table tipo_marca(
id_tipo_marca int primary key not null auto_increment,
nombre_tipo_marca varchar(50)
);

create table tipo_enlace(
id_tipo_enlace int primary key not null auto_increment,
nombre_tipo_enlace varchar(50)
);
create table tipo_ancho(
id_tipo_ancho int primary key not null auto_increment,
nombre_tipo_ancho varchar(50)
);

create table tipo_consultoria(
id_tipo_consultoria int primary key not null auto_increment,
nombre_tipo_consultoria varchar(50)
);
create table tipo_consultoria2(
id_tipo_consultoria2 int primary key not null auto_increment,
nombre_tipo_consultoria2 varchar(50)
);

create table usuario(
id_usuario int primary key not null auto_increment,
nombre varchar(50),
password varchar(10),
tipo_usuario int
);

create table ventas(
id_venta int not null primary key auto_increment,
nombre_cliente varchar(100),
Ejecutivo_Cuentas varchar(100),
tipo_gestion int,
tipo_estado int,
prox_Gestion int,
fecha_inicial varchar(100),
cantidad_equipo int,
tipo_equipo int,
marca_equipo int,
detalle_equipo varchar(10),
monto_equipo int,
cantidad_enlace int,
tipo_enlace int,
tipo_ancho int,
detalle_enlace varchar(10),
monto_enlace int,
cantidad_consultoria int,
tipo_consultoria int,
tipo_consultoria2 int,
detalle_consultoria varchar(10),
monto_consultoria int,
total int
);

alter table usuario add foreign key (tipo_usuario) references tipo_usuario(id_tipo_usuario);

alter table ventas add foreign key(tipo_gestion) references tipo_gestion(id_tipo_gestion);
alter table ventas add foreign key(prox_Gestion) references prox_gestion(id_tipo_gestion);
alter table ventas add foreign key(tipo_estado) references tipo_estado(id_tipo_estado);
alter table ventas add foreign key(tipo_equipo) references tipo_equipo(id_tipo_equipo);
alter table ventas add foreign key(marca_equipo) references tipo_marca(id_tipo_marca);
alter table ventas add foreign key(tipo_enlace) references tipo_enlace(id_tipo_enlace);
alter table ventas add foreign key(tipo_ancho) references tipo_ancho(id_tipo_ancho);
alter table ventas add foreign key(tipo_consultoria) references tipo_consultoria(id_tipo_consultoria);
alter table ventas add foreign key(tipo_consultoria2) references tipo_consultoria2(id_tipo_consultoria2);
