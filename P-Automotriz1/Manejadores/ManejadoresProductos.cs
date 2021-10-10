using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadesPermisos;
namespace Manejadores
{
    public class ManejadoresProductos
    {
        UsuariosAccesoDatos _usuariosAccesoDatos = new UsuariosAccesoDatos();

        public Tuple<bool, string> ValidarProductos(Productos producto)
        {
            bool error = true;
            string cadenaErrores = "";

            if (producto.CodigoBarras.Length == 0 || producto.CodigoBarras == null)
            {
                cadenaErrores = cadenaErrores + "El campo Codigo de Barras no puede ser vacio \n";
                error = false;
            }

            if (producto.Nombre.Length == 0 || producto.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo Nombre no puede ser vacio \n";
                error = false;
            }


            if (producto.Descripcion.Length == 0 || producto.Descripcion == null)
            {
                cadenaErrores = cadenaErrores + "El campo Descripcion no puede ser vacio \n";
                error = false;
            }

            if (producto.Marca.Length == 0 || producto.Marca == null)
            {
                cadenaErrores = cadenaErrores + "El campo Marca no puede ser vacio \n";
                error = false;
            }

            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }

        public void GuardarProductos(Productos productos)
        {
            try
            {
                _usuariosAccesoDatos.GuardarProductos(productos);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public List<Productos> ObtenerProductos(string filtro)
        {
            var listaContactos = _usuariosAccesoDatos.ObtenerProductos(filtro);
            return listaContactos;
        }

        public void ActualizarProductos(Productos productos)
        {
            try
            {
                _usuariosAccesoDatos.ActualizarProductos(productos);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        public void EliminarProductos(string producto)
        {
            try
            {
                _usuariosAccesoDatos.EliminarProductos(producto);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }
    }

}
