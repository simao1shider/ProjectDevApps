namespace Projeto
{
    partial class FormCarroTeste
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarroTeste));
            System.Windows.Forms.Label combustivelLabel;
            System.Windows.Forms.Label idCarroLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numeroChassisLabel;
            this.carroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.carroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carroDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.idCarroTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            combustivelLabel = new System.Windows.Forms.Label();
            idCarroLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingNavigator)).BeginInit();
            this.carroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carroBindingNavigator
            // 
            this.carroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carroBindingNavigator.BindingSource = this.carroBindingSource;
            this.carroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carroBindingNavigatorSaveItem});
            this.carroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carroBindingNavigator.Name = "carroBindingNavigator";
            this.carroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carroBindingNavigator.Size = new System.Drawing.Size(887, 25);
            this.carroBindingNavigator.TabIndex = 0;
            this.carroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // carroBindingNavigatorSaveItem
            // 
            this.carroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carroBindingNavigatorSaveItem.Enabled = false;
            this.carroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carroBindingNavigatorSaveItem.Image")));
            this.carroBindingNavigatorSaveItem.Name = "carroBindingNavigatorSaveItem";
            this.carroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carroBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // carroDataGridView
            // 
            this.carroDataGridView.AutoGenerateColumns = false;
            this.carroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.carroDataGridView.DataSource = this.carroBindingSource;
            this.carroDataGridView.Location = new System.Drawing.Point(12, 43);
            this.carroDataGridView.Name = "carroDataGridView";
            this.carroDataGridView.Size = new System.Drawing.Size(540, 220);
            this.carroDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCarro";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCarro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumeroChassis";
            this.dataGridViewTextBoxColumn2.HeaderText = "NumeroChassis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Combustivel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Combustivel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(Projeto.Carro);
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.Location = new System.Drawing.Point(621, 106);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(67, 13);
            combustivelLabel.TabIndex = 2;
            combustivelLabel.Text = "Combustivel:";
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(713, 103);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(100, 20);
            this.combustivelTextBox.TabIndex = 3;
            // 
            // idCarroLabel
            // 
            idCarroLabel.AutoSize = true;
            idCarroLabel.Location = new System.Drawing.Point(621, 132);
            idCarroLabel.Name = "idCarroLabel";
            idCarroLabel.Size = new System.Drawing.Size(47, 13);
            idCarroLabel.TabIndex = 4;
            idCarroLabel.Text = "Id Carro:";
            // 
            // idCarroTextBox
            // 
            this.idCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "IdCarro", true));
            this.idCarroTextBox.Location = new System.Drawing.Point(713, 129);
            this.idCarroTextBox.Name = "idCarroTextBox";
            this.idCarroTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCarroTextBox.TabIndex = 5;
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(621, 158);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 6;
            marcaLabel.Text = "Marca:";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(713, 155);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 7;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(621, 184);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 8;
            modeloLabel.Text = "Modelo:";
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(713, 181);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox.TabIndex = 9;
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.Location = new System.Drawing.Point(621, 210);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(86, 13);
            numeroChassisLabel.TabIndex = 10;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(713, 207);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroChassisTextBox.TabIndex = 11;
            // 
            // FormCarroTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(combustivelLabel);
            this.Controls.Add(this.combustivelTextBox);
            this.Controls.Add(idCarroLabel);
            this.Controls.Add(this.idCarroTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(numeroChassisLabel);
            this.Controls.Add(this.numeroChassisTextBox);
            this.Controls.Add(this.carroDataGridView);
            this.Controls.Add(this.carroBindingNavigator);
            this.Name = "FormCarroTeste";
            this.Text = "FormCarroTeste";
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingNavigator)).EndInit();
            this.carroBindingNavigator.ResumeLayout(false);
            this.carroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.BindingNavigator carroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carroBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView carroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox combustivelTextBox;
        private System.Windows.Forms.TextBox idCarroTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox numeroChassisTextBox;
    }
}