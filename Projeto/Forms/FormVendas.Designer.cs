namespace Projeto
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxVendas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apagarVenda = new System.Windows.Forms.Button();
            this.guardarVenda = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textExtras = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCombustivel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNChassi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 56);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(214, 355);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // listBoxVendas
            // 
            this.listBoxVendas.FormattingEnabled = true;
            this.listBoxVendas.Location = new System.Drawing.Point(232, 56);
            this.listBoxVendas.Name = "listBoxVendas";
            this.listBoxVendas.Size = new System.Drawing.Size(275, 355);
            this.listBoxVendas.TabIndex = 1;
            this.listBoxVendas.SelectedIndexChanged += new System.EventHandler(this.listBoxVendas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apagarVenda);
            this.groupBox1.Controls.Add(this.guardarVenda);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.textEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textValor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textExtras);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textMarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCombustivel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNChassi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(513, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Venda";
            // 
            // apagarVenda
            // 
            this.apagarVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apagarVenda.BackgroundImage")));
            this.apagarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apagarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apagarVenda.ForeColor = System.Drawing.Color.Transparent;
            this.apagarVenda.Location = new System.Drawing.Point(391, 186);
            this.apagarVenda.Margin = new System.Windows.Forms.Padding(0);
            this.apagarVenda.Name = "apagarVenda";
            this.apagarVenda.Size = new System.Drawing.Size(41, 39);
            this.apagarVenda.TabIndex = 19;
            this.apagarVenda.UseVisualStyleBackColor = true;
            this.apagarVenda.Click += new System.EventHandler(this.apagarParcela_Click);
            // 
            // guardarVenda
            // 
            this.guardarVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarVenda.BackgroundImage")));
            this.guardarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guardarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarVenda.ForeColor = System.Drawing.Color.Transparent;
            this.guardarVenda.Location = new System.Drawing.Point(340, 186);
            this.guardarVenda.Margin = new System.Windows.Forms.Padding(0);
            this.guardarVenda.Name = "guardarVenda";
            this.guardarVenda.Size = new System.Drawing.Size(41, 39);
            this.guardarVenda.TabIndex = 18;
            this.guardarVenda.UseVisualStyleBackColor = true;
            this.guardarVenda.Click += new System.EventHandler(this.guardarParcela_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(295, 97);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker.TabIndex = 16;
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(295, 71);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(137, 20);
            this.textEstado.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data:";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(295, 123);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(137, 20);
            this.textValor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Valor:";
            // 
            // textExtras
            // 
            this.textExtras.Location = new System.Drawing.Point(295, 45);
            this.textExtras.Name = "textExtras";
            this.textExtras.Size = new System.Drawing.Size(137, 20);
            this.textExtras.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Extras:";
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(73, 71);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(141, 20);
            this.textMarca.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca:";
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(73, 97);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(141, 20);
            this.textModelo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            // 
            // textCombustivel
            // 
            this.textCombustivel.Location = new System.Drawing.Point(73, 123);
            this.textCombustivel.Name = "textCombustivel";
            this.textCombustivel.Size = new System.Drawing.Size(141, 20);
            this.textCombustivel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Combustivel:";
            // 
            // textNChassi
            // 
            this.textNChassi.Location = new System.Drawing.Point(73, 45);
            this.textNChassi.Name = "textNChassi";
            this.textNChassi.Size = new System.Drawing.Size(141, 20);
            this.textNChassi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N Chassi:";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxVendas);
            this.Controls.Add(this.listBoxClientes);
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxVendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textExtras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCombustivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNChassi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apagarVenda;
        private System.Windows.Forms.Button guardarVenda;
    }
}