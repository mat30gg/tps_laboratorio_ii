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
using clExcepciones;

namespace fm_MenuOpciones
{
    public partial class frmPrincipalBiblioteca : Form
    {
        public List<Cliente> listaClientes;
        public List<Cliente> clientesEliminados;
        public List<Libro> listaLibros;
        public List<Libro> librosEliminados;

        public frmPrincipalBiblioteca()
        {
            InitializeComponent();
            listaClientes = new List<Cliente>();
            clientesEliminados = new List<Cliente>();
            listaLibros = new List<Libro>();
            librosEliminados = new List<Libro>();
        }
        private void btnPoneListaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarCliente();
            }
            catch(ValorNoNumericoException ex)
            {
                MessageBox.Show(ex.Message, "DNI no valido");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnSacaListaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if(listaClientes.Count > 0)
                {
                    QuitarCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnModificaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if(listaClientes.Count > 0)
                {
                    ModificarCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnPoneListaLibro_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarLibro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnSacaListaLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaLibros.Count > 0)
                {
                    QuitarLibro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnOrdenAscListaLibro_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < listaLibros.Count - 1; x++)
            {
                for (int y = x; y < listaLibros.Count; y++)
                {
                    if (listaLibros[x] > listaLibros[y])
                    {
                        Metodos.Swap<Libro>(listaLibros, x, y);
                    }
                }
            }
            ActualizarListBox<Libro>(lbListaLibro, listaLibros);
        }
        private void btnOrdenDesListaLibro_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < listaLibros.Count - 1; x++)
            {
                for (int y = x; y < listaLibros.Count; y++)
                {
                    if (listaLibros[x] < listaLibros[y])
                    {
                        Metodos.Swap<Libro>(listaLibros, x, y);
                    }
                }
            }
            ActualizarListBox<Libro>(lbListaLibro, listaLibros);
        }
        private void AgregarCliente()
        {
            frmCargaCliente frmCargaCliente = new frmCargaCliente();
            frmCargaCliente.ShowDialog();
            if (frmCargaCliente.cliente is not null)
            {
                listaClientes.Add(frmCargaCliente.cliente);
                lbListaCliente.Items.Add(frmCargaCliente.cliente);
                lbListaCliente.SelectedIndex = 0;
            }
        }
        private void QuitarCliente()
        {
            int indice;
            indice = lbListaCliente.SelectedIndex;
            clientesEliminados.Add(listaClientes[indice]);
            lbListaCliente.Items.Remove(listaClientes[indice]);
            listaClientes.RemoveAt(indice);
            lbListaCliente.SelectedIndex = indice - 1;
        }
        private void ModificarCliente()
        {
            int indice;
            Cliente versionVieja;
            indice = lbListaCliente.SelectedIndex;
            frmCargaCliente frmModificacion = new frmCargaCliente(listaClientes[indice]);
            versionVieja = frmModificacion.cliente;
            frmModificacion.ShowDialog();
            if (frmModificacion.cliente is not null)
            {
                listaClientes.Remove(versionVieja);
                listaClientes.Insert(indice, frmModificacion.cliente);
                lbListaCliente.Items.Remove(versionVieja);
                lbListaCliente.Items.Add(frmModificacion.cliente);
                lbListaCliente.SelectedIndex = indice;
            }
        }
        private void AgregarLibro()
        {
            frmCargaLibro frmCargaLibro = new frmCargaLibro();
            frmCargaLibro.ShowDialog();
            if (frmCargaLibro.libro is not null)
            {
                listaLibros.Add(frmCargaLibro.libro);
                lbListaLibro.Items.Add(frmCargaLibro.libro);
                lbListaLibro.SelectedIndex = 0;
            }
        }
        private void QuitarLibro()
        {
            int indice;
            indice = lbListaLibro.SelectedIndex;
            librosEliminados.Add(listaLibros[indice]);
            lbListaLibro.Items.Add(listaLibros[indice]);
            listaLibros.RemoveAt(indice);
            lbListaLibro.SelectedIndex = indice - 1;
        }
        private void ActualizarListBox<T>(ListBox lb, List<T> listaNueva)
        {
            lb.Items.Clear();
            foreach(T cosa in listaNueva)
            {
                lb.Items.Add(cosa);
            }
        }
        private void lbListaLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbListaLibro.SelectedIndex > 0)
            {
                lblDisponible.Text = listaLibros[lbListaLibro.SelectedIndex].cantDispo.ToString();
            }
        }

        private void btnCargaLibroCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnDescargaLibroCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
