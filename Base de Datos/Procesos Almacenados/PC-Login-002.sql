create procedure Login_Lab
(
@user nvarchar(50),
@contrasenia nvarchar(50)

)
as begin

declare @Contraseña_Encriptada varbinary(max) = (select Contrasenia_Us from Usuarios R where R.Nombre_us = @user or R.Dni_Us = @user)
declare @Contra nvarchar(50) = CONVERT(nvarchar(MAX), DECRYPTBYPASSPHRASE('password', @Contraseña_Encriptada)) 
declare @Dni nvarchar(50) = (Select Dni_Us from Usuarios where Nombre_us = @user or Dni_Us = @user)
IF (exists (select Contrasenia_Us from Usuarios R where R.Nombre_us = @user or R.Dni_Us = @user))



IF @contrasenia = @Contra
begin

update Usuarios set Intentos_Us = 0, Fecha_Actualizacion = GETDATE()  where Dni_Us = @Dni

IF(exists (Select * from Medicos where Dni = @Dni))
begin 

Select 
m.Id_Medico as 'id_Empleado',
m.Nombres as 'nombres',
m.Apellidos as 'apellidos',
m.Dni as 'dni_emp',
m.Fecha_Nacimiento as 'fecha_nac',
m.Genero as 'genero',
m.Telefono  'telefono',
m.Direccion 'direccion',
m.Fecha_Registro as 'fecha_reg',
m.Fecha_Actualizacion as 'fecha_act',
u.Nombre_us as 'nombre_us',
u.Dni_Us as 'dni_us',
@Contra as 'contrasenia_us',
u.Estatus_Us as 'estado_us',
u.Fecha_Registro as 'fecha_reg_us',
u.Fecha_Actualizacion as 'fecha_act_us',
u.Correo_Us as 'correo_us',
r.Id_Rol as 'id_rol',
r.Nombre_rol as 'cargo'
from Medicos m
join Usuarios u on u.Dni_Us = m.Dni
join Roles r on r.Id_Rol = u.Id_Rol
where m.Dni = @Dni

end
else begin

Select 
e.Id_Empleado as 'id_Empleado',
e.Nombre_Empleado as 'nombres',
e.Apellido_Empleado as 'apellidos',
e.Dni_Empleado as 'dni_emp',
e.Fecha_Nacimiento as 'fecha_nac',
e.Genero as 'genero',
e.Telefono_Empleado  'telefono',
e.Direccion_Empleado 'direccion',
e.Fecha_Registro as 'fecha_reg',
e.Fecha_Actualizacion as 'fecha_act',
u.Nombre_us as 'nombre_us',
u.Dni_Us as 'dni_us',
@Contra as 'contrasenia_us',
u.Estatus_Us as 'estado_us',
u.Fecha_Registro as 'fecha_reg_us',
u.Fecha_Actualizacion as 'fecha_act_us',
u.Correo_Us as 'correo_us',
r.Id_Rol as 'id_rol',
r.Nombre_rol as 'cargo'
from Empleados e
join Usuarios u on u.Dni_Us = e.Dni_Empleado
join Roles r on r.Id_Rol = u.Id_Rol
where e.Dni_Empleado = @Dni
end



end
else
begin

update Usuarios set Intentos_Us = Intentos_Us + 1, Fecha_Actualizacion = GETDATE()  where Dni_Us = @Dni


end









end
