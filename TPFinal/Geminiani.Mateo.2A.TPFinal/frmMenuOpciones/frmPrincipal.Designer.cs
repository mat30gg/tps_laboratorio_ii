using frmMenuOpciones;
using fm_MenuOpciones;
using clEntidades;

namespace fm_MenuOpciones
{
    partial class frmPrincipalBiblioteca
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
            this.btnPoneListaCliente = new System.Windows.Forms.Button();
            this.lbListaCliente = new System.Windows.Forms.ListBox();
            this.btnSacaListaCliente = new System.Windows.Forms.Button();
            this.btnModificaCliente = new System.Windows.Forms.Button();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.btnPrtDatosCliente = new System.Windows.Forms.Button();
            this.btnSacaListaLibro = new System.Windows.Forms.Button();
            this.btnOrdenAscListaLibro = new System.Windows.Forms.Button();
            this.btnPoneListaLibro = new System.Windows.Forms.Button();
            this.btnOrdenDesListaLibro = new System.Windows.Forms.Button();
            this.gbLibros = new System.Windows.Forms.GroupBox();
            this.lbListaLibro = new System.Windows.Forms.ListBox();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.btnPrtDatosLibro = new System.Windows.Forms.Button();
            this.frmlblDisponible = new System.Windows.Forms.Label();
            this.lblPrntLibro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargaLibroCliente = new System.Windows.Forms.Button();
            this.btnDescargaLibroCliente = new System.Windows.Forms.Button();
            this.gbClientes.SuspendLayout();
            this.gbLibros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPoneListaCliente
            // 
            this.btnPoneListaCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoneListaCliente.Location = new System.Drawing.Point(4, 18);
            this.btnPoneListaCliente.Margin = new System.Windows.Forms.Padding(1);
            this.btnPoneListaCliente.Name = "btnPoneListaCliente";
            this.btnPoneListaCliente.Size = new System.Drawing.Size(28, 28);
            this.btnPoneListaCliente.TabIndex = 0;
            this.btnPoneListaCliente.Text = "+";
            this.btnPoneListaCliente.UseVisualStyleBackColor = true;
            this.btnPoneListaCliente.Click += new System.EventHandler(this.btnPoneListaCliente_Click);
            // 
            // lbListaCliente
            // 
            this.lbListaCliente.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbListaCliente.FormattingEnabled = true;
            this.lbListaCliente.ItemHeight = 14;
            this.lbListaCliente.Location = new System.Drawing.Point(4, 48);
            this.lbListaCliente.Margin = new System.Windows.Forms.Padding(1);
            this.lbListaCliente.Name = "lbListaCliente";
            this.lbListaCliente.Size = new System.Drawing.Size(166, 214);
            this.lbListaCliente.TabIndex = 1;
            // 
            // btnSacaListaCliente
            // 
            this.btnSacaListaCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSacaListaCliente.Location = new System.Drawing.Point(34, 18);
            this.btnSacaListaCliente.Margin = new System.Windows.Forms.Padding(1);
            this.btnSacaListaCliente.Name = "btnSacaListaCliente";
            this.btnSacaListaCliente.Size = new System.Drawing.Size(28, 28);
            this.btnSacaListaCliente.TabIndex = 2;
            this.btnSacaListaCliente.Text = "-";
            this.btnSacaListaCliente.UseVisualStyleBackColor = true;
            this.btnSacaListaCliente.Click += new System.EventHandler(this.btnSacaListaCliente_Click);
            // 
            // btnModificaCliente
            // 
            this.btnModificaCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificaCliente.Location = new System.Drawing.Point(64, 18);
            this.btnModificaCliente.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificaCliente.Name = "btnModificaCliente";
            this.btnModificaCliente.Size = new System.Drawing.Size(28, 28);
            this.btnModificaCliente.TabIndex = 3;
            this.btnModificaCliente.Text = "✍";
            this.btnModificaCliente.UseVisualStyleBackColor = true;
            this.btnModificaCliente.Click += new System.EventHandler(this.btnModificaCliente_Click);
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.lbListaCliente);
            this.gbClientes.Controls.Add(this.btnPrtDatosCliente);
            this.gbClientes.Controls.Add(this.btnPoneListaCliente);
            this.gbClientes.Controls.Add(this.btnModificaCliente);
            this.gbClientes.Controls.Add(this.btnSacaListaCliente);
            this.gbClientes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbClientes.Location = new System.Drawing.Point(396, 12);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(174, 320);
            this.gbClientes.TabIndex = 5;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Listado de clientes";
            // 
            // btnPrtDatosCliente
            // 
            this.btnPrtDatosCliente.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrtDatosCliente.Location = new System.Drawing.Point(4, 269);
            this.btnPrtDatosCliente.Name = "btnPrtDatosCliente";
            this.btnPrtDatosCliente.Size = new System.Drawing.Size(166, 45);
            this.btnPrtDatosCliente.TabIndex = 7;
            this.btnPrtDatosCliente.Text = "Datos del cliente";
            this.btnPrtDatosCliente.UseVisualStyleBackColor = true;
            // 
            // btnSacaListaLibro
            // 
            this.btnSacaListaLibro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSacaListaLibro.Location = new System.Drawing.Point(44, 278);
            this.btnSacaListaLibro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSacaListaLibro.Name = "btnSacaListaLibro";
            this.btnSacaListaLibro.Size = new System.Drawing.Size(32, 32);
            this.btnSacaListaLibro.TabIndex = 2;
            this.btnSacaListaLibro.Text = "-";
            this.btnSacaListaLibro.UseVisualStyleBackColor = true;
            this.btnSacaListaLibro.Click += new System.EventHandler(this.btnSacaListaLibro_Click);
            // 
            // btnOrdenAscListaLibro
            // 
            this.btnOrdenAscListaLibro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenAscListaLibro.Location = new System.Drawing.Point(80, 279);
            this.btnOrdenAscListaLibro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOrdenAscListaLibro.Name = "btnOrdenAscListaLibro";
            this.btnOrdenAscListaLibro.Size = new System.Drawing.Size(32, 32);
            this.btnOrdenAscListaLibro.TabIndex = 3;
            this.btnOrdenAscListaLibro.Text = "∧";
            this.btnOrdenAscListaLibro.UseVisualStyleBackColor = true;
            this.btnOrdenAscListaLibro.Click += new System.EventHandler(this.btnOrdenAscListaLibro_Click);
            // 
            // btnPoneListaLibro
            // 
            this.btnPoneListaLibro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoneListaLibro.Location = new System.Drawing.Point(9, 278);
            this.btnPoneListaLibro.Margin = new System.Windows.Forms.Padding(1);
            this.btnPoneListaLibro.Name = "btnPoneListaLibro";
            this.btnPoneListaLibro.Size = new System.Drawing.Size(32, 32);
            this.btnPoneListaLibro.TabIndex = 0;
            this.btnPoneListaLibro.Text = "+";
            this.btnPoneListaLibro.UseVisualStyleBackColor = true;
            this.btnPoneListaLibro.Click += new System.EventHandler(this.btnPoneListaLibro_Click);
            // 
            // btnOrdenDesListaLibro
            // 
            this.btnOrdenDesListaLibro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenDesListaLibro.Location = new System.Drawing.Point(116, 279);
            this.btnOrdenDesListaLibro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOrdenDesListaLibro.Name = "btnOrdenDesListaLibro";
            this.btnOrdenDesListaLibro.Size = new System.Drawing.Size(32, 32);
            this.btnOrdenDesListaLibro.TabIndex = 4;
            this.btnOrdenDesListaLibro.Text = "∨";
            this.btnOrdenDesListaLibro.UseVisualStyleBackColor = true;
            this.btnOrdenDesListaLibro.Click += new System.EventHandler(this.btnOrdenDesListaLibro_Click);
            // 
            // gbLibros
            // 
            this.gbLibros.Controls.Add(this.lbListaLibro);
            this.gbLibros.Controls.Add(this.lblDisponible);
            this.gbLibros.Controls.Add(this.btnPrtDatosLibro);
            this.gbLibros.Controls.Add(this.frmlblDisponible);
            this.gbLibros.Controls.Add(this.btnOrdenDesListaLibro);
            this.gbLibros.Controls.Add(this.btnPoneListaLibro);
            this.gbLibros.Controls.Add(this.btnOrdenAscListaLibro);
            this.gbLibros.Controls.Add(this.btnSacaListaLibro);
            this.gbLibros.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbLibros.Location = new System.Drawing.Point(12, 12);
            this.gbLibros.Name = "gbLibros";
            this.gbLibros.Size = new System.Drawing.Size(296, 320);
            this.gbLibros.TabIndex = 6;
            this.gbLibros.TabStop = false;
            this.gbLibros.Text = "Listado de libros";
            // 
            // lbListaLibro
            // 
            this.lbListaLibro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbListaLibro.FormattingEnabled = true;
            this.lbListaLibro.ItemHeight = 14;
            this.lbListaLibro.Location = new System.Drawing.Point(9, 16);
            this.lbListaLibro.Name = "lbListaLibro";
            this.lbListaLibro.Size = new System.Drawing.Size(277, 228);
            this.lbListaLibro.TabIndex = 10;
            this.lbListaLibro.SelectedIndexChanged += new System.EventHandler(this.lbListaLibro_SelectedIndexChanged);
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisponible.Location = new System.Drawing.Point(110, 255);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(16, 18);
            this.lblDisponible.TabIndex = 9;
            this.lblDisponible.Text = "-";
            // 
            // btnPrtDatosLibro
            // 
            this.btnPrtDatosLibro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrtDatosLibro.Location = new System.Drawing.Point(163, 278);
            this.btnPrtDatosLibro.Name = "btnPrtDatosLibro";
            this.btnPrtDatosLibro.Size = new System.Drawing.Size(123, 32);
            this.btnPrtDatosLibro.TabIndex = 5;
            this.btnPrtDatosLibro.Text = "Datos del libro";
            this.btnPrtDatosLibro.UseVisualStyleBackColor = true;
            // 
            // frmlblDisponible
            // 
            this.frmlblDisponible.AutoSize = true;
            this.frmlblDisponible.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmlblDisponible.Location = new System.Drawing.Point(9, 255);
            this.frmlblDisponible.Name = "frmlblDisponible";
            this.frmlblDisponible.Size = new System.Drawing.Size(96, 17);
            this.frmlblDisponible.TabIndex = 8;
            this.frmlblDisponible.Text = "Disponible:";
            // 
            // lblPrntLibro
            // 
            this.lblPrntLibro.AutoSize = true;
            this.lblPrntLibro.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrntLibro.Location = new System.Drawing.Point(12, 335);
            this.lblPrntLibro.Name = "lblPrntLibro";
            this.lblPrntLibro.Size = new System.Drawing.Size(60, 22);
            this.lblPrntLibro.TabIndex = 7;
            this.lblPrntLibro.Text = "Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(400, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre";
            // 
            // btnCargaLibroCliente
            // 
            this.btnCargaLibroCliente.Location = new System.Drawing.Point(311, 81);
            this.btnCargaLibroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCargaLibroCliente.Name = "btnCargaLibroCliente";
            this.btnCargaLibroCliente.Size = new System.Drawing.Size(82, 60);
            this.btnCargaLibroCliente.TabIndex = 9;
            this.btnCargaLibroCliente.Text = "Cargar a cliente";
            this.btnCargaLibroCliente.UseVisualStyleBackColor = true;
            this.btnCargaLibroCliente.Click += new System.EventHandler(this.btnCargaLibroCliente_Click);
            // 
            // btnDescargaLibroCliente
            // 
            this.btnDescargaLibroCliente.Location = new System.Drawing.Point(311, 170);
            this.btnDescargaLibroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnDescargaLibroCliente.Name = "btnDescargaLibroCliente";
            this.btnDescargaLibroCliente.Size = new System.Drawing.Size(82, 60);
            this.btnDescargaLibroCliente.TabIndex = 10;
            this.btnDescargaLibroCliente.Text = "Descargar de cliente";
            this.btnDescargaLibroCliente.UseVisualStyleBackColor = true;
            this.btnDescargaLibroCliente.Click += new System.EventHandler(this.btnDescargaLibroCliente_Click);
            // 
            // frmPrincipalBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(582, 524);
            this.Controls.Add(this.btnDescargaLibroCliente);
            this.Controls.Add(this.btnCargaLibroCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrntLibro);
            this.Controls.Add(this.gbLibros);
            this.Controls.Add(this.gbClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipalBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requiem del libro";
            this.gbClientes.ResumeLayout(false);
            this.gbLibros.ResumeLayout(false);
            this.gbLibros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoneListaCliente;
        private System.Windows.Forms.ListBox lbListaCliente;
        private System.Windows.Forms.Button btnSacaListaCliente;
        private System.Windows.Forms.Button btnModificaCliente;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.Button btnSacaListaLibro;
        private System.Windows.Forms.Button btnOrdenAscListaLibro;
        private System.Windows.Forms.Button btnPoneListaLibro;
        private System.Windows.Forms.Button btnOrdenDesListaLibro;
        private System.Windows.Forms.GroupBox gbLibros;
        private System.Windows.Forms.Button btnPrtDatosLibro;
        private System.Windows.Forms.ListBox lbListaLibro;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label frmlblDisponible;
        private System.Windows.Forms.Button btnPrtDatosCliente;
        private System.Windows.Forms.Label lblPrntLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargaLibroCliente;
        private System.Windows.Forms.Button btnDescargaLibroCliente;
    }
}

