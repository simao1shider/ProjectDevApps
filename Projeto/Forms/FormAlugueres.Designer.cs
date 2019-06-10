namespace Projeto
{
    partial class FormAlugueres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlugueres));
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.listBoxAlugueres = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textKms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.apagarAluguer = new System.Windows.Forms.Button();
            this.guardarAluguer = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ApagarCarro = new System.Windows.Forms.Button();
            this.guardarCarro = new System.Windows.Forms.Button();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.textCombustivel = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textNChassis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 12);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(192, 290);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(210, 12);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(270, 290);
            this.listBoxCarros.TabIndex = 1;
            // 
            // listBoxAlugueres
            // 
            this.listBoxAlugueres.FormattingEnabled = true;
            this.listBoxAlugueres.Location = new System.Drawing.Point(486, 12);
            this.listBoxAlugueres.Name = "listBoxAlugueres";
            this.listBoxAlugueres.Size = new System.Drawing.Size(239, 290);
            this.listBoxAlugueres.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textKms);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.apagarAluguer);
            this.tabPage2.Controls.Add(this.guardarAluguer);
            this.tabPage2.Controls.Add(this.textValor);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dateTimePickerFim);
            this.tabPage2.Controls.Add(this.dateTimePickerInicio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adicionar Servico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textKms
            // 
            this.textKms.Location = new System.Drawing.Point(337, 42);
            this.textKms.Name = "textKms";
            this.textKms.Size = new System.Drawing.Size(127, 20);
            this.textKms.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kms:";
            // 
            // apagarAluguer
            // 
            this.apagarAluguer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apagarAluguer.BackgroundImage")));
            this.apagarAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apagarAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apagarAluguer.ForeColor = System.Drawing.Color.Transparent;
            this.apagarAluguer.Location = new System.Drawing.Point(661, 52);
            this.apagarAluguer.Margin = new System.Windows.Forms.Padding(0);
            this.apagarAluguer.Name = "apagarAluguer";
            this.apagarAluguer.Size = new System.Drawing.Size(41, 39);
            this.apagarAluguer.TabIndex = 15;
            this.apagarAluguer.UseVisualStyleBackColor = true;
            this.apagarAluguer.Click += new System.EventHandler(this.apagarAluguer_Click);
            // 
            // guardarAluguer
            // 
            this.guardarAluguer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarAluguer.BackgroundImage")));
            this.guardarAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guardarAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarAluguer.ForeColor = System.Drawing.Color.Transparent;
            this.guardarAluguer.Location = new System.Drawing.Point(661, 3);
            this.guardarAluguer.Margin = new System.Windows.Forms.Padding(0);
            this.guardarAluguer.Name = "guardarAluguer";
            this.guardarAluguer.Size = new System.Drawing.Size(41, 39);
            this.guardarAluguer.TabIndex = 14;
            this.guardarAluguer.UseVisualStyleBackColor = true;
            this.guardarAluguer.Click += new System.EventHandler(this.guardarAluguer_Click);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(337, 10);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(127, 20);
            this.textValor.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Data Fim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data Inicio:";
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFim.Location = new System.Drawing.Point(86, 43);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerFim.TabIndex = 1;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(86, 11);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerInicio.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ApagarCarro);
            this.tabPage1.Controls.Add(this.guardarCarro);
            this.tabPage1.Controls.Add(this.textMatricula);
            this.tabPage1.Controls.Add(this.textCombustivel);
            this.tabPage1.Controls.Add(this.textModelo);
            this.tabPage1.Controls.Add(this.textMarca);
            this.tabPage1.Controls.Add(this.textNChassis);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Carro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ApagarCarro
            // 
            this.ApagarCarro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ApagarCarro.BackgroundImage")));
            this.ApagarCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ApagarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApagarCarro.ForeColor = System.Drawing.Color.Transparent;
            this.ApagarCarro.Location = new System.Drawing.Point(661, 52);
            this.ApagarCarro.Margin = new System.Windows.Forms.Padding(0);
            this.ApagarCarro.Name = "ApagarCarro";
            this.ApagarCarro.Size = new System.Drawing.Size(41, 39);
            this.ApagarCarro.TabIndex = 13;
            this.ApagarCarro.UseVisualStyleBackColor = true;
            this.ApagarCarro.Click += new System.EventHandler(this.ApagarCarro_Click);
            // 
            // guardarCarro
            // 
            this.guardarCarro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarCarro.BackgroundImage")));
            this.guardarCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guardarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarCarro.ForeColor = System.Drawing.Color.Transparent;
            this.guardarCarro.Location = new System.Drawing.Point(661, 3);
            this.guardarCarro.Margin = new System.Windows.Forms.Padding(0);
            this.guardarCarro.Name = "guardarCarro";
            this.guardarCarro.Size = new System.Drawing.Size(41, 39);
            this.guardarCarro.TabIndex = 12;
            this.guardarCarro.UseVisualStyleBackColor = true;
            this.guardarCarro.Click += new System.EventHandler(this.guardarCarro_Click);
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(367, 39);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(145, 20);
            this.textMatricula.TabIndex = 9;
            // 
            // textCombustivel
            // 
            this.textCombustivel.Location = new System.Drawing.Point(367, 13);
            this.textCombustivel.Name = "textCombustivel";
            this.textCombustivel.Size = new System.Drawing.Size(145, 20);
            this.textCombustivel.TabIndex = 7;
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(95, 65);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(145, 20);
            this.textModelo.TabIndex = 5;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(95, 39);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(145, 20);
            this.textMarca.TabIndex = 3;
            // 
            // textNChassis
            // 
            this.textNChassis.Location = new System.Drawing.Point(95, 13);
            this.textNChassis.Name = "textNChassis";
            this.textNChassis.Size = new System.Drawing.Size(145, 20);
            this.textNChassis.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matricula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Combustivel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Chassis:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(12, 308);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 120);
            this.tabControl1.TabIndex = 6;
            // 
            // FormAlugueres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 433);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxAlugueres);
            this.Controls.Add(this.listBoxCarros);
            this.Controls.Add(this.listBoxClientes);
            this.Name = "FormAlugueres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlugueres";
            this.Load += new System.EventHandler(this.FormAlugueres_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.ListBox listBoxAlugueres;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textKms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button apagarAluguer;
        private System.Windows.Forms.Button guardarAluguer;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ApagarCarro;
        private System.Windows.Forms.Button guardarCarro;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.TextBox textCombustivel;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textNChassis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}