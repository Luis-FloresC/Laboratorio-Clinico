create procedure [dbo].[ListaPacientes](@inicio int,@fin int)
as begin

select 
p.RowN as '#',
CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) as 'Nombre Completo',
p.Telefono_Paciente as 'Telefono',
p.Genero as 'Genero',
p.Estatus_Us 'Activo',
p.Id_Paciente 'Código'
from (
	Select 
	ROW_NUMBER () over (Order by [Id_Paciente] desc) as 'RowN',
	*
	from Pacientes
) p
where RowN between @inicio and @fin
order by Id_Paciente desc
 
end