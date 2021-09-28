using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using EntidadesPermisos;

namespace P_Automotriz1
{
    public partial class Login : Form
    {
        public static ManejadoresUsuarios _usuariosManejador;
        private Usuarios _usuarios;
        public Login()
        {
            InitializeComponent();
            _usuariosManejador = new ManejadoresUsuarios();
            _usuarios = new Usuarios();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            _usuarios.Nombre = txtUsuario.Text;
            _usuarios.Contraseña = txtContraseña.Text;
            if (_usuariosManejador.ExisteUsuario(_usuarios))
            {
                if (txtUsuario.Text == "Wendy" && txtContraseña.Text == "1234")
                {
                    Menu formmenu = new Menu();
                    formmenu.Show();
                    this.Hide();

                    MessageBox.Show("bienvenido administrador");
                    formmenu.lblTipoCuenta.Text = "Administrador";
                }

                else
                {
                    Menu formmenu = new Menu();
                    formmenu.Show();
                    this.Hide();
                    formmenu.btnUsuarios.Visible = false;
                    formmenu.lblUsuario.Visible = false;


                    MessageBox.Show("Bienvenido " + txtUsuario.Text + ", tienes permisos restringidos");
                    formmenu.lblTipoCuenta.Text = "Usuario";
                }


            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro fr = new FrmRegistro();
            fr.banderaGuardar = "guardar";
            fr.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {   
            Application.Exit();
        }
    }
}
