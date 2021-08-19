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
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            cboPlan.Text = "";
            var dtc = new DataTable();
            var CPM = new ClientesPagosMetodos();
            dtc = CPM.CargarComboCliente();
            cboClientePlan.DataSource = dtc;
            cboClientePlan.DisplayMember = "NombreC";
            cboClientePlan.ValueMember = "CodigoCliente";
            cboClientePlan.Text = "";
            cboClienteProducto.DataSource = dtc;
            cboClienteProducto.DisplayMember = "NombreC";
            cboClienteProducto.ValueMember = "CodigoCliente";
            cboClienteProducto.Text = "";


            var dtpl = new DataTable();
            dtpl = CPM.CargarComboPlan();
            cboPlan.DataSource = dtpl;
            cboPlan.DisplayMember = "Nombre_Plan";
            cboPlan.ValueMember = "Codigo_plan";
            cboPlan.Text = "";

            var dtpr = new DataTable();
            dtpr = CPM.CargarComboProducto();
            cboProducto.DataSource = dtpr;
            cboProducto.DisplayMember = "Nombre_Producto";
            cboProducto.ValueMember = "Codigo_Producto";
            cboProducto.Text = "";




        }

        private void cboClientePlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pl = new Planes();
            
            if (cboPlan.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                
            }
            else
            {
                pl.Codigo_Plan = cboPlan.SelectedValue.ToString();
                var CPM = new ClientesPagosMetodos();
                lbTotalPlan.Text= "$" +CPM.TotalPlan(pl).ToString();
                
            }

        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pr = new Productos();

            if (cboProducto.SelectedValue.ToString() == "System.Data.DataRowView")
            {

            }
            else
            {
                pr.Codigo_Producto = cboProducto.SelectedValue.ToString();
                var CPM = new ClientesPagosMetodos();
                lbTotalProductos.Text =CPM.TotalProducto(pr).ToString();

            }
        }

        private void btnCobrarProducto_Click(object sender, EventArgs e)
        {
            
            DialogResult resp = MessageBox.Show("Confirmar guardado", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var CPR = new ComprobanteProducto();

            if (cboClienteProducto.Text == "" || cboProducto.Text == "" || txtCantidadProducto.Text == "")
            {
                MessageBox.Show("Debes completar los campos faltantes");
            }
            else
            {
                if ((resp == DialogResult.Yes))
                {
                    var cprM = new ClientesPagosMetodos();
                    CPR.PrecioTotalpr = lbTotalProductos.Text;
                    CPR.CodigoCliente = cboClientePlan.SelectedValue.ToString();
                    CPR.Codigo_Producto = cboProducto.SelectedValue.ToString();
                    CPR.FechaPago = dtpProducto.Text;
                    CPR.Cantidad = txtCantidadProducto.Text;
                    CPR.NumComprobantepr = cprM.CodigoNuevo.ToString();

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
    }
    }
}
