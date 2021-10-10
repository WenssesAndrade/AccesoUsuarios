
namespace P_Automotriz1
{
    partial class FrmVistasHerramientas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgHerramientas = new System.Windows.Forms.DataGridView();
            this.btnAgregarH = new System.Windows.Forms.Button();
            this.btnEliminarH = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHerramientas
            // 
            this.dtgHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHerramientas.Location = new System.Drawing.Point(26, 10);
            this.dtgHerramientas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgHerramientas.Name = "dtgHerramientas";
            this.dtgHerramientas.Size = new System.Drawing.Size(709, 315);
            this.dtgHerramientas.TabIndex = 0;
            this.dtgHerramientas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHerramientas_CellDoubleClick);
            // 
            // btnAgregarH
            // 
            this.btnAgregarH.Location = new System.Drawing.Point(774, 44);
            this.btnAgregarH.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarH.Name = "btnAgregarH";
            this.btnAgregarH.Size = new System.Drawing.Size(185, 28);
            this.btnAgregarH.TabIndex = 1;
            this.btnAgregarH.Text = "Agregar Herramientas";
            this.btnAgregarH.UseVisualStyleBackColor = true;
            this.btnAgregarH.Click += new System.EventHandler(this.btnAgregarH_Click);
            // 
            // btnEliminarH
            // 
            this.btnEliminarH.Location = new System.Drawing.Point(774, 136);
            this.btnEliminarH.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarH.Name = "btnEliminarH";
            this.btnEliminarH.Size = new System.Drawing.Size(185, 28);
            this.btnEliminarH.TabIndex = 2;
            this.btnEliminarH.Text = "Eliminar Herramientas";
            this.btnEliminarH.UseVisualStyleBackColor = true;
            this.btnEliminarH.Click += new System.EventHandler(this.btnEliminarH_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(774, 236);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(185, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmVistasHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 336);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarH);
            this.Controls.Add(this.btnAgregarH);
            this.Controls.Add(this.dtgHerramientas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVistasHerramientas";
            this.Text = "FrmVistasHerramientas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHerramientas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAgregarH;
        public System.Windows.Forms.Button btnEliminarH;
        public System.Windows.Forms.DataGridView dtgHerramientas;
    }
}