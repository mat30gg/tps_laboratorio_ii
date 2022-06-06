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

namespace frmMenuOpciones
{
    public partial class frmCargaLibro : Form
    {
        Libro nLibro;
        public frmCargaLibro()
        {
            InitializeComponent();
        }
        public Libro libro
        {
            get
            {
                return nLibro;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(this.txbTitulo.Text) ||
                    string.IsNullOrWhiteSpace(this.txbAutor.Text))
                {
                    MessageBox.Show("Ingresar todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    nLibro = new Libro(txbTitulo.Text, txbAutor.Text, (int)numCantidadDisponible.Value);
                    this.Close();
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
    }
}
