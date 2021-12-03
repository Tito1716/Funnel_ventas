using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FUNNELVENTAS
{
    class Control
    {
        public string ctrlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            frmRegistro regis = new frmRegistro();
            string respuesta = "";

            if(string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword) || string.IsNullOrEmpty(usuario.Nombre) )
            {
                respuesta = "Debe llenar todos los campos";
            } else
            {
                if(usuario.Password == usuario.ConPassword)
                {
                    if (modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe, registrar nuevamente";
                    } else
                    {
                        usuario.Password = usuario.Password;
                        
                        modelo.registro(usuario);
                    }
                } else
                {
                    respuesta = "Las contraseña no coinciden";
                }
            }
            return respuesta;

        }

        public string ctrlModificar(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            frmRegistro regis = new frmRegistro();
            string respuesta = "";


            if (usuario.Id==usuario.Id) {

                modelo.modificar(usuario); }

            else
            {
                respuesta = "No existe Id";
            }
            
            return respuesta;

        }

        public string ctrleliminar(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            frmRegistro regis = new frmRegistro();
            string respuesta = "";


            if (usuario.Id == usuario.Id)
            {

                modelo.eliminar(usuario);
            }

            else
            {
                respuesta = "error";
            }

            return respuesta;

        }




        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            } else
            {
                datosUsuario = modelo.porUsuario(usuario);

                if(datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                } else
                {
                    if(datosUsuario.Password != password)
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    } else
                    {
                        Session.id = datosUsuario.Id;
                        Session.usuario = datosUsuario.Usuario;
                        Session.nombre = datosUsuario.Nombre;
                        Session.id_tipo = datosUsuario.Id_tipo;
                    }
                }
            }
            return respuesta;
        }

        

    }
}
