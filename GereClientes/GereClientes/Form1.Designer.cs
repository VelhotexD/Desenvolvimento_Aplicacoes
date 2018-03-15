namespace GereClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ltotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNif = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Lblinhacompra = new System.Windows.Forms.ListBox();
            this.listBoxCompras = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.btAddLinha = new System.Windows.Forms.Button();
            this.llinatotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btApagarLinha = new System.Windows.Forms.Button();
            this.btApagarCompra = new System.Windows.Forms.Button();
            this.btCriarCompra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNif);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.btAddCliente);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(185, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // tbNif
            // 
            this.tbNif.Location = new System.Drawing.Point(86, 50);
            this.tbNif.Margin = new System.Windows.Forms.Padding(2);
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(76, 20);
            this.tbNif.TabIndex = 1;
            this.tbNif.Text = " ";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(86, 17);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(76, 20);
            this.tbNome.TabIndex = 0;
            // 
            // btAddCliente
            // 
            this.btAddCliente.Location = new System.Drawing.Point(105, 72);
            this.btAddCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btAddCliente.Name = "btAddCliente";
            this.btAddCliente.Size = new System.Drawing.Size(65, 28);
            this.btAddCliente.TabIndex = 2;
            this.btAddCliente.Text = "Adicionar";
            this.btAddCliente.UseVisualStyleBackColor = true;
            this.btAddCliente.Click += new System.EventHandler(this.btAddCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxCliente);
            this.groupBox2.Location = new System.Drawing.Point(9, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(185, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clientes";
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.Location = new System.Drawing.Point(5, 28);
            this.listBoxCliente.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(166, 264);
            this.listBoxCliente.TabIndex = 0;
            this.listBoxCliente.Click += new System.EventHandler(this.listBoxCliente_Click);
            this.listBoxCliente.SelectedIndexChanged += new System.EventHandler(this.listBoxCliente_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ltotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbNif);
            this.groupBox3.Controls.Add(this.lbCliente);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(199, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(682, 401);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // ltotal
            // 
            this.ltotal.AutoSize = true;
            this.ltotal.Location = new System.Drawing.Point(550, 63);
            this.ltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ltotal.Name = "ltotal";
            this.ltotal.Size = new System.Drawing.Size(37, 13);
            this.ltotal.TabIndex = 4;
            this.ltotal.Text = "(Valor)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total:";
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.Location = new System.Drawing.Point(39, 85);
            this.lbNif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(30, 13);
            this.lbNif.TabIndex = 2;
            this.lbNif.Text = "(NIF)";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(34, 32);
            this.lbCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(153, 46);
            this.lbCliente.TabIndex = 1;
            this.lbCliente.Text = "(Nome)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Lblinhacompra);
            this.groupBox4.Controls.Add(this.listBoxCompras);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.llinatotal);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btApagarLinha);
            this.groupBox4.Controls.Add(this.btApagarCompra);
            this.groupBox4.Controls.Add(this.btCriarCompra);
            this.groupBox4.Location = new System.Drawing.Point(20, 122);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(648, 275);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compras";
            // 
            // Lblinhacompra
            // 
            this.Lblinhacompra.FormattingEnabled = true;
            this.Lblinhacompra.Location = new System.Drawing.Point(211, 54);
            this.Lblinhacompra.Margin = new System.Windows.Forms.Padding(2);
            this.Lblinhacompra.Name = "Lblinhacompra";
            this.Lblinhacompra.Size = new System.Drawing.Size(182, 173);
            this.Lblinhacompra.TabIndex = 15;
            // 
            // listBoxCompras
            // 
            this.listBoxCompras.FormattingEnabled = true;
            this.listBoxCompras.Location = new System.Drawing.Point(15, 55);
            this.listBoxCompras.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCompras.Name = "listBoxCompras";
            this.listBoxCompras.Size = new System.Drawing.Size(182, 173);
            this.listBoxCompras.TabIndex = 14;
            this.listBoxCompras.Click += new System.EventHandler(this.listBoxCompras_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbValor);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.tbDescricao);
            this.groupBox5.Controls.Add(this.btAddLinha);
            this.groupBox5.Location = new System.Drawing.Point(451, 36);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(179, 220);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adicionar Linha de Compra";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(12, 88);
            this.tbValor.Margin = new System.Windows.Forms.Padding(2);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(143, 20);
            this.tbValor.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Descrição:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Valor:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(12, 35);
            this.tbDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(143, 20);
            this.tbDescricao.TabIndex = 0;
            // 
            // btAddLinha
            // 
            this.btAddLinha.Location = new System.Drawing.Point(12, 124);
            this.btAddLinha.Margin = new System.Windows.Forms.Padding(2);
            this.btAddLinha.Name = "btAddLinha";
            this.btAddLinha.Size = new System.Drawing.Size(142, 20);
            this.btAddLinha.TabIndex = 6;
            this.btAddLinha.Text = "Adicionar Linha";
            this.btAddLinha.UseVisualStyleBackColor = true;
            this.btAddLinha.Click += new System.EventHandler(this.btAddLinha_Click);
            // 
            // llinatotal
            // 
            this.llinatotal.AutoSize = true;
            this.llinatotal.Location = new System.Drawing.Point(262, 229);
            this.llinatotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llinatotal.Name = "llinatotal";
            this.llinatotal.Size = new System.Drawing.Size(37, 13);
            this.llinatotal.TabIndex = 10;
            this.llinatotal.Text = "(Valor)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Linha de Compras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Compras";
            // 
            // btApagarLinha
            // 
            this.btApagarLinha.Location = new System.Drawing.Point(324, 239);
            this.btApagarLinha.Margin = new System.Windows.Forms.Padding(2);
            this.btApagarLinha.Name = "btApagarLinha";
            this.btApagarLinha.Size = new System.Drawing.Size(68, 26);
            this.btApagarLinha.TabIndex = 5;
            this.btApagarLinha.Text = "Apagar";
            this.btApagarLinha.UseVisualStyleBackColor = true;
            this.btApagarLinha.Click += new System.EventHandler(this.btApagarLinha_Click);
            // 
            // btApagarCompra
            // 
            this.btApagarCompra.Location = new System.Drawing.Point(119, 239);
            this.btApagarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btApagarCompra.Name = "btApagarCompra";
            this.btApagarCompra.Size = new System.Drawing.Size(64, 25);
            this.btApagarCompra.TabIndex = 4;
            this.btApagarCompra.Text = "Apagar";
            this.btApagarCompra.UseVisualStyleBackColor = true;
            this.btApagarCompra.Click += new System.EventHandler(this.btApagarCompra_Click);
            // 
            // btCriarCompra
            // 
            this.btCriarCompra.Location = new System.Drawing.Point(17, 239);
            this.btCriarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btCriarCompra.Name = "btCriarCompra";
            this.btCriarCompra.Size = new System.Drawing.Size(90, 25);
            this.btCriarCompra.TabIndex = 3;
            this.btCriarCompra.Text = "Criar Compra";
            this.btCriarCompra.UseVisualStyleBackColor = true;
            this.btCriarCompra.Click += new System.EventHandler(this.btCriarCompra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btAddCliente;
        private System.Windows.Forms.ListBox listBoxCliente;
        private System.Windows.Forms.Label ltotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNif;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.ListBox Lblinhacompra;
        private System.Windows.Forms.ListBox listBoxCompras;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button btAddLinha;
        private System.Windows.Forms.Label llinatotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btApagarLinha;
        private System.Windows.Forms.Button btApagarCompra;
        private System.Windows.Forms.Button btCriarCompra;
    }
}

