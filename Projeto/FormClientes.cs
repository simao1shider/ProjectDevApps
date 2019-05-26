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
        private dbStandContainer meuExemplo;

        public FormClientes(Form form)
        {
            InitializeComponent();
            meuExemplo = new dbStandContainer();
            (from pessoa in meuExemplo.ClienteSet
             orderby pessoa.Nome
             select pessoa).Load();
            clienteBindingSource.DataSource = meuExemplo.ClienteSet.Local.ToBindingList();

            //ClassCliente cliente = clienteDataGridView.CurrentRow.DataBoundItem as ClassCliente;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            meuExemplo.SaveChanges();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void filtrar_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;
                meuExemplo = new dbStandContainer();
                String textoFiltro = textBoxFiltrar.Text;

                (from pessoa in meuExemplo.ClienteSet
                 where pessoa.Nome.ToUpper().Contains(textoFiltro.ToUpper())
                 orderby pessoa.Nome
                 select pessoa).Load();

                clienteBindingSource.DataSource = meuExemplo.ClienteSet.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                meuExemplo.Dispose();
                meuExemplo = new dbStandContainer();

                (from pessoa in meuExemplo.ClienteSet
                 orderby pessoa.Nome
                 select pessoa).Load();

                clienteBindingSource.DataSource = meuExemplo.ClienteSet.Local.ToBindingList();
            }
        }
    }
}
