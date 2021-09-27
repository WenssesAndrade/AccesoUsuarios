using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Productos
    {
        private string _codigobarras;
        private string _nombre;
        private string _descripcion;
        private string _marca;

        public string CodigoBarras { get => _codigobarras; set => _codigobarras = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Marca { get => _marca; set => _marca = value; }
    }
}
