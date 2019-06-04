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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valorTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteSelecionado = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxParcelas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.valorTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.clienteSelecionado);
            this.groupBox2.Location = new System.Drawing.Point(242, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // valorTotal
            // 
            this.valorTotal.AutoSize = true;
            this.valorTotal.Location = new System.Drawing.Point(614, 19);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(64, 13);
            this.valorTotal.TabIndex = 3;
            this.valorTotal.Text = "Valor Total: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // clienteSelecionado
            // 
            this.clienteSelecionado.AutoSize = true;
            this.clienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.clienteSelecionado.Location = new System.Drawing.Point(7, 20);
            this.clienteSelecionado.Name = "clienteSelecionado";
            this.clienteSelecionado.Size = new System.Drawing.Size(287, 29);
            this.clienteSelecionado.TabIndex = 0;
            this.clienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBoxCarros);
            this.groupBox3.Location = new System.Drawing.Point(243, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 354);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Criar Carro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(6, 19);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(207, 303);
            this.listBoxCarros.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.listBoxServicos);
            this.groupBox4.Location = new System.Drawing.Point(469, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 354);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serviços";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 324);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.Location = new System.Drawing.Point(7, 20);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(194, 303);
            this.listBoxServicos.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxParcelas);
            this.groupBox5.Location = new System.Drawing.Point(683, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 354);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parcelas";
            // 
            // listBoxParcelas
            // 
            this.listBoxParcelas.FormattingEnabled = true;
            this.listBoxParcelas.Location = new System.Drawing.Point(6, 19);
            this.listBoxParcelas.Name = "listBoxParcelas";
            this.listBoxParcelas.Size = new System.Drawing.Size(244, 329);
            this.listBoxParcelas.TabIndex = 0;
            // 
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 499);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormOficina";
            this.Text = "Gestão Oficina";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label valorTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label clienteSelecionado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxServicos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxParcelas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}