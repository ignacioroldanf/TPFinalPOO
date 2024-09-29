namespace TPFinalPOO
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgvClientes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dtgvProductos = new DataGridView();
            dtgvCarrito = new DataGridView();
            btnAgregarCliente = new Button();
            btnModificarCliente = new Button();
            btnEliminarCliente = new Button();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnAgregarProducto = new Button();
            label4 = new Label();
            btnAgregarAlCarrito = new Button();
            btnEliminarDelCarrito = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            txtEmailCliente = new TextBox();
            txtEdadCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtIDCliente = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cmbTipo = new ComboBox();
            txtStockProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtIDProducto = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            lblClienteSeleccionado = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // dtgvClientes
            // 
            dtgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClientes.Location = new Point(20, 67);
            dtgvClientes.Name = "dtgvClientes";
            dtgvClientes.RowHeadersWidth = 51;
            dtgvClientes.Size = new Size(581, 231);
            dtgvClientes.TabIndex = 0;
            dtgvClientes.CellClick += dtgvClientes_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 39);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 329);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Productos";
            // 
            // dtgvProductos
            // 
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Location = new Point(20, 360);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.RowHeadersWidth = 51;
            dtgvProductos.Size = new Size(581, 231);
            dtgvProductos.TabIndex = 2;
            dtgvProductos.CellClick += dtgvProductos_CellClick;
            // 
            // dtgvCarrito
            // 
            dtgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCarrito.Location = new Point(947, 239);
            dtgvCarrito.Name = "dtgvCarrito";
            dtgvCarrito.RowHeadersWidth = 51;
            dtgvCarrito.Size = new Size(581, 231);
            dtgvCarrito.TabIndex = 4;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(622, 248);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(94, 50);
            btnAgregarCliente.TabIndex = 7;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(722, 248);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(94, 50);
            btnModificarCliente.TabIndex = 9;
            btnModificarCliente.Text = "Modificar Cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(822, 248);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(94, 50);
            btnEliminarCliente.TabIndex = 11;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(822, 541);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(94, 50);
            btnEliminarProducto.TabIndex = 14;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(722, 541);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(94, 50);
            btnModificarProducto.TabIndex = 13;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(622, 541);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(94, 50);
            btnAgregarProducto.TabIndex = 12;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 9);
            label4.Name = "label4";
            label4.Size = new Size(360, 20);
            label4.TabIndex = 15;
            label4.Text = "Seleccione Cliente y Producto para agregar al Carrito";
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Location = new Point(1136, 476);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(90, 73);
            btnAgregarAlCarrito.TabIndex = 16;
            btnAgregarAlCarrito.Text = "Agregar Producto al Carrito";
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // btnEliminarDelCarrito
            // 
            btnEliminarDelCarrito.Location = new Point(1275, 476);
            btnEliminarDelCarrito.Name = "btnEliminarDelCarrito";
            btnEliminarDelCarrito.Size = new Size(90, 73);
            btnEliminarDelCarrito.TabIndex = 17;
            btnEliminarDelCarrito.Text = "Eliminar Producto del Carrito";
            btnEliminarDelCarrito.UseVisualStyleBackColor = true;
            btnEliminarDelCarrito.Click += btnEliminarDelCarrito_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(494, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 28);
            comboBox1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 39);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 3;
            label5.Text = "Filtrar por:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(411, 329);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 3;
            label6.Text = "Filtrar por:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(494, 326);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(107, 28);
            comboBox2.TabIndex = 18;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(764, 215);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(152, 27);
            txtEmailCliente.TabIndex = 29;
            // 
            // txtEdadCliente
            // 
            txtEdadCliente.Location = new Point(764, 182);
            txtEdadCliente.Name = "txtEdadCliente";
            txtEdadCliente.Size = new Size(152, 27);
            txtEdadCliente.TabIndex = 28;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(764, 149);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(152, 27);
            txtApellidoCliente.TabIndex = 27;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(764, 116);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(152, 27);
            txtNombreCliente.TabIndex = 26;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(764, 83);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(152, 27);
            txtIDCliente.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(607, 152);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 21;
            label7.Text = "Apellido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(607, 218);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 22;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(607, 119);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 23;
            label9.Text = "Nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(607, 185);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 24;
            label10.Text = "Edad";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(607, 39);
            label11.Name = "label11";
            label11.Size = new Size(199, 20);
            label11.TabIndex = 19;
            label11.Text = "Ingrese los datos del Cliente:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(607, 86);
            label12.Name = "label12";
            label12.Size = new Size(24, 20);
            label12.TabIndex = 20;
            label12.Text = "ID";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(764, 409);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(152, 28);
            cmbTipo.TabIndex = 42;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(764, 508);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(152, 27);
            txtStockProducto.TabIndex = 40;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(764, 475);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(152, 27);
            txtPrecioProducto.TabIndex = 39;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(764, 442);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(152, 27);
            txtNombreProducto.TabIndex = 38;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(764, 376);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(152, 27);
            txtIDProducto.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(607, 445);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 33;
            label13.Text = "Nombre";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(607, 511);
            label14.Name = "label14";
            label14.Size = new Size(45, 20);
            label14.TabIndex = 34;
            label14.Text = "Stock";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(607, 412);
            label15.Name = "label15";
            label15.Size = new Size(39, 20);
            label15.TabIndex = 35;
            label15.Text = "Tipo";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(607, 478);
            label16.Name = "label16";
            label16.Size = new Size(50, 20);
            label16.TabIndex = 36;
            label16.Text = "Precio";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(607, 329);
            label17.Name = "label17";
            label17.Size = new Size(213, 20);
            label17.TabIndex = 31;
            label17.Text = "Ingrese los datos del Producto:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(607, 379);
            label18.Name = "label18";
            label18.Size = new Size(24, 20);
            label18.TabIndex = 32;
            label18.Text = "ID";
            // 
            // lblClienteSeleccionado
            // 
            lblClienteSeleccionado.AutoSize = true;
            lblClienteSeleccionado.Location = new Point(947, 201);
            lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            lblClienteSeleccionado.Size = new Size(0, 20);
            lblClienteSeleccionado.TabIndex = 43;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 819);
            Controls.Add(lblClienteSeleccionado);
            Controls.Add(cmbTipo);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtIDProducto);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtEdadCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtIDCliente);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnEliminarDelCarrito);
            Controls.Add(btnAgregarAlCarrito);
            Controls.Add(label4);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(label6);
            Controls.Add(dtgvCarrito);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dtgvProductos);
            Controls.Add(label1);
            Controls.Add(dtgvClientes);
            Name = "FormInicio";
            Text = "Inicio";
            Load += FormInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvClientes;
        private Label label1;
        private Label label2;
        private DataGridView dtgvProductos;
        private DataGridView dtgvCarrito;
        private Button btnAgregarCliente;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnAgregarProducto;
        private Label label4;
        private Button btnAgregarAlCarrito;
        private Button btnEliminarDelCarrito;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private TextBox txtEmailCliente;
        private TextBox txtEdadCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtNombreCliente;
        private TextBox txtIDCliente;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cmbTipo;
        private TextBox txtStockProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtNombreProducto;
        private TextBox txtIDProducto;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label lblClienteSeleccionado;
    }
}
