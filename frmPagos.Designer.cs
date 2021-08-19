namespace Gimnasio
{
    partial class frmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaPlan = new System.Windows.Forms.DateTimePicker();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.cboClientePlan = new System.Windows.Forms.ComboBox();
            this.btnCobrarPlan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalPlan = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpProducto = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cboClienteProducto = new System.Windows.Forms.ComboBox();
            this.btnCobrarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalProductos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaPlan);
            this.groupBox1.Controls.Add(this.cboPlan);
            this.groupBox1.Controls.Add(this.cboClientePlan);
            this.groupBox1.Controls.Add(this.btnCobrarPlan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbTotalPlan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(121, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 316);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago de plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Fecha";
            // 
            // dtpFechaPlan
            // 
            this.dtpFechaPlan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPlan.Location = new System.Drawing.Point(94, 125);
            this.dtpFechaPlan.Name = "dtpFechaPlan";
            this.dtpFechaPlan.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaPlan.TabIndex = 52;
            // 
            // cboPlan
            // 
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(94, 89);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(223, 21);
            this.cboPlan.TabIndex = 45;
            this.cboPlan.SelectedIndexChanged += new System.EventHandler(this.cboPlan_SelectedIndexChanged);
            // 
            // cboClientePlan
            // 
            this.cboClientePlan.FormattingEnabled = true;
            this.cboClientePlan.Location = new System.Drawing.Point(94, 53);
            this.cboClientePlan.Name = "cboClientePlan";
            this.cboClientePlan.Size = new System.Drawing.Size(223, 21);
            this.cboClientePlan.TabIndex = 43;
            this.cboClientePlan.SelectedIndexChanged += new System.EventHandler(this.cboClientePlan_SelectedIndexChanged);
            // 
            // btnCobrarPlan
            // 
            this.btnCobrarPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCobrarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrarPlan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCobrarPlan.FlatAppearance.BorderSize = 0;
            this.btnCobrarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrarPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrarPlan.ForeColor = System.Drawing.Color.White;
            this.btnCobrarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrarPlan.Image")));
            this.btnCobrarPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrarPlan.Location = new System.Drawing.Point(119, 226);
            this.btnCobrarPlan.Name = "btnCobrarPlan";
            this.btnCobrarPlan.Size = new System.Drawing.Size(115, 37);
            this.btnCobrarPlan.TabIndex = 49;
            this.btnCobrarPlan.Text = "COBRAR";
            this.btnCobrarPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrarPlan.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Plan";
            // 
            // lbTotalPlan
            // 
            this.lbTotalPlan.AutoSize = true;
            this.lbTotalPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPlan.ForeColor = System.Drawing.Color.White;
            this.lbTotalPlan.Location = new System.Drawing.Point(170, 180);
            this.lbTotalPlan.Name = "lbTotalPlan";
            this.lbTotalPlan.Size = new System.Drawing.Size(12, 16);
            this.lbTotalPlan.TabIndex = 48;
            this.lbTotalPlan.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(26, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Precio total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpProducto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCantidadProducto);
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Controls.Add(this.cboClienteProducto);
            this.groupBox2.Controls.Add(this.btnCobrarProducto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbTotalProductos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(559, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 316);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago de productos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(171, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Fecha";
            // 
            // dtpProducto
            // 
            this.dtpProducto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProducto.Location = new System.Drawing.Point(223, 130);
            this.dtpProducto.Name = "dtpProducto";
            this.dtpProducto.Size = new System.Drawing.Size(89, 20);
            this.dtpProducto.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Cantidad";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(89, 129);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(55, 20);
            this.txtCantidadProducto.TabIndex = 39;
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboProducto.Location = new System.Drawing.Point(89, 93);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(223, 21);
            this.cboProducto.TabIndex = 14;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // cboClienteProducto
            // 
            this.cboClienteProducto.FormattingEnabled = true;
            this.cboClienteProducto.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboClienteProducto.Location = new System.Drawing.Point(89, 57);
            this.cboClienteProducto.Name = "cboClienteProducto";
            this.cboClienteProducto.Size = new System.Drawing.Size(223, 21);
            this.cboClienteProducto.TabIndex = 12;
            // 
            // btnCobrarProducto
            // 
            this.btnCobrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCobrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCobrarProducto.FlatAppearance.BorderSize = 0;
            this.btnCobrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnCobrarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrarProducto.Image")));
            this.btnCobrarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrarProducto.Location = new System.Drawing.Point(114, 230);
            this.btnCobrarProducto.Name = "btnCobrarProducto";
            this.btnCobrarProducto.Size = new System.Drawing.Size(115, 37);
            this.btnCobrarProducto.TabIndex = 38;
            this.btnCobrarProducto.Text = "COBRAR";
            this.btnCobrarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrarProducto.UseVisualStyleBackColor = false;
            this.btnCobrarProducto.Click += new System.EventHandler(this.btnCobrarProducto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Producto";
            // 
            // lbTotalProductos
            // 
            this.lbTotalProductos.AutoSize = true;
            this.lbTotalProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProductos.ForeColor = System.Drawing.Color.White;
            this.lbTotalProductos.Location = new System.Drawing.Point(165, 184);
            this.lbTotalProductos.Name = "lbTotalProductos";
            this.lbTotalProductos.Size = new System.Drawing.Size(12, 16);
            this.lbTotalProductos.TabIndex = 17;
            this.lbTotalProductos.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Precio total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 422);
            this.panel1.TabIndex = 22;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClienteProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotalProductos;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCobrarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.ComboBox cboClientePlan;
        private System.Windows.Forms.Button btnCobrarPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalPlan;
        private System.Windows.Forms.Label label12;
    }
}