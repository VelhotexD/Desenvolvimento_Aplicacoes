namespace Ficha5_2160424
{
    partial class Form1
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
            this.gBoxInserirCliente = new System.Windows.Forms.GroupBox();
            this.btnadicionarcliente = new System.Windows.Forms.Button();
            this.txtboxNifCliente = new System.Windows.Forms.TextBox();
            this.txtboxNomeCliente = new System.Windows.Forms.TextBox();
            this.lblnif = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.gboxListaClientes = new System.Windows.Forms.GroupBox();
            this.lstboxclientes = new System.Windows.Forms.ListBox();
            this.gBoxCliente = new System.Windows.Forms.GroupBox();
            this.gBoxCompras = new System.Windows.Forms.GroupBox();
            this.btnApagarLinhaCompras = new System.Windows.Forms.Button();
            this.lblMontanteLinhaCompras = new System.Windows.Forms.Label();
            this.lblTotalLinhaCompras = new System.Windows.Forms.Label();
            this.lstboxLinhaCompras = new System.Windows.Forms.ListBox();
            this.lblLinhaCompra = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.btnApagarCompras = new System.Windows.Forms.Button();
            this.btnCriarCompra = new System.Windows.Forms.Button();
            this.lstboxCompras = new System.Windows.Forms.ListBox();
            this.gBoxDataValorCompra = new System.Windows.Forms.GroupBox();
            this.btnAdicionarLinha = new System.Windows.Forms.Button();
            this.lblValorAdicionarLinhaCompra = new System.Windows.Forms.Label();
            this.txtboxValor = new System.Windows.Forms.TextBox();
            this.txtboxDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblclientenif = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.gBoxInserirCliente.SuspendLayout();
            this.gboxListaClientes.SuspendLayout();
            this.gBoxCliente.SuspendLayout();
            this.gBoxCompras.SuspendLayout();
            this.gBoxDataValorCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxInserirCliente
            // 
            this.gBoxInserirCliente.Controls.Add(this.btnadicionarcliente);
            this.gBoxInserirCliente.Controls.Add(this.txtboxNifCliente);
            this.gBoxInserirCliente.Controls.Add(this.txtboxNomeCliente);
            this.gBoxInserirCliente.Controls.Add(this.lblnif);
            this.gBoxInserirCliente.Controls.Add(this.lblnome);
            this.gBoxInserirCliente.Location = new System.Drawing.Point(38, 21);
            this.gBoxInserirCliente.Name = "gBoxInserirCliente";
            this.gBoxInserirCliente.Size = new System.Drawing.Size(255, 129);
            this.gBoxInserirCliente.TabIndex = 0;
            this.gBoxInserirCliente.TabStop = false;
            this.gBoxInserirCliente.Text = "Inserir Cliente";
            this.gBoxInserirCliente.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnadicionarcliente
            // 
            this.btnadicionarcliente.Location = new System.Drawing.Point(160, 94);
            this.btnadicionarcliente.Name = "btnadicionarcliente";
            this.btnadicionarcliente.Size = new System.Drawing.Size(75, 23);
            this.btnadicionarcliente.TabIndex = 3;
            this.btnadicionarcliente.Text = "Adicionar";
            this.btnadicionarcliente.UseVisualStyleBackColor = true;
            this.btnadicionarcliente.Click += new System.EventHandler(this.btnadicionarcliente_Click);
            // 
            // txtboxNifCliente
            // 
            this.txtboxNifCliente.Location = new System.Drawing.Point(57, 68);
            this.txtboxNifCliente.Name = "txtboxNifCliente";
            this.txtboxNifCliente.Size = new System.Drawing.Size(178, 20);
            this.txtboxNifCliente.TabIndex = 3;
            // 
            // txtboxNomeCliente
            // 
            this.txtboxNomeCliente.Location = new System.Drawing.Point(57, 32);
            this.txtboxNomeCliente.Name = "txtboxNomeCliente";
            this.txtboxNomeCliente.Size = new System.Drawing.Size(178, 20);
            this.txtboxNomeCliente.TabIndex = 2;
            // 
            // lblnif
            // 
            this.lblnif.AutoSize = true;
            this.lblnif.Location = new System.Drawing.Point(28, 71);
            this.lblnif.Name = "lblnif";
            this.lblnif.Size = new System.Drawing.Size(27, 13);
            this.lblnif.TabIndex = 1;
            this.lblnif.Text = "NIF:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(17, 39);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            this.lblnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // gboxListaClientes
            // 
            this.gboxListaClientes.Controls.Add(this.lstboxclientes);
            this.gboxListaClientes.Location = new System.Drawing.Point(38, 156);
            this.gboxListaClientes.Name = "gboxListaClientes";
            this.gboxListaClientes.Size = new System.Drawing.Size(255, 290);
            this.gboxListaClientes.TabIndex = 1;
            this.gboxListaClientes.TabStop = false;
            this.gboxListaClientes.Text = "Lista de Clientes:";
            // 
            // lstboxclientes
            // 
            this.lstboxclientes.FormattingEnabled = true;
            this.lstboxclientes.Location = new System.Drawing.Point(6, 19);
            this.lstboxclientes.Name = "lstboxclientes";
            this.lstboxclientes.Size = new System.Drawing.Size(243, 264);
            this.lstboxclientes.TabIndex = 3;
            this.lstboxclientes.SelectedIndexChanged += new System.EventHandler(this.lstboxclientes_SelectedIndexChanged);
            // 
            // gBoxCliente
            // 
            this.gBoxCliente.Controls.Add(this.gBoxCompras);
            this.gBoxCliente.Controls.Add(this.lblvalor);
            this.gBoxCliente.Controls.Add(this.lblTotal);
            this.gBoxCliente.Controls.Add(this.lblclientenif);
            this.gBoxCliente.Controls.Add(this.lblcliente);
            this.gBoxCliente.Location = new System.Drawing.Point(317, 21);
            this.gBoxCliente.Name = "gBoxCliente";
            this.gBoxCliente.Size = new System.Drawing.Size(604, 425);
            this.gBoxCliente.TabIndex = 2;
            this.gBoxCliente.TabStop = false;
            this.gBoxCliente.Text = "Cliente";
            // 
            // gBoxCompras
            // 
            this.gBoxCompras.Controls.Add(this.btnApagarLinhaCompras);
            this.gBoxCompras.Controls.Add(this.lblMontanteLinhaCompras);
            this.gBoxCompras.Controls.Add(this.lblTotalLinhaCompras);
            this.gBoxCompras.Controls.Add(this.lstboxLinhaCompras);
            this.gBoxCompras.Controls.Add(this.lblLinhaCompra);
            this.gBoxCompras.Controls.Add(this.lblCompras);
            this.gBoxCompras.Controls.Add(this.btnApagarCompras);
            this.gBoxCompras.Controls.Add(this.btnCriarCompra);
            this.gBoxCompras.Controls.Add(this.lstboxCompras);
            this.gBoxCompras.Controls.Add(this.gBoxDataValorCompra);
            this.gBoxCompras.Location = new System.Drawing.Point(18, 120);
            this.gBoxCompras.Name = "gBoxCompras";
            this.gBoxCompras.Size = new System.Drawing.Size(568, 292);
            this.gBoxCompras.TabIndex = 4;
            this.gBoxCompras.TabStop = false;
            this.gBoxCompras.Text = "Compras";
            // 
            // btnApagarLinhaCompras
            // 
            this.btnApagarLinhaCompras.Location = new System.Drawing.Point(296, 257);
            this.btnApagarLinhaCompras.Name = "btnApagarLinhaCompras";
            this.btnApagarLinhaCompras.Size = new System.Drawing.Size(75, 23);
            this.btnApagarLinhaCompras.TabIndex = 8;
            this.btnApagarLinhaCompras.Text = "Apagar";
            this.btnApagarLinhaCompras.UseVisualStyleBackColor = true;
            this.btnApagarLinhaCompras.Click += new System.EventHandler(this.btnApagarLinhaCompras_Click);
            // 
            // lblMontanteLinhaCompras
            // 
            this.lblMontanteLinhaCompras.AutoSize = true;
            this.lblMontanteLinhaCompras.Location = new System.Drawing.Point(237, 262);
            this.lblMontanteLinhaCompras.Name = "lblMontanteLinhaCompras";
            this.lblMontanteLinhaCompras.Size = new System.Drawing.Size(129, 13);
            this.lblMontanteLinhaCompras.TabIndex = 7;
            this.lblMontanteLinhaCompras.Text = "lblMontanteLinhaCompras";
            // 
            // lblTotalLinhaCompras
            // 
            this.lblTotalLinhaCompras.AutoSize = true;
            this.lblTotalLinhaCompras.Location = new System.Drawing.Point(197, 262);
            this.lblTotalLinhaCompras.Name = "lblTotalLinhaCompras";
            this.lblTotalLinhaCompras.Size = new System.Drawing.Size(34, 13);
            this.lblTotalLinhaCompras.TabIndex = 6;
            this.lblTotalLinhaCompras.Text = "Total:";
            // 
            // lstboxLinhaCompras
            // 
            this.lstboxLinhaCompras.FormattingEnabled = true;
            this.lstboxLinhaCompras.Location = new System.Drawing.Point(200, 39);
            this.lstboxLinhaCompras.Name = "lstboxLinhaCompras";
            this.lstboxLinhaCompras.Size = new System.Drawing.Size(171, 212);
            this.lstboxLinhaCompras.TabIndex = 5;
            this.lstboxLinhaCompras.SelectedIndexChanged += new System.EventHandler(this.lstboxLinhaCompras_SelectedIndexChanged);
            // 
            // lblLinhaCompra
            // 
            this.lblLinhaCompra.AutoSize = true;
            this.lblLinhaCompra.Location = new System.Drawing.Point(197, 22);
            this.lblLinhaCompra.Name = "lblLinhaCompra";
            this.lblLinhaCompra.Size = new System.Drawing.Size(95, 13);
            this.lblLinhaCompra.TabIndex = 4;
            this.lblLinhaCompra.Text = "Linha de Compras:";
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Location = new System.Drawing.Point(10, 22);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(51, 13);
            this.lblCompras.TabIndex = 3;
            this.lblCompras.Text = "Compras:";
            // 
            // btnApagarCompras
            // 
            this.btnApagarCompras.Location = new System.Drawing.Point(105, 257);
            this.btnApagarCompras.Name = "btnApagarCompras";
            this.btnApagarCompras.Size = new System.Drawing.Size(75, 23);
            this.btnApagarCompras.TabIndex = 2;
            this.btnApagarCompras.Text = "Apagar";
            this.btnApagarCompras.UseVisualStyleBackColor = true;
            // 
            // btnCriarCompra
            // 
            this.btnCriarCompra.Location = new System.Drawing.Point(9, 257);
            this.btnCriarCompra.Name = "btnCriarCompra";
            this.btnCriarCompra.Size = new System.Drawing.Size(75, 23);
            this.btnCriarCompra.TabIndex = 0;
            this.btnCriarCompra.Text = "Criar Compra";
            this.btnCriarCompra.UseVisualStyleBackColor = true;
            // 
            // lstboxCompras
            // 
            this.lstboxCompras.FormattingEnabled = true;
            this.lstboxCompras.Location = new System.Drawing.Point(9, 39);
            this.lstboxCompras.Name = "lstboxCompras";
            this.lstboxCompras.Size = new System.Drawing.Size(171, 212);
            this.lstboxCompras.TabIndex = 1;
            // 
            // gBoxDataValorCompra
            // 
            this.gBoxDataValorCompra.Controls.Add(this.btnAdicionarLinha);
            this.gBoxDataValorCompra.Controls.Add(this.lblValorAdicionarLinhaCompra);
            this.gBoxDataValorCompra.Controls.Add(this.txtboxValor);
            this.gBoxDataValorCompra.Controls.Add(this.txtboxDescricao);
            this.gBoxDataValorCompra.Controls.Add(this.lblDescricao);
            this.gBoxDataValorCompra.Location = new System.Drawing.Point(390, 52);
            this.gBoxDataValorCompra.Name = "gBoxDataValorCompra";
            this.gBoxDataValorCompra.Size = new System.Drawing.Size(168, 199);
            this.gBoxDataValorCompra.TabIndex = 0;
            this.gBoxDataValorCompra.TabStop = false;
            this.gBoxDataValorCompra.Text = "Adicionar Linha de Compra";
            // 
            // btnAdicionarLinha
            // 
            this.btnAdicionarLinha.Location = new System.Drawing.Point(28, 158);
            this.btnAdicionarLinha.Name = "btnAdicionarLinha";
            this.btnAdicionarLinha.Size = new System.Drawing.Size(112, 23);
            this.btnAdicionarLinha.TabIndex = 13;
            this.btnAdicionarLinha.Text = "Adicionar Linha";
            this.btnAdicionarLinha.UseVisualStyleBackColor = true;
            this.btnAdicionarLinha.Click += new System.EventHandler(this.btnAdicionarLinha_Click);
            // 
            // lblValorAdicionarLinhaCompra
            // 
            this.lblValorAdicionarLinhaCompra.AutoSize = true;
            this.lblValorAdicionarLinhaCompra.Location = new System.Drawing.Point(18, 103);
            this.lblValorAdicionarLinhaCompra.Name = "lblValorAdicionarLinhaCompra";
            this.lblValorAdicionarLinhaCompra.Size = new System.Drawing.Size(34, 13);
            this.lblValorAdicionarLinhaCompra.TabIndex = 12;
            this.lblValorAdicionarLinhaCompra.Text = "Valor:";
            // 
            // txtboxValor
            // 
            this.txtboxValor.Location = new System.Drawing.Point(20, 119);
            this.txtboxValor.Name = "txtboxValor";
            this.txtboxValor.Size = new System.Drawing.Size(128, 20);
            this.txtboxValor.TabIndex = 11;
            this.txtboxValor.TextChanged += new System.EventHandler(this.txtboxValor_TextChanged);
            // 
            // txtboxDescricao
            // 
            this.txtboxDescricao.Location = new System.Drawing.Point(20, 58);
            this.txtboxDescricao.Name = "txtboxDescricao";
            this.txtboxDescricao.Size = new System.Drawing.Size(128, 20);
            this.txtboxDescricao.TabIndex = 10;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(17, 42);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(534, 68);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(40, 13);
            this.lblvalor.TabIndex = 3;
            this.lblvalor.Text = "lblvalor";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(534, 32);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblclientenif
            // 
            this.lblclientenif.AutoSize = true;
            this.lblclientenif.Location = new System.Drawing.Point(30, 68);
            this.lblclientenif.Name = "lblclientenif";
            this.lblclientenif.Size = new System.Drawing.Size(28, 13);
            this.lblclientenif.TabIndex = 1;
            this.lblclientenif.Text = "lblnif";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(30, 32);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(70, 20);
            this.lblcliente.TabIndex = 0;
            this.lblcliente.Text = "lblcliente";
            this.lblcliente.TextChanged += new System.EventHandler(this.lblcliente_TextChanged);
            this.lblcliente.Click += new System.EventHandler(this.lblcliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 478);
            this.Controls.Add(this.gBoxCliente);
            this.Controls.Add(this.gboxListaClientes);
            this.Controls.Add(this.gBoxInserirCliente);
            this.Name = "Form1";
            this.Text = "Gere Clientes";
            this.gBoxInserirCliente.ResumeLayout(false);
            this.gBoxInserirCliente.PerformLayout();
            this.gboxListaClientes.ResumeLayout(false);
            this.gBoxCliente.ResumeLayout(false);
            this.gBoxCliente.PerformLayout();
            this.gBoxCompras.ResumeLayout(false);
            this.gBoxCompras.PerformLayout();
            this.gBoxDataValorCompra.ResumeLayout(false);
            this.gBoxDataValorCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxInserirCliente;
        private System.Windows.Forms.GroupBox gboxListaClientes;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblnif;
        private System.Windows.Forms.Button btnadicionarcliente;
        private System.Windows.Forms.TextBox txtboxNifCliente;
        private System.Windows.Forms.TextBox txtboxNomeCliente;
        private System.Windows.Forms.ListBox lstboxclientes;
        private System.Windows.Forms.GroupBox gBoxCliente;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.GroupBox gBoxCompras;
        private System.Windows.Forms.Button btnApagarLinhaCompras;
        private System.Windows.Forms.Label lblMontanteLinhaCompras;
        private System.Windows.Forms.Label lblTotalLinhaCompras;
        private System.Windows.Forms.ListBox lstboxLinhaCompras;
        private System.Windows.Forms.Label lblLinhaCompra;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Button btnApagarCompras;
        private System.Windows.Forms.Button btnCriarCompra;
        private System.Windows.Forms.ListBox lstboxCompras;
        private System.Windows.Forms.GroupBox gBoxDataValorCompra;
        private System.Windows.Forms.Button btnAdicionarLinha;
        private System.Windows.Forms.Label lblValorAdicionarLinhaCompra;
        private System.Windows.Forms.TextBox txtboxValor;
        private System.Windows.Forms.TextBox txtboxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblclientenif;
    }
}

