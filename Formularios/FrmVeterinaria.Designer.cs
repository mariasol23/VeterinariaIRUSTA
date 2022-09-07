namespace VeterinariaIRUSTA
{
    partial class FrmVeterinaria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeterinaria));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dgvAtenciones = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarAtencion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionAtencion = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtNombreMascota
            // 
            resources.ApplyResources(this.txtNombreMascota, "txtNombreMascota");
            this.txtNombreMascota.Name = "txtNombreMascota";
            // 
            // txtEdad
            // 
            resources.ApplyResources(this.txtEdad, "txtEdad");
            this.txtEdad.Name = "txtEdad";
            // 
            // cboTipo
            // 
            resources.ApplyResources(this.cboTipo, "cboTipo");
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Name = "cboTipo";
            // 
            // dgvAtenciones
            // 
            resources.ApplyResources(this.dgvAtenciones, "dgvAtenciones");
            this.dgvAtenciones.AllowUserToAddRows = false;
            this.dgvAtenciones.AllowUserToDeleteRows = false;
            this.dgvAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ColDescripcion,
            this.ColFecha,
            this.ColImporte,
            this.ColAccion});
            this.dgvAtenciones.Name = "dgvAtenciones";
            this.dgvAtenciones.ReadOnly = true;
            this.dgvAtenciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtenciones_CellContentClick);
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            resources.ApplyResources(this.ColDescripcion, "ColDescripcion");
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            // 
            // ColFecha
            // 
            resources.ApplyResources(this.ColFecha, "ColFecha");
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColImporte
            // 
            resources.ApplyResources(this.ColImporte, "ColImporte");
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            // 
            // ColAccion
            // 
            resources.ApplyResources(this.ColAccion, "ColAccion");
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            this.ColAccion.Text = "Quitar";
            this.ColAccion.UseColumnTextForButtonValue = true;
            // 
            // btnAgregarAtencion
            // 
            resources.ApplyResources(this.btnAgregarAtencion, "btnAgregarAtencion");
            this.btnAgregarAtencion.Name = "btnAgregarAtencion";
            this.btnAgregarAtencion.UseVisualStyleBackColor = true;
            this.btnAgregarAtencion.Click += new System.EventHandler(this.btnAgregarAtencion_Click);
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtDescripcionAtencion
            // 
            resources.ApplyResources(this.txtDescripcionAtencion, "txtDescripcionAtencion");
            this.txtDescripcionAtencion.Name = "txtDescripcionAtencion";
            // 
            // dtpFecha
            // 
            resources.ApplyResources(this.dtpFecha, "dtpFecha");
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Value = new System.DateTime(2022, 9, 1, 12, 13, 9, 0);
            // 
            // txtImporte
            // 
            resources.ApplyResources(this.txtImporte, "txtImporte");
            this.txtImporte.Name = "txtImporte";
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            resources.ApplyResources(this.lstClientes, "lstClientes");
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // FrmVeterinaria
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDescripcionAtencion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarAtencion);
            this.Controls.Add(this.dgvAtenciones);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmVeterinaria";
            this.Load += new System.EventHandler(this.FrmVeterinaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtenciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DataGridView dgvAtenciones;
        private System.Windows.Forms.Button btnAgregarAtencion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionAtencion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        private System.Windows.Forms.DataGridViewButtonColumn ColAccion;
    }
}

