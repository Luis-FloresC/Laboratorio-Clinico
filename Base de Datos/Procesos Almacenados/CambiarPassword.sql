create procedure [dbo].[CambiarPassword](@id int,@password nvarchar(50),@mensaje nvarchar(150) output)
as begin

declare @encriptacion VARBINARY(MAX) = (SELECT ENCRYPTBYPASSPHRASE('password', @password))

if(exists(select * from Usuarios where id_usuario = @id))
begin
update Usuarios set Contrasenia_Us = @encriptacion where id_usuario = @id

set @mensaje = 'Contraseña Actualizada Correctamente.'

end
else begin

set @mensaje = 'Usuario no Encontrado.'

end

end