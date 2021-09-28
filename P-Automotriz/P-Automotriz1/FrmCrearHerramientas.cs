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
    public partial class FrmCrearHerramientas : Form
    {
        private ManejadoresHerramientas _manejaherra;
        private Herramientas _herramienta;

        public static FrmVistasHerramientas fr = new FrmVistasHerramientas();
        public string banderaGuardar;
        public FrmCrearHerramientas(FrmVistasHerramientas registro)
        {
            InitializeComponent();
            _manejaherra = new ManejadoresHerramientas();
            _herramienta = new Herramientas();
        }


        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregard()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }


        private void GuardarHerramienta()
        {
            _herramienta.CodigoHerramienta = txtCodigo.Text;
            _herramienta.Nombre = txtNombre.Text;
            _herramienta.Medida = txtMedida.Text;
            _herramienta.Marca = txtMarca.Text;
            _herramienta.Descripcion = txtDesc.Text;



            var valida = _manejaherra.ValidarHerramientas(_herramienta);

            if (valida.Item1)
            {
                _manejaherra.GuardarHerramientas(_herramienta);
            }

            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FrmCrearHerramientas_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ActualizarHerramientas()
        {
            _manejaherra.ActualizarHerramientas(new Herramientas
            {
                CodigoHerramienta = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Medida = txtMarca.Text,
                Marca = txtMarca.Text,
                Descripcion = txtDesc.Text

            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarHerramienta();
                Agregard();
                Close();
            }

            else
            {
                ActualizarHerramientas();
                Close();
            }
        }
    }
}
