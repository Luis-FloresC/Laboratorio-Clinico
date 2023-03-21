create procedure [dbo].[Editar_Usuario]
(
  @Nombre_us VARCHAR(255),
  @Dni_Us nvarchar(30),
  @Contrasenia_Us nvarchar(50),
  @Correo_Us VARCHAR(255),
@mensaje nvarchar(150) output
)
as
begin

declare @encriptacion VARBINARY(MAX) = (SELECT ENCRYPTBYPASSPHRASE('password', @Contrasenia_Us))

if(exists (select * from [dbo].[Medicos] where Dni = @Dni_Us) or exists (Select * from [dbo].[Empleados] where Dni_Empleado = @Dni_Us))


IF(exists(Select * from [dbo].[Usuarios] where Dni_Us = @Dni_Us))
begin

update Usuarios set Correo_Us = @Correo_Us,Nombre_Us=@Nombre_us,Contrasenia_Us = @encriptacion where  Dni_Us = @Dni_Us

set @mensaje = 'Usuario Actualizado Con Exito'
end
ELSE

set @mensaje = 'Usuario no existente en nuestros registros'

else


set @mensaje = 'Numero de Identidad no se encuentra registrado en la base de datos'

end