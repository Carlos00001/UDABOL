﻿using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Util;

namespace Negocio
{
    public class LoginConsola : ILogin
    {
        public KeyValuePair<Usuario, List<ModeloBase>> LoginUsuario( String _cadenaUsuario,String _cadenaContrasena) {
            System.Console.Out.WriteLine("Se esta Autenticando espere por favor...");
            Usuario _usuario = AutenticacionUsuario(_cadenaUsuario, _cadenaContrasena);
            Rol _rol = VerificarRolUsuario(_usuario);
            return new KeyValuePair<Usuario, List<ModeloBase>>(_usuario, MostrarManejadorTareas(_rol));
        }

        public Usuario AutenticacionUsuario(string usuario, string contrasena)
        {
            String _cadenaEncriptada = Utilidades.encriptarContrasena(usuario,contrasena);

            return Usuario.ObtenerUnUsuario(usuario, _cadenaEncriptada);
        }

        public List<ModeloBase> MostrarManejadorTareas(Rol rol)
        {
            ManejadorTareas
            return null;
        }

        public Rol VerificarRolUsuario(Usuario usuario)
        {
            if (usuario != null) {
                return usuario.ObtenerRol();
            }
            return null;

        }
    }

}
