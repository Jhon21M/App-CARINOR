--crear la base de datos
create database CARINORT

--poner en uso la base de datos
use CARINORT


--creacion de las tablas
---------------------------TABLA PRODUCTO---------------------------------------------
create table PRODUCTO(
ID_producto int identity (356901,1),
Nombre_producto varchar (40),
Caracteristica_producto varchar (60) not null,
categoria varchar (40),
Precio int); 

---------------------------TABLA PEDIDOS---------------------------------------------
create table PEDIDOS(
ID_pedidos int identity (11356,2),
ID_Cliente int,
ID_producto int,
Nombre_producto varchar (40),
Cantidad_producto int,
Caracteristica_producto varchar (60) not null,
Precio int,
Pago_inicial int,
Pago_pendiente int,
Estado varchar(30),
Fecha date,
Total_pagar int
);


---------------------------TABLA CLIENTE---------------------------------------------
create table CLIENTE (
ID_Cliente int identity (50210,3),
Nombre varchar (60),
Apellidos varchar (100),
Telefono int,
Direccion varchar (40),
Ciudad varchar (30));


drop table PEDIDOS_CLIENTE

---------------------------TABLA COMPRAS---------------------------------------------
create table COMPRAS (
ID_Compra int identity(532123,4),
Descripcion_Compra varchar (60),
Cantidad_Compra varchar (30),
Fecha date,
Total_Pago int);

drop table COMPRAS

---------------------------TABLA BODEGA---------------------------------------------
create table BODEGA (
ID_Bodega int identity (01235,5),
ID_Compra int,
Descripcion varchar (60),
Fecha date,
Cantidad varchar(30));
 

---------------------------TABLA ENVIO---------------------------------------------
create table ENVIO (
ID_Envio int identity (794321,6),
ID_Cliente int,
ID_pedidos int not null,
Direccion varchar (60),
Pago int,
Fecha_Salida date);

drop table ENVIO

---------------------------RESTRICCIONES PARA LA LLAVE PRIMARIA--------------------------------------------
ALTER TABLE PRODUCTO
ADD CONSTRAINT PK_PRODUCTO
PRIMARY KEY (ID_producto)

ALTER TABLE PEDIDOS
ADD CONSTRAINT PK_PEDIDOS
PRIMARY KEY (ID_pedidos)

ALTER TABLE CLIENTE
ADD CONSTRAINT PK_CLIENTE
PRIMARY KEY (ID_Cliente)

ALTER TABLE COMPRAS
ADD CONSTRAINT PK_COMPRAS
PRIMARY KEY (ID_Compra)

ALTER TABLE BODEGA
ADD CONSTRAINT PK_BODEGA
PRIMARY KEY (ID_Bodega)

ALTER TABLE ENVIO
ADD CONSTRAINT PK_ENVIO
PRIMARY KEY (ID_Envio,ID_pedidos)


---------------------------RESTRICCIONES PARA LA LLAVE FORANEA--------------------------------------------

ALTER TABLE BODEGA
ADD CONSTRAINT FK_COMPRAS_BODEGA
FOREIGN KEY (ID_Compra)
REFERENCES COMPRAS (ID_Compra)

ALTER TABLE ENVIO
ADD CONSTRAINT FK_PEDIDOS_ENVIO
FOREIGN KEY (ID_pedidos)
REFERENCES PEDIDOS(ID_pedidos)

ALTER TABLE ENVIO
ADD CONSTRAINT FK_CLIENTE_ENVIO
FOREIGN KEY (ID_Cliente)
REFERENCES CLIENTE (ID_Cliente)

ALTER TABLE PEDIDOS
ADD CONSTRAINT FK_PRODUCTO_PEDIDOS
FOREIGN KEY (ID_producto)
REFERENCES PRODUCTO (ID_producto)

ALTER TABLE PEDIDOS
ADD CONSTRAINT FK_CLIENTE_PEDIDOS
FOREIGN KEY (ID_Cliente)
REFERENCES CLIENTE (ID_Cliente)


---------------------------INSERTAR REGISTROS MEDIANTE PROCEDIMIENTOS TRANSACT--------------------------------------------
-----------------------------------------------------TABLA PRODUCTO

---INSERTAR REGISTROS EN LA TABLA PRODUCTO

insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Pasta de chocolate', '', 'Amargo', '40');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Chocolate', 'Redondo', 'Dulce', '20');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Chocolate', 'Cuadrado', 'Dulce', '20');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Chocolate', 'Corazon', 'Dulce', '20');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Chocolate', 'Redondo', 'Amargo', '25');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Chocolate', 'Cuadrado', 'Amargo', '25');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Chocolate', 'Corazon', 'Amargo', '25');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Bolson de chocolate', 'Redondo', 'Amargo', '70');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Bolson de chocolate', 'Cuadrado', 'Amargo', '70');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Bolson de chocolate', 'Corazon', 'Amargo', '70');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Bolson de chocolate', 'Redondo', 'Dulce', '60');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Bolson de chocolate', 'Cuadrado', 'Dulce', '60');
insert into PRODUCTO (Nombre_producto, Caracteristica_producto, categoria, Precio) values ('Bolson de chocolate', 'Corazon', 'Dulce', '60');
select * from PEDIDOS

