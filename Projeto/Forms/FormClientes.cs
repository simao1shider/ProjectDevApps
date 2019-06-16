using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Projeto
{
    public partial class FormClientes : Form
    {
        public dbStandContainerDA dbcontainer = null;
        public Cliente cliente = null;

        public FormClientes(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
            cliente = form.cliente;
            (from pessoa in dbcontainer.Cliente
             orderby pessoa.Nome
             select pessoa).Load();
            clienteBindingSource.DataSource = dbcontainer.Cliente.Local.ToBindingList();

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            if(cliente != null)
            {
                cliente = clienteDataGridView.CurrentRow.DataBoundItem as Cliente;
            }
            else
            {
                MessageBox.Show("Nao existem clientes!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (EmptyTextBoxVerify(contactoTextBox, moradaTextBox, nIFTextBox, nomeTextBox))
            {
                if (cliente != null)
                {
                    dbcontainer.SaveChanges();
                    cliente = clienteDataGridView.CurrentRow.DataBoundItem as Cliente;
                }
                else
                {
                    MessageBox.Show("Nao existem clientes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool EmptyTextBoxVerify(params TextBox[] campos)
        {
            foreach (TextBox textBox in campos)
            {
                if (textBox.Text == string.Empty)
                {
                    MessageBox.Show("Tem de preencher todos os campos!", "ERRO");
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private void filtrar_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;

                dbcontainer = new dbStandContainerDA();
                String textoFiltro = textBoxFiltrar.Text;

                (from pessoa in dbcontainer.Cliente
                 where pessoa.Nome.ToUpper().Contains(textoFiltro.ToUpper())
                 orderby pessoa.Nome
                 select pessoa).Load();

                clienteBindingSource.DataSource = dbcontainer.Cliente.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                dbcontainer.Dispose();
                dbcontainer = new dbStandContainerDA();

                (from pessoa in dbcontainer.Cliente
                 orderby pessoa.Nome
                 select pessoa).Load();

                clienteBindingSource.DataSource = dbcontainer.Cliente.Local.ToBindingList();
            }
        }
    }
}
