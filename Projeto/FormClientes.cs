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
        public dbStandContainer dbcontainer = null;
        public Cliente cliente = null;

        public FormClientes(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
            cliente = form.cliente;
            (from pessoa in dbcontainer.ClienteSet
             orderby pessoa.Nome
             select pessoa).Load();
            clienteBindingSource.DataSource = dbcontainer.ClienteSet.Local.ToBindingList();
           
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                cliente = clienteDataGridView.CurrentRow.DataBoundItem as Cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sem itens", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dbcontainer.SaveChanges();
            try
            {
                cliente = clienteDataGridView.CurrentRow.DataBoundItem as Cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sem itens", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filtrar_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;

                dbcontainer = new dbStandContainer();
                String textoFiltro = textBoxFiltrar.Text;

                (from pessoa in dbcontainer.ClienteSet
                 where pessoa.Nome.ToUpper().Contains(textoFiltro.ToUpper())
                 orderby pessoa.Nome
                 select pessoa).Load();

                clienteBindingSource.DataSource = dbcontainer.ClienteSet.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                dbcontainer.Dispose();
                dbcontainer = new dbStandContainer();

                (from pessoa in dbcontainer.ClienteSet
                 orderby pessoa.Nome
                 select pessoa).Load();

                clienteBindingSource.DataSource = dbcontainer.ClienteSet.Local.ToBindingList();
            }
        }
    }
}
