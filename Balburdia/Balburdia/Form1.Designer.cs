namespace Balburdia
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
            this.lbNome = new System.Windows.Forms.ListBox();
            this.lbBalburdia = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnBatalhar = new System.Windows.Forms.Button();
            this.btnValores = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.FormattingEnabled = true;
            this.lbNome.ItemHeight = 16;
            this.lbNome.Location = new System.Drawing.Point(22, 70);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(383, 340);
            this.lbNome.TabIndex = 0;
            // 
            // lbBalburdia
            // 
            this.lbBalburdia.FormattingEnabled = true;
            this.lbBalburdia.ItemHeight = 16;
            this.lbBalburdia.Location = new System.Drawing.Point(557, 70);
            this.lbBalburdia.Name = "lbBalburdia";
            this.lbBalburdia.Size = new System.Drawing.Size(629, 340);
            this.lbBalburdia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nomes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Balburdia:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(267, 433);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(102, 38);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnBatalhar
            // 
            this.btnBatalhar.Location = new System.Drawing.Point(411, 185);
            this.btnBatalhar.Name = "btnBatalhar";
            this.btnBatalhar.Size = new System.Drawing.Size(140, 83);
            this.btnBatalhar.TabIndex = 5;
            this.btnBatalhar.Text = "Batalhar>>";
            this.btnBatalhar.UseVisualStyleBackColor = true;
            this.btnBatalhar.Click += new System.EventHandler(this.btnBatalhar_Click);
            // 
            // btnValores
            // 
            this.btnValores.Location = new System.Drawing.Point(557, 433);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(629, 38);
            this.btnValores.TabIndex = 6;
            this.btnValores.Text = "Dar Valores";
            this.btnValores.UseVisualStyleBackColor = true;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero de Iterações: ";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(47, 441);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(187, 22);
            this.txbNome.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(411, 157);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 524);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.btnBatalhar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBalburdia);
            this.Controls.Add(this.lbNome);
            this.Name = "Form1";
            this.Text = "Balburdia";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNome;
        private System.Windows.Forms.ListBox lbBalburdia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnBatalhar;
        private System.Windows.Forms.Button btnValores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

