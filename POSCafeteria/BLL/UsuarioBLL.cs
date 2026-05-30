using POSCafeteria.DAL;
using POSCafeteria.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSCafeteria.BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL _usuarioDAL = new UsuarioDAL();

        public Usuario? IniciarSesion(string nombreUsuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(clave))
            {
                throw new ArgumentException("El usuario y la constraseña son obligatorios.");
            }
            return _usuarioDAL.ValidarLogin(nombreUsuario, clave);
        }

        public List<Usuario> ListarUsuarios()
        {
            return _usuarioDAL.ObtenerTodos();
        }

        public bool GuardarUsuario(Usuario obj)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(obj.NombreUsuario) || string.IsNullOrWhiteSpace(obj.Clave) || string.IsNullOrWhiteSpace(obj.Rol) || string.IsNullOrWhiteSpace(obj.NombreCompleto))
            {
                throw new ArgumentException("El Nombre de Usuario, el Nombre Completo, la Contraseña y el Rol son obligatorios.");
            }

            if (obj.IdUsuario == 0)
            {
                // Si el ID es 0, significa que es un usuario nuevo
                return _usuarioDAL.Insertar(obj);
            }
            else
            {
                // Si ya tiene ID, es una actualización
                return _usuarioDAL.Actualizar(obj);
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            if (idUsuario <= 0)
            {
                throw new ArgumentException("Debe seleccionar un usuario válido para eliminar.");
            }
            return _usuarioDAL.Eliminar(idUsuario);
        }
    }
}
