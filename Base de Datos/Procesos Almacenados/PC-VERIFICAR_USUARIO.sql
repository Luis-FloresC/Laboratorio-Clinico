
create procedure Verificar_Usuario(@Id_Usuario int,@user nvarchar(50),@password nvarchar(50))
as begin

declare @Contraseña_Encriptada varbinary(max) = (select Contrasenia_Us from Usuarios R where R.Nombre_us = @user or R.Dni_Us = @user)
declare @Contra nvarchar(50) = CONVERT(nvarchar(MAX), DECRYPTBYPASSPHRASE('password', @Contraseña_Encriptada)) 
declare @Dni nvarchar(50) = (Select Dni_Us from Usuarios where Nombre_us = @user or Dni_Us = @user)

if @Contra = @password 


Select * from [dbo].[Usuarios] R where R.Nombre_us = @user or R.Dni_Us = @user and R.Dni_Us =  @Dni 


end

