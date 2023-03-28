using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public static class Cache_Usuario
    {

        //Prpiedades del usuario que inicio sesion
        public static int IdEmpleado { get; set; }
        public static int IdUsuario { get; set; }
        public static string NombreEmpleado { get; set; }
        public static string ApellidoEmpleado { get; set; }
        public static string DniEmpleado { get; set; }
        public static DateTime FechaNacimientoEmpleado { get; set; }
        public static string GeneroEmpleado { get; set; }
        public static string TelefonoEmpleado { get; set; }
        public static string DireccionEmpleado { get; set; }
        public static DateTime FechaRegistroEmpleado { get; set; }
        public static DateTime FechaActualizacionEmpleado { get; set; }

        public static string NombreUsuario { get; set; }
        public static string DniUsuario { get; set; }
        public static bool EstadoUsuario { get; set; }
        public static string CorreoElectronicoUsuario { get; set; }
        public static string ContraseniaUsuario { get; set; }
        public static DateTime FechaRegistroUsuario { get; set; }
        public static DateTime FechaActualizacionUsuario { get; set; }


        public static int IdRol { get; set; }
        public static string Cargo { get; set; }
        public static List<String> Permisos = new List<String>();



        //Prpiedades para editar un Usuario

        /*
         * [id_usuario]
                                                  ,[Nombre_Us]
                                                  ,[Dni_Us]
                                                  ,CONVERT(nvarchar(MAX), DECRYPTBYPASSPHRASE('password', Contrasenia_Us)) 'Contrasenia'
                                                  ,[Estatus_Us]
                                                  ,[Correo_Us]
                                                  ,[Intentos_Us]
                                                  ,[Pin_Recuperacion]
                                                  ,[Fecha_Gen_Pin]
                                                  ,[Id_Rol]
                                                  ,[Fecha_Bloqueo]
                                                  ,[Motivo_Bloqueo]
                                                  ,[Fecha_Desbloqueo]
                                                  ,[Descripcion_Bloqueo]
                                                  ,[Fecha_Registro]
                                                  ,[Fecha_Actualizacion]
         */


        public static int IdUsuarioEdit { get; set; }
        public static string NombreUs { get; set; }
        public static string DniUs { get; set; }
        public static string MotivoBloqueoUs { get; set; }
        public static string DescripcionBloqueoUs { get; set; }
        public static bool EstadoUs { get; set; }
        public static int IntentosUs { get; set; }
        public static string PinUs { get; set; }
        public static DateTime FechaGenPinUs { get; set; }
        public static DateTime FechaBloqueoUs { get; set; }
        public static DateTime FechaDesbloqueoUs { get; set; }
        public static string CorreoElectronicoUs { get; set; }
        public static string ContraseniaUs { get; set; }
        
        public static DateTime FechaRegistroUs  { get; set; }
        public static DateTime FechaActualizacionUs { get; set; }
        public static int IdRolUs { get; set; }


    }
}
