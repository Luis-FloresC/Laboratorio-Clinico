create procedure [dbo].[Registrar_Usuario]
(
  @Nombre_us VARCHAR(255),
  @Dni_Us nvarchar(30),
  @Contrasenia_Us nvarchar(50),
  @Correo_Us VARCHAR(255),
  @Id_Rol INT,
@mensaje nvarchar(150) output
)
as
begin

declare @encriptacion VARBINARY(MAX) = (SELECT ENCRYPTBYPASSPHRASE('password', @Contrasenia_Us))

if(exists (select * from [dbo].[Medicos] where Dni = @Dni_Us) or exists (Select * from [dbo].[Empleados] where Dni_Empleado = @Dni_Us))


IF(not exists(Select * from [dbo].[Usuarios] where Dni_Us = @Dni_Us))
begin
insert into Usuarios(Nombre_Us,Dni_Us,[Contrasenia_Us],[Estatus_Us],[Correo_Us],[Id_Rol]) values
(@Nombre_us,@Dni_Us,@encriptacion,1,@Correo_Us,@Id_Rol)
set @mensaje = 'Usuario Registrado Con Exito'
end
ELSE

set @mensaje = 'Usuario Existente en nuestros registros'

else


set @mensaje = 'Numero de Identidad no se encuentra registrado en la base de datos'

end




