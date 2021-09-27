using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPermisos;
namespace AccesoDatos
{
    public class UsuariosAccesoDatos
    {
        ConexionAccesoDatos _conexion;
        public UsuariosAccesoDatos()
        {

            try
            {
                _conexion = new ConexionAccesoDatos("localhost", "root", " ", "automotriz", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }
        }


        public void GuardarHerramientas(Herramientas herramientas)
        {
            try
            {
                string consulta = string.Format("insert into herramientas values('{0}','{1}','{2}','{3}')",
                    herramientas.CodigoHerramienta, herramientas.Nombre, herramientas.Medida, herramientas.Marca, herramientas.Descripcion);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }

        public void EliminarHerramientas(string herramientas)
        {
            try
            {
                string consulta = string.Format("delete from herramientas where CodigoHerramienta ='{0}'", herramientas);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }

        public void ActualizarHerramientas(Herramientas herramientas)
        {
            try
            {
                string consulta = string.Format("update herramientas set nombre = '{0}', medida = '{1}', marca = '{2}', descripcion = '{3}'",
                    herramientas.Nombre, herramientas.Medida, herramientas.Descripcion);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }

        
        public List<Herramientas> ObtenerHerramientas(string filtro)
        {
            var ListaHerramientas = new List<Herramientas>();
            var ds = new DataSet();
            string consulta = string.Format("select * from herramientas where nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "herramientas");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                //var usuario = new Usuarios();
                //usuario.Usuario = row["usuario"].ToString();
                //usuario.Contrasenia = row["contrasenia"].ToString();

                var herr = new Herramientas
                {
                    CodigoHerramienta = row["codigoherramientas"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Medida = row["medida"].ToString(),
                    Marca = row["marca"].ToString(),
                    Descripcion = row["descripcion"].ToString()
                };


                ListaHerramientas.Add(herr);

            }

            return ListaHerramientas;
        }

        //Usuarios

        public void GuardarUsuarios(Usuarios usuario)
        {
            try
            {
                string consulta = string.Format("insert into usuarios values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                usuario.IdUsuarios, usuario.Nombre, usuario.Apellidop, usuario.Apellidom, usuario.FechaNacimiento, usuario.Rfc,
                usuario.Fkaccesos);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }



        public void EliminarUsuarios(string usuario)
        {
            try
            {
                string consulta = string.Format("delete from usuarios where idusuarios ='{0}'", usuario);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }



        public void ActualizarUsuarios(Usuarios usuario)
        {
            try
            {
                string consulta = string.Format("update usuarios set nombre = '{0}', apellidop = '{1}', apellidom = '{2}', fechanacimiento = '{3}', rfc = '{4}',fkidaccesos = '{5}' where idusuarios = '{6}'", usuario.Nombre,
                usuario.Apellidop, usuario.Apellidom, usuario.FechaNacimiento, usuario.Rfc, usuario.Fkaccesos, usuario.IdUsuarios);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }
        public List<Usuarios> ObtenerUsuarios(string filtro)
        {
            var ListaUsuarios = new List<Usuarios>();
            var ds = new DataSet();
            string consulta = string.Format("select * from usuarios where Nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "usuarios");



            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var uru = new Usuarios
                {
                    IdUsuarios = int.Parse(row["idusuario"].ToString()),
                    Nombre = row["nombre"].ToString(),
                    Apellidop = row["apellidop"].ToString(),
                    Apellidom = row["apellidom"].ToString(),
                    FechaNacimiento = row["fechanacimiento"].ToString(),
                    Rfc = row["rfc"].ToString(),
                    Fkaccesos = row["fkidaccesos"].ToString(),
                };
                ListaUsuarios.Add(uru);
            }
            return ListaUsuarios;
        }


        //Productos

        public void GuardarProductos(Productos producto)
        {
            try
            {
                string consulta = string.Format("insert into productos values('{0}','{1}','{2}','{3}')",
                producto.CodigoBarras, producto.Nombre, producto.Descripcion, producto.Marca);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }



        public void EliminarProductos(string producto)
        {
            try
            {
                string consulta = string.Format("delete from productos where codigobarras ='{0}'", producto);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la eliminacion" + ex.Message);
            }
        }



        public void ActualizarProductos(Productos producto)
        {
            try
            {
                string consulta = string.Format("update productos set nombre = '{0}', descripcion = '{1}', marca = '{2}', where codigobarras = '{3}'", producto.Nombre,
                producto.Descripcion, producto.Marca, producto.CodigoBarras);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la actualizacion" + ex.Message);
            }
        }



        public List<Productos> ObtenerProductos(string filtro)
        {
            var ListaProductos = new List<Productos>();
            var ds = new DataSet();
            string consulta = string.Format("select * from productos where Nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "productos");



            var dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var producto = new Productos
                {
                    CodigoBarras = row["codigobarras"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Marca = row["marca"].ToString(),
                };
                ListaProductos.Add(producto);
            }
            return ListaProductos;
        }



    }
}
