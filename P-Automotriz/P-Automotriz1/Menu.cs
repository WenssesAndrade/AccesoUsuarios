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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (lblTipoCuenta.Text == "Administrador")
            {
                FrmVistasUsuarios fvu = new FrmVistasUsuarios();
                fvu.ShowDialog();
            }
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            if (lblTipoCuenta.Text == "Usuario")
            {
                FrmVistasHerramientas fv = new FrmVistasHerramientas();
                fv.btnEliminarH.Visible = false;
                fv.dtgHerramientas.Enabled = false;
                fv.ShowDialog();
            }


            else
            {
                FrmVistasHerramientas fv = new FrmVistasHerramientas();
                fv.ShowDialog();
            }

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (lblTipoCuenta.Text == "Usuario")
            {
                FrmVistasProductos fv = new FrmVistasProductos();
                fv.btnEliminarP.Visible = false;
                fv.dtgProductos.Enabled = false;
                fv.ShowDialog();
            }



            else
            {
                FrmVistasProductos fv = new FrmVistasProductos();

                fv.ShowDialog();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
 
