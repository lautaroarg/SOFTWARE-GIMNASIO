using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gimnasio
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var CM = new ClientesMetodos();
            dt = CM.Consultar();
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirmar guardado", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var Cl = new Clientes();

            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text=="" ||txtTelefono.Text=="" ||cboGenero.Text=="")
            {
                MessageBox.Show("Debes completar los campos faltantes");
            }
            else
            {
                if ((resp == DialogResult.Yes))
                {

                    Cl.DNI = txtDNI.Text;
                    Cl.Apellido = txtApellido.Text;
                    Cl.Nombre = txtNombre.Text;
                    Cl.genero = cboGenero.Text;
                    Cl.Telefono = txtTelefono.Text;
                    Cl.Fecha_Nacimiento = dtpFechaNacimiento.Text;
                    Cl.Estado = cboEstado.Text;    
                }
                var CLMET = new ClientesMetodos(); // creo un objeto de la clase metodo, que es donde estan las consultas.
                Boolean Agregar = CLMET.AgregarCliente(Cl);

                if (Agregar == false)
                {
                    MessageBox.Show("Error: No se pudo agregar al cliente");
                }
                else
                {
                    MessageBox.Show("Cliente agregado");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDNI.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtpFechaNacimiento.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cboGenero.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cboEstado.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Confirmacion para deshabilitar el cliente", "Deshabilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var CL = new Clientes();
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debes completar el codigo del cliente para deshabilitarlo");
            }
            else
            {
                if ((respuesta == DialogResult.Yes))
                {
                    CL.CodigoCliente = txtCodigo.Text;
                    CL.Estado = "D";

                    var CLM = new ClientesMetodos();
                    CLM.Deshabilitar(CL);
                    MessageBox.Show("Cliente deshabilitado");
                }
                else
                {
                    MessageBox.Show("Error para deshabilitar el cliente","Verifique");
                }
            }


           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Confirmar cambios en el cliente", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var CL = new Clientes();
            if ((respuesta == DialogResult.Yes))
            {
                CL.CodigoCliente = txtCodigo.Text;
                CL.DNI = txtDNI.Text;
                CL.Nombre = txtNombre.Text;
                CL.Apellido = txtApellido.Text;
                CL.Estado = cboEstado.Text;
                CL.Fecha_Nacimiento = dtpFechaNacimiento.Text;
                CL.genero = cboGenero.Text;
                CL.Telefono = txtTelefono.Text;
                var CLM = new ClientesMetodos();
                CLM.ModificarCliente(CL);
                MessageBox.Show("Cliente modificado con exito.");
            }
            else
            {
                MessageBox.Show("Error para modificar", "Verifique");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
     
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var LM = new ListaMetodos();
            dt = LM.ConsultaFiltroNombre(txtFiltroNombre.Text);
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void CheckNombre_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CheckDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var LM = new ListaMetodos();
            dt = LM.ConsultaDeshabilitados();
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var LM = new ListaMetodos();
            dt = LM.ConsultaDNI(txtFiltroDNI.Text);
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = dt;
            }

        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var LM = new ListaMetodos();
            dt = LM.ConsultaGenero(cboFiltroGenero.Text);
            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtCodigo.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            cboEstado.Text = "";
            cboGenero.Text = "";
            
        }
    }
}
