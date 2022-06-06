using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clEntidades;
using frmMenuOpciones;
using fm_MenuOpciones;
using clExcepciones;

namespace frmMenuOpciones
{
    public partial class frmCargaCliente : Form
    {
        Cliente nCliente;
        public frmCargaCliente(Cliente cliente) : this()
        {
            this.nCliente = cliente;
            this.txbNombre.Text = cliente.nombre;
            this.txbApellido.Text = cliente.apellido;
            this.txbDNI.Text = cliente.dni.ToString();
        }
        public frmCargaCliente()
        {
            InitializeComponent();
        }
        public Cliente cliente
        {
            get
            {
                return nCliente;
            }
        }
        private void txbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(txbNombre.Text) ||
                string.IsNullOrWhiteSpace(txbApellido.Text) ||
                string.IsNullOrWhiteSpace(txbDNI.Text))
                {
                    MessageBox.Show("Ingresar todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CrearCliente();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CrearCliente()
        {
            uint dni;
            StringBuilder nombre;
            StringBuilder apellido;
            if (!uint.TryParse(txbDNI.Text, out dni))
            {
                throw new ValorNoNumericoException();
            }
            nombre = new StringBuilder(txbNombre.Text.Trim());
            nombre[0] = char.ToUpper(nombre[0]);
            apellido = new StringBuilder(txbApellido.Text.Trim());
            apellido[0] = char.ToUpper(apellido[0]);
            nCliente = new Cliente(nombre.ToString(), apellido.ToString(), dni);
            this.Close();
        }
    }
}
