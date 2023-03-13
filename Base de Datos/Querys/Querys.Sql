use Laboratorio_clinico;
Go

insert into Roles(Nombre_rol) values ('Administrador'),('Medico'),('Recepcionista');
go

insert into Permisos(Permiso) values ('Acceso Total');
go

insert into Roles_Permisos(Id_Rol,Id_Permiso) values ((select Id_Rol from Roles where Nombre_rol = 'Administrador'),(select Id_Permiso from Permisos where Permiso = 'Acceso Total'));
go

insert into Empleados(
	Nombre_Empleado ,
	Apellido_Empleado, 
	Dni_Empleado,
	Fecha_Nacimiento, 
	Direccion_Empleado, 
	Telefono_Empleado ,
	Genero 
)values(
	'Jose Daniel',
	'Rodriguez',
	'0703199704555',
	'2000-10-04',
	'La Reforma',
	'98765432',
	'Masculino'
);
go



DECLARE	@return_value int,
		@mensaje nvarchar(150)

EXEC	@return_value = [dbo].[Registrar_Usuario]
		@Nombre_us = N'Daniel',
		@Dni_Us = N'0703199704555',
		@Contrasenia_Us = N'Admin1234',
		@Correo_Us = N'Jose-DanielR@unicah.edu',
		@Id_Rol = 1,
		@mensaje = @mensaje OUTPUT

SELECT	@mensaje as N'@mensaje'

SELECT	'Return Value' = @return_value

GO