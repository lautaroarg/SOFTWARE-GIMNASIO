namespace Gimnasio
{
    partial class frmPlanes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbActivos = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.CheckDeshabilitados = new System.Windows.Forms.CheckBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombrePlan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoPlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lbActivos);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(974, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 68);
            this.panel2.TabIndex = 45;
            // 
            // lbActivos
            // 
            this.lbActivos.AutoSize = true;
            this.lbActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivos.ForeColor = System.Drawing.Color.White;
            this.lbActivos.Location = new System.Drawing.Point(51, 32);
            this.lbActivos.Name = "lbActivos";
            this.lbActivos.Size = new System.Drawing.Size(62, 31);
            this.lbActivos.TabIndex = 1;
            this.lbActivos.Text = "105";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(13, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Clientes activos:";
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPlanes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlanes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.dgvPlanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlanes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanes.ColumnHeadersHeight = 30;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPlanes.EnableHeadersVisualStyles = false;
            this.dgvPlanes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.dgvPlanes.Location = new System.Drawing.Point(1, 350);
            this.dgvPlanes.MultiSelect = false;
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.ReadOnly = true;
            this.dgvPlanes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlanes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPlanes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanes.Size = new System.Drawing.Size(957, 384);
            this.dgvPlanes.TabIndex = 43;
            this.dgvPlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellContentClick);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnDeshabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeshabilitar.FlatAppearance.BorderSize = 0;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitar.Image")));
            this.btnDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitar.Location = new System.Drawing.Point(666, 234);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(130, 37);
            this.btnDeshabilitar.TabIndex = 38;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(378, 234);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 37);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(123, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 37);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.CheckDeshabilitados);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 50);
            this.panel1.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1016, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Deshabilitados";
            // 
            // CheckDeshabilitados
            // 
            this.CheckDeshabilitados.AutoSize = true;
            this.CheckDeshabilitados.Location = new System.Drawing.Point(995, 20);
            this.CheckDeshabilitados.Name = "CheckDeshabilitados";
            this.CheckDeshabilitados.Size = new System.Drawing.Size(15, 14);
            this.CheckDeshabilitados.TabIndex = 48;
            this.CheckDeshabilitados.UseVisualStyleBackColor = true;
            this.CheckDeshabilitados.CheckedChanged += new System.EventHandler(this.CheckDeshabilitados_CheckedChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(517, -1);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(45, 54);
            this.btnCargar.TabIndex = 20;
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Filtros";
            // 
            // cboDias
            // 
            this.cboDias.FormattingEnabled = true;
            this.cboDias.Items.AddRange(new object[] {
            "2",
            "3",
            "6"});
            this.cboDias.Location = new System.Drawing.Point(458, 154);
            this.cboDias.Name = "cboDias";
            this.cboDias.Size = new System.Drawing.Size(123, 21);
            this.cboDias.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(332, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Dias por semana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(135, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Duracion";
            // 
            // txtDuracion
            // 
            this.txtDuracion.BackColor = System.Drawing.Color.White;
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(203, 153);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(123, 22);
            this.txtDuracion.TabIndex = 28;
            this.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(681, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(746, 90);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 22);
            this.txtPrecio.TabIndex = 27;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(400, 93);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(57, 16);
            this.Nombre.TabIndex = 30;
            this.Nombre.Text = "Nombre";
            // 
            // txtNombrePlan
            // 
            this.txtNombrePlan.BackColor = System.Drawing.Color.White;
            this.txtNombrePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePlan.Location = new System.Drawing.Point(458, 92);
            this.txtNombrePlan.Name = "txtNombrePlan";
            this.txtNombrePlan.Size = new System.Drawing.Size(123, 22);
            this.txtNombrePlan.TabIndex = 24;
            this.txtNombrePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Codigo";
            // 
            // txtCodigoPlan
            // 
            this.txtCodigoPlan.BackColor = System.Drawing.Color.White;
            this.txtCodigoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPlan.Location = new System.Drawing.Point(203, 94);
            this.txtCodigoPlan.Name = "txtCodigoPlan";
            this.txtCodigoPlan.ReadOnly = true;
            this.txtCodigoPlan.Size = new System.Drawing.Size(123, 22);
            this.txtCodigoPlan.TabIndex = 25;
            this.txtCodigoPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(482, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "PLANES";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "H",
            "D"});
            this.cboEstado.Location = new System.Drawing.Point(746, 153);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(123, 21);
            this.cboEstado.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(677, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Estado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(947, 234);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 37);
            this.btnLimpiar.TabIndex = 66;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1136, 661);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPlanes);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboDias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtNombrePlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoPlan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlanes";
            this.Text = "frmPlanes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbActivos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtNombrePlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox CheckDeshabilitados;
        private System.Windows.Forms.Button btnLimpiar;
    }
}