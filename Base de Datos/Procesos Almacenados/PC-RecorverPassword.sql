create procedure RecoverPassword(@Nombre_user nvarchar)
as begin

declare @NumeroDesde int = 1000 ;
declare @NumeroHasta int = 9999 ;
declare @Dni nvarchar(50) = (Select Dni_Us from Usuarios where Nombre_us = @Nombre_user or Dni_Us = @Nombre_user)


if(exists(select * from Usuarios where Nombre_Us=@Nombre_user or Dni_Us=@Nombre_user))
begin

update Usuarios set Pin_Recuperacion = (SELECT ROUND(((@NumeroHasta - @NumeroDesde) * RAND() + @NumeroDesde), 0)) , Fecha_Actualizacion = GETDATE(),Fecha_Gen_Pin = GETDATE() where Nombre_Us=@Nombre_user or Dni_Us=@Nombre_user

IF(exists (Select * from Medicos where Dni = @Dni))
begin 

select CONCAT(m.Nombres,' ',m.Apellidos) as 'nombre',u.Correo_Us,u.Pin_Recuperacion,u.id_usuario from Medicos m
join Usuarios u on u.Dni_Us = m.Dni
where u.Dni_Us = @Dni;

end
else begin

select CONCAT(m.Nombre_Empleado,' ',m.Apellido_Empleado) as 'nombre',u.Correo_Us,u.Pin_Recuperacion,u.id_usuario from Empleados m
join Usuarios u on u.Dni_Us = m.Dni_Empleado
where u.Dni_Us = @Dni;

end



end 


end

