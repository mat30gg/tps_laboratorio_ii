
namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.textBoxValor1 = new System.Windows.Forms.TextBox();
            this.textBoxValor2 = new System.Windows.Forms.TextBox();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonConverBinario = new System.Windows.Forms.Button();
            this.buttonConverDecimal = new System.Windows.Forms.Button();
            this.listBoxHistorial = new System.Windows.Forms.ListBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValor1
            // 
            this.textBoxValor1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValor1.Location = new System.Drawing.Point(12, 48);
            this.textBoxValor1.Name = "textBoxValor1";
            this.textBoxValor1.Size = new System.Drawing.Size(134, 43);
            this.textBoxValor1.TabIndex = 0;
            this.textBoxValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxValor2
            // 
            this.textBoxValor2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValor2.Location = new System.Drawing.Point(280, 48);
            this.textBoxValor2.Name = "textBoxValor2";
            this.textBoxValor2.Size = new System.Drawing.Size(134, 43);
            this.textBoxValor2.TabIndex = 2;
            this.textBoxValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperador.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "/",
            "*"});
            this.comboBoxOperador.Location = new System.Drawing.Point(177, 48);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(66, 50);
            this.comboBoxOperador.TabIndex = 1;
            // 
            // buttonOperar
            // 
            this.buttonOperar.Location = new System.Drawing.Point(12, 114);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(130, 40);
            this.buttonOperar.TabIndex = 4;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(148, 114);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(130, 40);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(284, 114);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(130, 40);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonConverBinario
            // 
            this.buttonConverBinario.Location = new System.Drawing.Point(12, 161);
            this.buttonConverBinario.Name = "buttonConverBinario";
            this.buttonConverBinario.Size = new System.Drawing.Size(195, 40);
            this.buttonConverBinario.TabIndex = 7;
            this.buttonConverBinario.Text = "Convertir a Binario";
            this.buttonConverBinario.UseVisualStyleBackColor = true;
            this.buttonConverBinario.Click += new System.EventHandler(this.buttonConverBinario_Click);
            // 
            // buttonConverDecimal
            // 
            this.buttonConverDecimal.Location = new System.Drawing.Point(219, 161);
            this.buttonConverDecimal.Name = "buttonConverDecimal";
            this.buttonConverDecimal.Size = new System.Drawing.Size(195, 40);
            this.buttonConverDecimal.TabIndex = 8;
            this.buttonConverDecimal.Text = "Convertir a Decimal";
            this.buttonConverDecimal.UseVisualStyleBackColor = true;
            this.buttonConverDecimal.Click += new System.EventHandler(this.buttonConverDecimal_Click);
            // 
            // listBoxHistorial
            // 
            this.listBoxHistorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxHistorial.FormattingEnabled = true;
            this.listBoxHistorial.ItemHeight = 17;
            this.listBoxHistorial.Location = new System.Drawing.Point(425, 13);
            this.listBoxHistorial.Name = "listBoxHistorial";
            this.listBoxHistorial.Size = new System.Drawing.Size(203, 191);
            this.listBoxHistorial.TabIndex = 3;
            // 
            // labelResultado
            // 
            this.labelResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.Location = new System.Drawing.Point(12, 8);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelResultado.Size = new System.Drawing.Size(407, 37);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 208);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.listBoxHistorial);
            this.Controls.Add(this.buttonConverDecimal);
            this.Controls.Add(this.buttonConverBinario);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.textBoxValor2);
            this.Controls.Add(this.textBoxValor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Mateo Geminiani del curso 2°A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.TextBox textBoxValor2;
        private System.Windows.Forms.ComboBox comboBoxOperador;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonConverBinario;
        private System.Windows.Forms.Button buttonConverDecimal;
        private System.Windows.Forms.ListBox listBoxHistorial;
        private System.Windows.Forms.Label labelResultado;
    }
}

