using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void Limpiar()
        {
            this.textBoxValor1.Text = "";
            this.textBoxValor2.Text = "";
            this.comboBoxOperador.SelectedIndex = 0;
            this.labelResultado.Text = "";
        }
        private double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            Calculadora calc = new Calculadora();
            return calc.Operar(num1, num2, operador[0]);
        }

        private void buttonOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValor2.Text;
            string op = comboBoxOperador.Text;
            if(!string.IsNullOrEmpty(op) && !string.IsNullOrEmpty(valor1) && !string.IsNullOrEmpty(valor2))
            {
                resultado = this.Operar(textBoxValor1.Text, textBoxValor2.Text, op);
                labelResultado.Text = resultado.ToString();
                listBoxHistorial.Items.Add(string.Format("{0} {1} {2} = {3}\n", valor1, op, valor2, resultado.ToString()));
            }
            else
            {
                labelResultado.Text = "Valores invalidos";
            }
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConverBinario_Click(object sender, EventArgs e)
        {
            string binario;
            Operando conversor = new Operando();
            binario = conversor.DecimalBinario(labelResultado.Text);
            labelResultado.Text = binario;
        }

        private void buttonConverDecimal_Click(object sender, EventArgs e)
        {
            string numero;
            Operando conversor = new Operando();
            numero = conversor.BinarioDecimal(labelResultado.Text);
            labelResultado.Text = numero;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
