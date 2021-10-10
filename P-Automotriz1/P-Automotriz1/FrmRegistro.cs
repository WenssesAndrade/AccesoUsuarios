using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPermisos;
using Manejadores;

namespace P_Automotriz1
{
    public partial class FrmRegistro : Form
    {
        private Usuarios usuario;
        private ManejadoresUsuarios _manejaUsuario;
        public string banderaGuardar;

        public FrmRegistro()
        {
            InitializeComponent();
            usuario = new Usuarios();
            _manejaUsuario = new ManejadoresUsuarios();
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarUsuario();
                Close();
            }
            else
            {
                ActualizarUsuario();
                Close();
            }

        }

        private void GuardarUsuario()
        {
            usuario.IdUsuarios = 0;
            usuario.Nombre = txtNombre.Text;
            usuario.Apellidop = txtApellidoP.Text;
            usuario.Apellidom = txtApellidoM.Text;
            usuario.FechaNacimiento = tctFechaNacimiento.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Rfc = txtRFC.Text;
            usuario.Fkaccesos = "Usuario";

            var valida = _manejaUsuario.ValidarUsuarios(usuario);

            if (valida.Item1)
            {
                _manejaUsuario.GuardarUsuarios(usuario);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }


        private void ActualizarUsuario()
        {
            _manejaUsuario.ActualizarUsuarios(new Usuarios
            {
                IdUsuarios = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Apellidop = txtApellidoP.Text,
                Apellidom = txtApellidoM.Text,
                FechaNacimiento =tctFechaNacimiento.Text,
                Rfc = txtRFC.Text,
                Contraseña = txtContraseña.Text,
                Fkaccesos = cmbEstado.Text
            });
        }
    }
  
}