---INSERTAR REGISTROS EN LA TABLA PEDIDOS--------------

insert into PEDIDOS (ID_producto, Nombre_producto, Cantidad_producto, Caracteristica_producto, Precio, Pago_inicial, Pago_pendiente, Estado, Fecha, Total_pagar) values ('356901', 'Pasta de chocolate', '20', '', '40', '400', '400', 'Pendiente', '20/06/2022', '800');
insert into PEDIDOS ( ID_producto, Nombre_producto, Cantidad_producto, Caracteristica_producto, Precio, Pago_inicial, Pago_pendiente, Estado, Fecha, Total_pagar) values ( '356902', 'Bolson de chocolate','30', 'Redondo, Dulce', '60', '900', '900', 'Pendiente', '22/06/2022', '1800');
insert into PEDIDOS ( ID_producto, Nombre_producto, Cantidad_producto, Caracteristica_producto, Precio, Pago_inicial, Pago_pendiente, Estado, Fecha, Total_pagar) values ( '356905', 'Chocolate', '50', 'Corazon, Amargo', '70', '1750', '1750', 'Entregado', '11/06/2022', '3500');
insert into PEDIDOS ( ID_producto, Nombre_producto, Cantidad_producto, Caracteristica_producto, Precio, Pago_inicial, Pago_pendiente, Estado, Fecha, Total_pagar) values ( '356911', 'Bolson de chocolate', '30',' Redondo, Dulce', '60','900', '900','Pendiente', '18/06/2022','1800');
insert into PEDIDOS ( ID_producto, Nombre_producto, Cantidad_producto, Caracteristica_producto, Precio, Pago_inicial, Pago_pendiente, Estado, Fecha, Total_pagar) values ( '356905', 'Chocolate','25','Redondo, Amargo', '25', '313', '312', 'Entregado', '20/05/2022', '625');



--INSERTAR REGISTROS EN LA TABLA CLIENTE--------------
insert into ClIENTE (Nombre, Apellidos, Telefono, Direccion, Ciudad) values ('Juan', 'Lopez Perez', '87452312', 'Frente al colegio Bautista siloe', 'Puerto Cabezas');
insert into ClIENTE (Nombre, Apellidos, Telefono, Direccion, Ciudad) values ('Rosa', 'Rocha Melendez', '57132911', 'Contiguo al estadio de Rosita', 'Rosita');
insert into ClIENTE (Nombre, Apellidos, Telefono, Direccion, Ciudad) values ('Maria', 'Mercado Cruz', '88349078', 'La luz', 'siuna');
insert into ClIENTE (Nombre, Apellidos, Telefono, Direccion, Ciudad) values ('Pedro', 'Martinez Obando', '85078914', 'El malecon', 'Managua');
insert into ClIENTE (Nombre, Apellidos, Telefono, Direccion, Ciudad) values ('Ramona', 'Ruiz Ortega', '54126789', 'Contiguo a la policia', 'Bonanza');
select * from CLIENTE


--INSERTAR REGISTROS EN LA TABLA COMPRAS--------------
insert into COMPRAS (Descripcion_Compra, Cantidad_Compra, Fecha, Total_Pago) values ('Azucar', '20 lbr', '05/06/2022', '340');
insert into COMPRAS (Descripcion_Compra, Cantidad_Compra, Fecha, Total_Pago) values ('Leche', '15 ltr', '05/06/2022', '150');
insert into COMPRAS (Descripcion_Compra, Cantidad_Compra, Fecha, Total_Pago) values ('Cacao', '20 lbr', '05/06/2022', '700');
select * from COMPRAS


--INSERTAR REGISTROS EN LA TABLA BODEGA------------
insert into BODEGA (ID_Compra, Descripcion, Fecha, Cantidad) values ('532123', 'Azucar', '05/06/2022', '20 lbr');
insert into BODEGA (ID_Compra, Descripcion, Fecha, Cantidad) values ('532127', 'Leche', '05/06/2022', '15 ltr');
insert into BODEGA (ID_Compra, Descripcion, Fecha, Cantidad) values ('532131', 'Cacao', '05/06/2022', '20 lbr');
insert into BODEGA (ID_Compra, Descripcion, Fecha, Cantidad) values ('532131', 'Cacao', '09/06/2022', '30 lbr');
select * from BODEGA


--INSERTAR REGISTROS EN LA TABLA ENVIO------------
insert into ENVIO (ID_Cliente, ID_pedidos, Direccion, Pago, Fecha_Salida) values ('50210', '11362', 'Frente al colegio Bautista siloe', '400', '22/06/2022');
insert into ENVIO (ID_Cliente, ID_pedidos, Direccion, Pago, Fecha_Salida) values ('50213', '11364', 'Contiguo al estadio de Rosita', '900', '24/06/2022');
insert into ENVIO (ID_Cliente, ID_pedidos, Direccion, Pago, Fecha_Salida) values ('50210', '11368', 'Frente al colegio Bautista siloe', '900', '20/06/2022');
select * from ENVIO

--ACTUALIZAR REGISTROS EN LA TABLA PRODUCTO

--ELIMINAR REGISTROS EN LA TABLA PRODUCTO

