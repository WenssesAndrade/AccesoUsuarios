using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Usuarios
    {
        private int _idusuarios;
        private string _nombre;
        private string _apellidop;
        private string _apellidom;
        private string _fechanacimiento;
        private string _rfc;
        private string _contraseña;
        private string _fkaccesos;

        public int IdUsuarios { get => _idusuarios; set => _idusuarios = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Apellidop { get => _apellidop; set => _apellidop = value; }
        public string Apellidom { get => _apellidom; set => _apellidom = value; }
        public string FechaNacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
        public string Rfc { get => _rfc; set => _rfc = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public string Fkaccesos { get => _fkaccesos; set => _fkaccesos = value; }
    }
}
