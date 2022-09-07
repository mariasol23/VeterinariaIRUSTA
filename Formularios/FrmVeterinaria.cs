using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaIRUSTA.Datos;
using VeterinariaIRUSTA.Entidades;

namespace VeterinariaIRUSTA
{
    public partial class FrmVeterinaria : Form
    {
        private AccesoBD oBD;
        private Atencion atencion;
        public FrmVeterinaria()
        {
            InitializeComponent();
            oBD = new AccesoBD();
            atencion = new Atencion();
            CargarClientes();
            CargarCbo();
            Limpiar();
        }

        private void FrmVeterinaria_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lstClientes;
            Habilitar(false);
            dtpFecha.Value = DateTime.Now;
        }
        private void Limpiar()
        {
            cboTipo.SelectedIndex = -1;
        }

        private void Habilitar(bool v)
        {
            lstClientes.Enabled = !v;
            txtNombreMascota.Enabled = v;
            txtEdad.Enabled = v;
            cboTipo.Enabled = v;
            dgvAtenciones.Enabled = v;
            btnAgregarAtencion.Enabled = v;
            btnCancelar.Enabled = v;
            txtDescripcionAtencion.Enabled = v;
            dtpFecha.Enabled = v;
            txtImporte.Enabled = v;
            btnGuardar.Enabled = v;
        }

        private void CargarCbo()
        {
            DataTable tabla = oBD.ConsultaSQL("SP_CONSULTAR_TIPOS");
            if (tabla != null)
            {
                cboTipo.DataSource = tabla;
                cboTipo.DisplayMember = "nombre";
                cboTipo.ValueMember = "id_tipo";
            }
        }

        private void CargarClientes()
        {
           DataTable tabla = oBD.ConsultaSQL("SP_CONSULTAR_CLIENTES");
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Cliente c = new Cliente();
                    c.Nombre = fila["nombre"].ToString();
                    c.Apellido = fila["apellido"].ToString();
                    c.Codigo = Convert.ToInt32(fila["codigo"].ToString());

                    lstClientes.Items.Add(c);
                }
            }
        }

        private void btnAgregarAtencion_Click(object sender, EventArgs e)
        {

            if (txtNombreMascota.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la mascota", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreMascota.Focus();
                return;
            }

            if (txtEdad.Text == "")
            {
                MessageBox.Show("Ingrese la edad de la mascota", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEdad.Focus();
                return;
            }

            try
            {
                if (cboTipo.SelectedItem.Equals(String.Empty) || cboTipo.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un tipo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboTipo.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Seleccione un tipo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipo.Focus();
                return;
            }
            if (txtDescripcionAtencion.Text == "")
            {
                MessageBox.Show("Ingrese la atencion brindada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcionAtencion.Focus();
                return;
            }

            if (txtImporte.Text == "")
            {
                MessageBox.Show("Ingrese el importe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtImporte.Focus();
                return;
            }
            //DataRowView item = (DataRowView)cboClientes.SelectedItem;

            Atencion atencion = new Atencion();

            atencion.Descripcion = txtDescripcionAtencion.Text;
            atencion.Importe = Convert.ToDouble(txtImporte.Text);
            atencion.Fecha = dtpFecha.Value;

            Mascota m = new Mascota();
            m.Atenciones.Add(atencion);
            dgvAtenciones.Rows.Add(new object[] { atencion.Id_atencion, atencion.Descripcion, atencion.Fecha, atencion.Importe});


                    
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cancelar? Se perderan los datos no guardados",
                                "Cancelar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning)
                                == DialogResult.Yes)
            {
                Limpiar();
                Habilitar(false);
                lstClientes.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            this.Close();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void dgvAtenciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAtenciones.CurrentCell.ColumnIndex == 4)
            {
                atencion.EliminarAtencion(dgvAtenciones.CurrentCell.RowIndex);
                dgvAtenciones.Rows.Remove(dgvAtenciones.CurrentRow);
            }
        }
    }
}
