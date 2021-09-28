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
    public partial class FrmVistasHerramientas : Form
    {
        public static ManejadoresHerramientas _manejaherra;
        private Herramientas _herramienta;
        public FrmVistasHerramientas()
        {
            InitializeComponent();
            _manejaherra = new ManejadoresHerramientas();
            _herramienta = new Herramientas();
        }

        private void FrmVistasHerramientas_Load(object sender, EventArgs e)
        {
            CargarHerramientas("");
        }

        private void btnAgregarH_Click(object sender, EventArgs e)
        {
            FrmCrearHerramientas fc = new FrmCrearHerramientas(this);
            fc.banderaGuardar = "guardar";
            fc.UpdateEventHandler += Fc_UpdateEventHandler;
            fc.ShowDialog();
        }

        private void Fc_UpdateEventHandler(object sender, FrmCrearHerramientas.UpdateEventArgs args)
        {
            CargarHerramientas("");
        }

        public void CargarHerramientas(string filtro)
        {
            dtgHerramientas.DataSource = _manejaherra.ObtenerHerramientas(filtro);
        }

        private void dtgHerramientas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCrearHerramientas fc = new FrmCrearHerramientas(this);
            fc.banderaGuardar = "actualizar";


            fc.txtCodigo.Text = dtgHerramientas.CurrentRow.Cells["codigoherramienta"].Value.ToString();
            fc.txtMedida.Text = dtgHerramientas.CurrentRow.Cells["medida"].Value.ToString();
            fc.txtNombre.Text = dtgHerramientas.CurrentRow.Cells["nombre"].Value.ToString();
            fc.txtDesc.Text = dtgHerramientas.CurrentRow.Cells["descripcion"].Value.ToString();
            fc.txtMarca.Text = dtgHerramientas.CurrentRow.Cells["marca"].Value.ToString();
            fc.txtCodigo.Enabled = false;

            fc.ShowDialog();
        }

        private void Eliminar()
        {
            if (MessageBox.Show("Desea eliminar la herramienta seleccionada", "Eliminar categoria", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoria = dtgHerramientas.CurrentRow.Cells["nombre"].Value.ToString();
                _manejaherra.EliminarHerramientas(categoria);
            }


        }

        private void btnEliminarH_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
