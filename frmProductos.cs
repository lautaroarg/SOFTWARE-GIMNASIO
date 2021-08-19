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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var PR = new ProductosMetodos();
            dt = PR.consultar();
            if (dt.Rows.Count != 0)
            {
                dgvProductos.DataSource = dt;
            }
            else
            {
                dgvProductos.DataSource = dt;
            }
        }

        private void CheckDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDeshabilitados.Checked == true)
            {

                var ds = new DataSet();
                var dt = new DataTable();
                var PR = new ProductosMetodos();
                dt = PR.consultarDeshabilitados();
                if (dt.Rows.Count != 0)
                {
                    dgvProductos.DataSource = dt;
                }
                else
                {
                    dgvProductos.DataSource = dt;
                }

            }
            else
            {
                var ds = new DataSet();
                var dt = new DataTable();
                var PR = new ProductosMetodos();
                dt = PR.consultar();
                if (dt.Rows.Count != 0)
                {
                    dgvProductos.DataSource = dt;
                }
                else
                {
                    dgvProductos.DataSource = dt;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Confirmar guardado", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var P = new Productos();

            if (txtNombreProducto.Text == "" || txtCantidadProducto.Text == "" || txtPrecioProducto.Text == "" || cboCategoriaProducto.Text == "")
            {
                MessageBox.Show("Debes completar los campos faltantes");
            }
            else
            {
                if ((resp == DialogResult.Yes))
                {

                    P.Nombre_Producto = txtNombreProducto.Text;
                    P.Categoria_Producto = cboCategoriaProducto.Text;
                    P.Cantidad_disponible = txtCantidadProducto.Text;
                    P.Precio_Producto = txtPrecioProducto.Text;
                    P.Estado = cboEstado.Text;
                }
                var PM = new ProductosMetodos(); // creo un objeto de la clase metodo, que es donde estan las consultas.
                Boolean Agregar = PM.AgregarProducto(P);
                if (Agregar == false)
                {
                    MessageBox.Show("Error: No se pudo agregar el producto");
                }
                else
                {
                    MessageBox.Show("Producto agregado");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Confirmar cambios en el producto", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var PR = new Productos();
            if ((respuesta == DialogResult.Yes))
            {
                PR.Codigo_Producto = txtCodigoProducto.Text;
                PR.Cantidad_disponible = txtCantidadProducto.Text;
                PR.Nombre_Producto = txtNombreProducto.Text;
                PR.Categoria_Producto = cboCategoriaProducto.Text;
                PR.Estado = cboEstado.Text;
                PR.Precio_Producto = txtPrecioProducto.Text;
                var PRM = new ProductosMetodos();
                PRM.ModificarProductos(PR);
                MessageBox.Show("Producto modificado con exito.");
            }
            else
            {
                MessageBox.Show("Error para modificar", "Verifique");
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Confirmacion para deshabilitar el producto", "Deshabilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var PR = new Productos();
            if (txtCodigoProducto.Text == "")
            {
                MessageBox.Show("Debes completar el codigo del producto para deshabilitarlo");
            }
            else
            {
                if ((respuesta == DialogResult.Yes))
                {
                    PR.Codigo_Producto = txtCodigoProducto.Text;
                    PR.Estado = "D";

                    var PRM = new ProductosMetodos();
                    PRM.Deshabilitar(PR);
                    MessageBox.Show("Producto deshabilitado");
                }
                else
                {
                    MessageBox.Show("Error para deshabilitar el producto", "Verifique");
                }
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtCantidadProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtPrecioProducto.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            cboCategoriaProducto.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txtCodigoProducto.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            cboEstado.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PM = new ProductosMetodos();
            txtCodigoProducto.Text = PM.CodigoNuevo().ToString();
            txtNombreProducto.Text = "";
            txtCantidadProducto.Text = "";
            txtPrecioProducto.Text = "";
            cboCategoriaProducto.Text = "";
            cboEstado.Text = "";
            
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            var PM = new ProductosMetodos();
            txtCodigoProducto.Text = PM.CodigoNuevo().ToString();
        }
    }
}
