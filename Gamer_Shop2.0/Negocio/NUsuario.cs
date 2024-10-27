﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gamer_Shop2._0.Negocio
{
    internal class NUsuario
    {
        DUsuario dUsuario = new DUsuario();
        public void NAgregarUsuario(string nombre, string apellido, string cuil, string user, string password, string email, int tipoUsuario, string photoFilePath)
        {

            Usuario nuevoUsuario = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                CUIL = cuil,
                Nombre_usuario = user,
                Contraseña = password,
                Correo = email,
                photoFilePath = photoFilePath,
                ID_TipoUsuario = tipoUsuario
    };

            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.DAgregarUsuario(nuevoUsuario);
            }
        }

        public void listaUsuariosActivos(DataGridView grid)
        {
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.getUsuariosActivos(grid);
            }
        }

        public void NModificarUsuario(string nombre, string apellido, string cuil, string user, string password, string email, int tipoUsuario)
        {
            Usuario Usuario = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                CUIL = cuil,
                Nombre_usuario = user,
                Contraseña = password,
                Correo = email,
                ID_TipoUsuario = tipoUsuario
            };
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.DModificarUsuario(Usuario);
            }
        }

        public void NModificarPerfil(string nombre, string apellido,  string user, string password, string email, string photoPath)
        {
            Usuario Usuario = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                Nombre_usuario = user,
                Contraseña = password,
                Correo = email,
                photoFilePath = photoPath
            };
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.DModificarUsuario(Usuario);
            }
        }

        public Usuario GetUsuario(string cuil)
        {
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                return dUsuario.getUsuario(cuil);
            }
        }

        public void NEliminarUsuario(string cuil)
        {
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.DEliminarUsuario(cuil);
            }
        }
    }
}