using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalPOO
{
    public partial class FormCliente : Form
    {
        public delegate void EnviarDatosDelegate(CLIENTE Delegado);
        public event EnviarDatosDelegate EnviarDatos;

        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            CLIENTE nuevo = new CLIENTE();
            nuevo.ID = Convert.ToInt32(txtIDCliente.Text);
            nuevo.NOMBRE = txtNombreCliente.Text;
            nuevo.APELLIDO = txtApellidoCliente.Text;
            nuevo.EDAD = Convert.ToInt32(txtEdadCliente.Text);
            nuevo.EMAIL = txtEmailCliente.Text;

            nuevo.ID = 0;
            nuevo.NOMBRE = string.Empty;
            nuevo.APELLIDO = string.Empty;
            nuevo.EDAD = 0;
            nuevo.EMAIL = string.Empty;

            EnviarDatos.Invoke(nuevo);

        }


    }
}
