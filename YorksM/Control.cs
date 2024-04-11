using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YorksM
{
    internal class Control
    {

        public string ctrlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword) || string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Apellido))
            {
                respuesta = "Debe llenar todos los campos";
            }else
            {
                if (usuario.Password == usuario.ConPassword)
                {
                    if (modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuario.Password = generarSHA1(usuario.Password);
                        modelo.registro(usuario);
                    }
                }else
                {
                    respuesta = "las contraseñas no coinciden";
                }
            }
            return respuesta;
        }
        private string generarSHA1 (string casdena)
        {
            UTF8Encoding enc = new UTF8Encoding ();
            byte[]data=enc.GetBytes(casdena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider ();   
            result = sha.ComputeHash(data); 

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > 16){
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));   

            }
            return sb.ToString();   
        }

    }
}
