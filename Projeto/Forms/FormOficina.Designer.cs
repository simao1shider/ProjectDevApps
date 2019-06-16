namespace Projeto
{
    partial class FormOficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOficina));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxParcelas = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ApagarCarro = new System.Windows.Forms.Button();
            this.guardarCarro = new System.Windows.Forms.Button();
            this.textKms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCombustivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNChassis = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.apagarServico = new System.Windows.Forms.Button();
            this.guardarServico = new System.Windows.Forms.Button();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.apagarParcela = new System.Windows.Forms.Button();
            this.guardarParcela = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxClientes);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Cliente";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(6, 19);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(221, 472);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxCarros);
            this.groupBox3.Location = new System.Drawing.Point(241, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 496);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carros";
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(6, 19);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(207, 472);
            this.listBoxCarros.TabIndex = 0;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBoxCarros_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxServicos);
            this.groupBox4.Location = new System.Drawing.Point(466, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 496);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serviços";
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.Location = new System.Drawing.Point(7, 20);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(211, 472);
            this.listBoxServicos.TabIndex = 0;
            this.listBoxServicos.SelectedIndexChanged += new System.EventHandler(this.listBoxServicos_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxParcelas);
            this.groupBox5.Location = new System.Drawing.Point(696, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 496);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parcelas";
            // 
            // listBoxParcelas
            // 
            this.listBoxParcelas.FormattingEnabled = true;
            this.listBoxParcelas.Location = new System.Drawing.Point(6, 19);
            this.listBoxParcelas.Name = "listBoxParcelas";
            this.listBoxParcelas.Size = new System.Drawing.Size(244, 472);
            this.listBoxParcelas.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(241, 500);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 120);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ApagarCarro);
            this.tabPage1.Controls.Add(this.guardarCarro);
            this.tabPage1.Controls.Add(this.textKms);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textMatricula);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textCombustivel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textModelo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textMarca);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textNChassis);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 94);
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
            this.ApagarCarro.Location = new System.Drawing.Point(659, 52);
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
            this.guardarCarro.Location = new System.Drawing.Point(659, 3);
            this.guardarCarro.Margin = new System.Windows.Forms.Padding(0);
            this.guardarCarro.Name = "guardarCarro";
            this.guardarCarro.Size = new System.Drawing.Size(41, 39);
            this.guardarCarro.TabIndex = 12;
            this.guardarCarro.UseVisualStyleBackColor = true;
            this.guardarCarro.Click += new System.EventHandler(this.guardarCarro_Click);
            // 
            // textKms
            // 
            this.textKms.Location = new System.Drawing.Point(367, 65);
            this.textKms.Name = "textKms";
            this.textKms.Size = new System.Drawing.Size(145, 20);
            this.textKms.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kms:";
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(367, 39);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(145, 20);
            this.textMatricula.TabIndex = 9;
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
            // textCombustivel
            // 
            this.textCombustivel.Location = new System.Drawing.Point(367, 13);
            this.textCombustivel.Name = "textCombustivel";
            this.textCombustivel.Size = new System.Drawing.Size(145, 20);
            this.textCombustivel.TabIndex = 7;
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
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(95, 65);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(145, 20);
            this.textModelo.TabIndex = 5;
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
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(95, 39);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(145, 20);
            this.textMarca.TabIndex = 3;
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
            // textNChassis
            // 
            this.textNChassis.Location = new System.Drawing.Point(95, 13);
            this.textNChassis.Name = "textNChassis";
            this.textNChassis.Size = new System.Drawing.Size(145, 20);
            this.textNChassis.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.apagarServico);
            this.tabPage2.Controls.Add(this.guardarServico);
            this.tabPage2.Controls.Add(this.textTipo);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dateTimePickerFim);
            this.tabPage2.Controls.Add(this.dateTimePickerInicio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adicionar Servico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // apagarServico
            // 
            this.apagarServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apagarServico.BackgroundImage")));
            this.apagarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apagarServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apagarServico.ForeColor = System.Drawing.Color.Transparent;
            this.apagarServico.Location = new System.Drawing.Point(659, 52);
            this.apagarServico.Margin = new System.Windows.Forms.Padding(0);
            this.apagarServico.Name = "apagarServico";
            this.apagarServico.Size = new System.Drawing.Size(41, 39);
            this.apagarServico.TabIndex = 15;
            this.apagarServico.UseVisualStyleBackColor = true;
            this.apagarServico.Click += new System.EventHandler(this.apagarServico_Click);
            // 
            // guardarServico
            // 
            this.guardarServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarServico.BackgroundImage")));
            this.guardarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guardarServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarServico.ForeColor = System.Drawing.Color.Transparent;
            this.guardarServico.Location = new System.Drawing.Point(659, 3);
            this.guardarServico.Margin = new System.Windows.Forms.Padding(0);
            this.guardarServico.Name = "guardarServico";
            this.guardarServico.Size = new System.Drawing.Size(41, 39);
            this.guardarServico.TabIndex = 14;
            this.guardarServico.UseVisualStyleBackColor = true;
            this.guardarServico.Click += new System.EventHandler(this.guardarServico_Click);
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(337, 10);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(127, 20);
            this.textTipo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tipo:";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.apagarParcela);
            this.tabPage3.Controls.Add(this.guardarParcela);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.textValor);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textDescricao);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(703, 94);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adicionar Parcela";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // apagarParcela
            // 
            this.apagarParcela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apagarParcela.BackgroundImage")));
            this.apagarParcela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apagarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apagarParcela.ForeColor = System.Drawing.Color.Transparent;
            this.apagarParcela.Location = new System.Drawing.Point(660, 55);
            this.apagarParcela.Margin = new System.Windows.Forms.Padding(0);
            this.apagarParcela.Name = "apagarParcela";
            this.apagarParcela.Size = new System.Drawing.Size(41, 39);
            this.apagarParcela.TabIndex = 17;
            this.apagarParcela.UseVisualStyleBackColor = true;
            this.apagarParcela.Click += new System.EventHandler(this.apagarParcela_Click);
            // 
            // guardarParcela
            // 
            this.guardarParcela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarParcela.BackgroundImage")));
            this.guardarParcela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guardarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarParcela.ForeColor = System.Drawing.Color.Transparent;
            this.guardarParcela.Location = new System.Drawing.Point(660, 1);
            this.guardarParcela.Margin = new System.Windows.Forms.Padding(0);
            this.guardarParcela.Name = "guardarParcela";
            this.guardarParcela.Size = new System.Drawing.Size(41, 39);
            this.guardarParcela.TabIndex = 16;
            this.guardarParcela.UseVisualStyleBackColor = true;
            this.guardarParcela.Click += new System.EventHandler(this.guardarParcela_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Valor:";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(92, 55);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(169, 20);
            this.textValor.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Descricao:";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(92, 20);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(169, 20);
            this.textDescricao.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(963, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormOficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Oficina";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxServicos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxParcelas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNChassis;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ApagarCarro;
        private System.Windows.Forms.Button guardarCarro;
        private System.Windows.Forms.TextBox textKms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCombustivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button apagarServico;
        private System.Windows.Forms.Button guardarServico;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Button apagarParcela;
        private System.Windows.Forms.Button guardarParcela;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}