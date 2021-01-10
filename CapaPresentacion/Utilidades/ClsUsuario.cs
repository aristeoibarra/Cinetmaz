using CapaNegocio.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Utilidades
{
    class ClsUsuario
    {
        static Nusuario nusuario = new Nusuario();
        public static bool existeSesion = false;
        public static string tipoUsuario = "";
        public static int idUsuario = 0;
        public static string nombre = "";
        public static string error = "";

        public static bool Login(string usuario_, string password_)
        {
            bool exito = false;
            error = "";
            try
            {
                if (nusuario.ExiteUsuario(usuario_, password_).Count() > 0)
                {
                    foreach (var item in nusuario.ExiteUsuario(usuario_, password_))
                    {                     
                        idUsuario = item.CveUsuario;
                        nombre = item.NombreUsuario;
                        tipoUsuario = item.TipoUsuario;
                        existeSesion = true;
                    }                 
                    exito = true;
                }
                else
                {
                    error = "Usuario o password incorrecto";
                }
            }
            catch (Exception ex)
            {
                error = "ERROR SISTEMA " + ex.Message;
            }

            return exito;
        }

        public static bool Salir()
        {
            bool exito = false;
            error = "";
            try
            {
                idUsuario = 0;
                nombre = "";
                tipoUsuario = "";
                existeSesion = false;

                exito = true;

            }
            catch (Exception ex)
            {
                error = "ERROR SISTEMA " + ex.Message;
            }

            return exito;
        }
    }
}
