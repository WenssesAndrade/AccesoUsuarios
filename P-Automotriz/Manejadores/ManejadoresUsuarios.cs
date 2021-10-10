using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadesPermisos;
namespace Manejadores
{
    public class ManejadoresUsuarios
    {
        UsuariosAccesoDatos _usuariosAccesoDatos = new UsuariosAccesoDatos();

        public Tuple<bool, string> ValidarUsuarios(Usuarios usuarios)
        {
            bool error = true;
            string cadenaErrores = "";

            if (usuarios.IdUsuarios == null)
            {
                cadenaErrores = cadenaErrores + "El campo ID no puede ser vacio \n";
                error = false;
            }

            if (usuarios.Nombre.Length == 0 || usuarios.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo Nombre no puede ser vacio \n";
                error = false;
            }

            if (usuarios.Apellidop.Length == 0 || usuarios.Apellidop == null)
            {
                cadenaErrores = cadenaErrores + "El campo del Apellido paterno no puede ser vacio \n";
                error = false;
            }

            if (usuarios.Apellidom.Length == 0 || usuarios.Apellidom == null)
            {
                cadenaErrores = cadenaErrores + "El campo del Apellido materno no puede ser vacio \n";
                error = false;
            }

            if (usuarios.FechaNacimiento.Length == 0 || usuarios.FechaNacimiento == null)
            {
                cadenaErrores = cadenaErrores + "El campo de la fecha de nacimiento no puede ser vacio \n";
                error = false;
            }

            if (usuarios.Rfc.Length == 0 || usuarios.Rfc == null)
            {
                cadenaErrores = cadenaErrores + "El campo RFC no puede ser vacio \n";
                error = false;
            }

            if (usuarios.Fkaccesos.Length == 0 || usuarios.Fkaccesos == null)
            {
                cadenaErrores = cadenaErrores + "El campo de Accesos no puede ser vacio \n";
                error = false;
            }

           

            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public void GuardarUsuarios(Usuarios usuarios)
        {
            try
            {
                _usuariosAccesoDatos.GuardarUsuarios(usuarios);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public List<Usuarios> ObtenerUsuarios(string filtro)
        {
            var listaContactos = _usuariosAccesoDatos.ObtenerUsuarios(filtro);
            return listaContactos;
        }

        public void ActualizarUsuarios(Usuarios usuarios)
        {
            try
            {
                _usuariosAccesoDatos.ActualizarUsuarios(usuarios);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public void EliminarUsuarios(string usuarios)
        {
            try
            {
                _usuariosAccesoDatos.EliminarUsuarios(usuarios);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public bool ExisteUsuario(Usuarios usuario)
        {
            var existe = _usuariosAccesoDatos.ExisteUsuario(usuario);
            return existe;
        }

    }
}
