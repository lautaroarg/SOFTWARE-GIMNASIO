using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class frmPlanes : Form
    {
        public frmPlanes()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var PM = new PlanesMetodos();
            dt = PM.consultar();
            if (dt.Rows.Count != 0)
            {
                dgvPlanes.DataSource = dt;
            }
            else
            {
                dgvPlanes.DataSource = dt;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirmar guardado", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var P = new Planes();

            if (txtNombrePlan.Text == "" || txtDuracion.Text == "" || txtPrecio.Text == "" || cboDias.Text == "")
            {
                MessageBox.Show("Debes completar los campos faltantes");
            }
            else
            {
                if ((resp == DialogResult.Yes))
                {

                    P.Nombre_Plan = txtNombrePlan.Text;
                    P.Dias = cboDias.Text;
                    P.Duracion = txtDuracion.Text;
                    P.Precio = txtPrecio.Text;
                    P.Estado = cboEstado.Text;
                }
                var PM = new PlanesMetodos(); // creo un objeto de la clase metodo, que es donde estan las consultas.
                Boolean Agregar = PM.AgregarPlan(P);
                if (Agregar == false)
                {
                    MessageBox.Show("Error: No se pudo agregar el plan");
                }
                else
                {
                    MessageBox.Show("Plan agregado");
                }
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Confirmacion para deshabilitar el plan", "Deshabilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var PL = new Planes();
            if (txtCodigoPlan.Text == "")
            {
                MessageBox.Show("Debes completar el codigo del plan para deshabilitarlo");
            }
            else
            {
                if ((respuesta == DialogResult.Yes))
                {
                    PL.Codigo_Plan = txtCodigoPlan.Text;
                    PL.Estado = "D";

                    var PLM = new PlanesMetodos();
                    PLM.Deshabilitar(PL);
                    MessageBox.Show("Plan deshabilitado");
                }
                else
                {
                    MessageBox.Show("Error para deshabilitar el plan", "Verifique");
                }
            }
    }

        private void dgvPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombrePlan.Text = dgvPlanes.CurrentRow.Cells[0].Value.ToString();
            cboDias.Text = dgvPlanes.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvPlanes.CurrentRow.Cells[2].Value.ToString();
            txtDuracion.Text = dgvPlanes.CurrentRow.Cells[3].Value.ToString();
            txtCodigoPlan.Text = dgvPlanes.CurrentRow.Cells[4].Value.ToString();
            cboEstado.Text = dgvPlanes.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Confirmar cambios en el plan", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var Pl   = new Planes();
            if ((respuesta == DialogResult.Yes))
            {
                Pl.Codigo_Plan = txtCodigoPlan.Text;
                Pl.Nombre_Plan = txtNombrePlan.Text;
                Pl.Dias = cboDias.Text;
                Pl.Estado = cboEstado.Text;
                Pl.Duracion = txtDuracion.Text;
                Pl.Precio = txtPrecio.Text;
        
                var PLM = new PlanesMetodos();
                PLM.ModificarPlan(Pl);
                MessageBox.Show("Plan modificado con exito.");
            }
            else
            {
                MessageBox.Show("Error para modificar", "Verifique");
            }
        }

        private void CheckDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckDeshabilitados.Checked == true)
            {
               
                var ds = new DataSet();
                var dt = new DataTable();
                var PM = new PlanesMetodos();
                dt = PM.consultarDeshabilitados();
                if (dt.Rows.Count != 0)
                {
                    dgvPlanes.DataSource = dt;
                }
                else
                {
                    dgvPlanes.DataSource = dt;
                }

            }
            else
            {
                var ds = new DataSet();
                var dt = new DataTable();
                var PM = new PlanesMetodos();
                dt = PM.consultar();
                if (dt.Rows.Count != 0)
                {
                    dgvPlanes.DataSource = dt;
                }
                else
                {
                    dgvPlanes.DataSource = dt;
                }
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoPlan.Text = "";
            txtDuracion.Text = "";
            txtNombrePlan.Text = "";
            txtPrecio.Text = "";
            cboDias.Text = "";
            cboEstado.Text = "";
        }
    }
}
