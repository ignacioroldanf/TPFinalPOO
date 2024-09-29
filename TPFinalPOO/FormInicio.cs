namespace TPFinalPOO
{
    public partial class FormInicio : Form
    {
        private CLIENTE oCliente;
        private CREMA oCrema;
        private PERFUME oPerfume;
        private PRODUCTO oProducto;

        List<CLIENTE> ListaDeClientes = new List<CLIENTE>();
        List<PRODUCTO> ListaDeProductos = new List<PRODUCTO>();
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            this.dtgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cmbTipo.Items.Add("CREMA"); //0
            cmbTipo.Items.Add("PERFUME"); //1


        }

        private void ListarClientes()
        {
            dtgvClientes.DataSource = null;
            dtgvClientes.DataSource = ListaDeClientes;

            txtIDCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;
            txtEdadCliente.Text = string.Empty;
            txtEmailCliente.Text = string.Empty;
        }

        private void ListarProductos()
        {
            dtgvProductos.DataSource = null;
            dtgvProductos.DataSource = ListaDeProductos;

            txtIDProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
            txtStockProducto.Text = string.Empty;
            cmbTipo.SelectedIndex = -1;

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES DE CARGA
            int id;
            if (!int.TryParse(txtIDCliente.Text, out id))
            {
                MessageBox.Show("Ingrese el ID correctamente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellidoCliente.Text))
            {
                MessageBox.Show("Ingrese el apellido del cliente");
                return;
            }

            int edad;
            if (!int.TryParse(txtEdadCliente.Text, out edad))
            {
                MessageBox.Show("Ingrese la edad del cliente correctamente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmailCliente.Text))
            {
                MessageBox.Show("Ingrese el email del cliente");
                return;
            }
            #endregion

            oCliente = new CLIENTE();
            oCliente.ID = Convert.ToInt32(txtIDCliente.Text);
            oCliente.NOMBRE = txtNombreCliente.Text;
            oCliente.APELLIDO = txtApellidoCliente.Text;
            oCliente.EDAD = Convert.ToInt32(txtEdadCliente.Text);
            oCliente.EMAIL = txtEmailCliente.Text;

            ListaDeClientes.Add(oCliente);
            ListarClientes();

            txtIDCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;
            txtEdadCliente.Text = string.Empty;
            txtEmailCliente.Text = string.Empty;



        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dtgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCliente = (CLIENTE)dtgvClientes.CurrentRow.DataBoundItem;
            oCliente.ID = Convert.ToInt32(txtIDCliente.Text);
            oCliente.NOMBRE = txtNombreCliente.Text;
            oCliente.APELLIDO = txtApellidoCliente.Text;
            oCliente.EDAD = Convert.ToInt32(txtEdadCliente.Text);
            oCliente.EMAIL = txtEmailCliente.Text;

            ListarClientes();

        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oCliente = (CLIENTE)dtgvClientes.CurrentRow.DataBoundItem;

            // Cargar datos del cliente en los campos correspondientes
            txtIDCliente.Text = oCliente.ID.ToString();
            txtNombreCliente.Text = oCliente.NOMBRE;
            txtApellidoCliente.Text = oCliente.APELLIDO;
            txtEdadCliente.Text = oCliente.EDAD.ToString();
            txtEmailCliente.Text = oCliente.EMAIL;

            ListarCarrito();

            lblClienteSeleccionado.Text = $"Cliente Seleccionado: {oCliente.APELLIDO}, {oCliente.NOMBRE}";

        }

        private void ListarCarrito()
        {
            dtgvCarrito.DataSource = null;
            dtgvCarrito.DataSource = oCliente.VerProductos(); // Mostrar los productos en el carrito del cliente
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dtgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }

            oCliente = (CLIENTE)dtgvClientes.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar el cliente "
                + oCliente.NOMBRE + " del sistema?", "ATENCION", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                ListaDeClientes.Remove(oCliente);

                ListarClientes();
            }
            txtIDCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;
            txtEdadCliente.Text = string.Empty;
            txtEmailCliente.Text = string.Empty;
        }

        //PRODUCTOS

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES DE CARGA
            int id;
            if (!int.TryParse(txtIDProducto.Text, out id))
            {
                MessageBox.Show("Ingrese el ID correctamente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto");
                return;
            }

            double precio;
            if (!double.TryParse(txtPrecioProducto.Text, out precio))
            {
                MessageBox.Show("Ingrese el precio del producto correctamente");
                return;
            }

            int stock;
            if (!int.TryParse(txtStockProducto.Text, out stock))
            {
                MessageBox.Show("Ingrese el stock del producto correctamente");
                return;
            }
            #endregion

            int ID = Convert.ToInt32(txtIDProducto.Text);
            string NOMBRE = txtNombreProducto.Text;
            double PRECIO = Convert.ToDouble(txtPrecioProducto.Text);
            int STOCK = Convert.ToInt32(txtPrecioProducto.Text);

            switch (cmbTipo.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Debe seleccionar un tipo de producto");
                    return;


                case 0:                   //Crear crema

                    oCrema = new CREMA(ID, NOMBRE, PRECIO, STOCK);
                    ListaDeProductos.Add(oCrema);
                    ListarProductos();
                    break;

                case 1:                   //crear perfume

                    oPerfume = new PERFUME(ID, NOMBRE, PRECIO, STOCK);
                    ListaDeProductos.Add(oPerfume);
                    ListarProductos();
                    break;
            }
            txtIDProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
            txtStockProducto.Text = string.Empty;
            cmbTipo.SelectedIndex = -1;

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista");
                return;
            }

            #region VALIDACIONES DE CARGA
            int id;
            if (!int.TryParse(txtIDProducto.Text, out id))
            {
                MessageBox.Show("Ingrese el ID correctamente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto");
                return;
            }

            double precio;
            if (!double.TryParse(txtPrecioProducto.Text, out precio))
            {
                MessageBox.Show("Ingrese el precio del producto correctamente");
                return;
            }

            int stock;
            if (!int.TryParse(txtStockProducto.Text, out stock))
            {
                MessageBox.Show("Ingrese el stock del producto correctamente");
                return;
            }
            #endregion

            oProducto = (PRODUCTO)dtgvProductos.CurrentRow.DataBoundItem;

            oProducto.ID = Convert.ToInt32(txtIDCliente.Text);
            oProducto.NOMBRE = txtNombreProducto.Text;
            oProducto.PRECIO = Convert.ToDouble(txtPrecioProducto.Text);
            oProducto.STOCK = Convert.ToInt32(txtStockProducto.Text);

            ListarClientes();

            txtIDProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
            txtStockProducto.Text = string.Empty;
            cmbTipo.SelectedIndex = 0;
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oProducto = (PRODUCTO)dtgvProductos.CurrentRow.DataBoundItem;

            txtIDProducto.Text = oProducto.ID.ToString();
            txtNombreProducto.Text = oProducto.NOMBRE;
            txtPrecioProducto.Text = oProducto.PRECIO.ToString();
            txtStockProducto.Text = oProducto.STOCK.ToString();

            if (oProducto.TIPO == "CREMA")
            {
                cmbTipo.Text = "CREMA";
            }
            if (oProducto.TIPO == "PERFUME")
            {
                cmbTipo.Text = "PERFUME";
            }


        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista de productos.");
                return;
            }

            if (dtgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.");
                return;
            }

            oProducto = (PRODUCTO)dtgvProductos.CurrentRow.DataBoundItem;

            oCliente.AgregarProductoAlCarrito(oProducto);

            ListarCarrito();
        }

        private void btnEliminarDelCarrito_Click(object sender, EventArgs e)
        {
            if (dtgvCarrito.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto del carrito para eliminar.");
                return;
            }

            oProducto = (PRODUCTO)dtgvCarrito.CurrentRow.DataBoundItem;

            oCliente.EliminarProductoDelCarrito(oProducto);

            ListarCarrito();
        }
    }
}
