create database Banco1_3

use Banco1_3 
set dateformat dmy


create table clientes(
	id_cliente int identity(1,1),
	nombre varchar (20),
	apellido varchar (20),
	dni bigint
	constraint pk_idCliente primary key (id_cliente)
)

create table tiposCuentas(
	id_tipoCuenta int identity(1,1),
	nombre varchar (20)
	constraint pk_tipoCuenta primary key (id_tipoCuenta)
)

create table cuentas(
	id_cuenta int identity(1,1),
	cbu bigint,
	id_tipoCuenta int,
	id_cliente int,
	ultimo_mov datetime,
	total money,
	activo bit
	constraint pk_idCuenta primary key (id_cuenta),
	constraint fk_tipoCuenta foreign key (id_tipocuenta) references tiposCuentas (id_tipoCuenta),
	constraint fk_idCliente foreign key (id_cliente) references clientes (id_cliente)
)


create table tiposMovimientos(
	id_tipo int identity(1,1),
	tipo varchar(20)
	constraint pk_idTipo primary key (id_tipo)
)

create table Transacciones(
	id_cuenta int,
	nro_transaccion int identity(1,1),
	fecha datetime,
	total int
	activo bit
	constraint pk_nroTransaccion primary key (nro_transaccion)
	constraint fk_id_cuente foreign key (id_cuenta) references cuentas (id_cuenta)
)

create table movimientos(
	id_movimiento int identity,
	monto money,
	id_tipo int,
	nro_transaccion int
	constraint pk_idMovimiento primary key (id_movimiento)
	constraint fk_idTipo foreign key (id_tipo) references tiposMovimientos (id_tipo),
	constraint fk_nroTransaccion foreign key (nro_transaccion) references transacciones (nro_transaccion)
)




insert into tiposCuentas (nombre) values('caja de ahorros');
insert into tiposCuentas (nombre) values('cuenta corriente');
insert into tiposCuentas (nombre) values('caja sueldo');



insert into tiposMovimientos (tipo) values('Abono')
insert into tiposMovimientos (tipo) values('Retiro')


create proc sp_ingresarCliente 
	@nombre varchar(20),
	@apellido varchar(20),
	@dni bigint
as
BEGIN
insert into clientes (nombre, apellido, dni) values (@nombre, @apellido, @dni)
END



create proc sp_ingresarCuenta 
	@cbu bigint,
	@id_tipoCuenta int,
	@id_cliente int
as
BEGIN
insert into cuentas (cbu, id_tipoCuenta, id_cliente,total, activo) values (@cbu, @id_tipoCuenta, @id_cliente,0, 1)
END






create proc sp_actualizarCliente
	@nombre varchar(20),
	@apellido varchar(20),
	@dni bigint
as
BEGIN
update clientes SET nombre=@nombre, apellido=@apellido where dni=@dni
END



create proc sp_actualizarCuenta
	@cbu bigint,
	@id_tipoCuenta int,
	@id_cliente int
as
BEGIN
update cuentas set id_tipoCuenta=@id_tipoCuenta, id_cliente=@id_cliente where cbu=@cbu
END





create proc sp_eliminarCliente
	@dni bigint
as
delete from clientes where @dni=dni



CREATE PROCEDURE SP_PROXIMO_ID
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(nro_transaccion)+1  FROM transacciones);
END





create PROCEDURE SP_INSERTAR_MAESTRO 
	@id_cuenta int ,
	@total money,
	@nro_transaccion int OUTPUT
AS
BEGIN
	INSERT INTO transacciones(id_cuenta,total, fecha, activo)
    VALUES (@id_cuenta,@total, getDate(), 1);
    SET @nro_transaccion = SCOPE_IDENTITY();
END



create PROCEDURE SP_INSERTAR_DETALLE
	@monto money,
	@nro_transaccion int,
	@id_tipo int
AS
BEGIN
	INSERT INTO movimientos(monto, id_tipo, nro_transaccion)
    VALUES (@monto, @id_tipo, @nro_transaccion);
  
END





create proc sp_adjuntarTransaccion
	@total money,
	@ultimo_mov datetime,
	@id_cuenta int
as
update cuentas set total=@total, ultimo_mov=@ultimo_mov where id_cuenta=@id_cuenta





create procedure Sp_eliminarMovimiento
	@dni int
as
delete movimientos 
from movimientos m join transacciones t on m.nro_transaccion=t.nro_transaccion
join cuentas cu on t.id_cuenta=cu.id_cuenta
join clientes c  on c.id_cliente=cu.id_cliente
where c.dni = @dni



create proc Sp_eliminarTransaccionYRelacionados
	@dni int
as
delete transacciones 
from transacciones t join cuentas cu on t.id_cuenta=cu.id_cuenta
join clientes c  on c.id_cliente=cu.id_cliente
where c.dni = @dni



create  proc Sp_eliminarCuentaYRelacionados
@dni int,
@id_cliente int
as
delete cuentas 
from cuentas cu join clientes c  on c.id_cliente=cu.id_cliente
where c.dni = @dni or c.id_cliente=@id_cliente





create proc sp_darAlta
 @cbu int
as
update cuentas set activo=1 where cbu=@cbu



create proc sp_darBaja
 @cbu int
as
update cuentas set activo=0 where cbu=@cbu



create proc sp_darAltaTransaccion
	@nro int
as
update transacciones set activo=1 where nro_transaccion=@nro


create proc sp_darBajaTransaccion
	@nro int
as
update transacciones set activo=0 where nro_transaccion=@nro


create proc sp_actualizarTotal
	@monto money,
	@id_cuenta int
as
update cuentas set total=@monto where id_cuenta=@id_cuenta

