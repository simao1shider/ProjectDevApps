using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormCarros : Form
    {
        public dbStandContainer dbcontainer = null;
        public Carro carro = null;
        public FormCarros(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
            carro = form.carro;
            (from carro in dbcontainer.CarroSet
             select carro).Load();
          carroBindingSource.DataSource = dbcontainer.CarroSet.Local.ToBindingList();
        }

        private void carroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dbcontainer.SaveChanges();
            try
            {
                carro = carroDataGridView.CurrentRow.DataBoundItem as Carro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sem itens", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCarros_Load(object sender, EventArgs e)
        {
            try
            {
                carro = carroDataGridView.CurrentRow.DataBoundItem as Carro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sem itens", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filtrarbtn_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;

                dbcontainer = new dbStandContainer();
                String textoFiltro = textBoxFiltrar.Text;

                (from carro in dbcontainer.CarroSet
                 where carro.Modelo.ToUpper().Contains(textoFiltro.ToUpper())
                 orderby carro.Modelo
                 select carro).Load();

                carroDataGridView.DataSource = dbcontainer.CarroSet.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                dbcontainer.Dispose();
                dbcontainer = new dbStandContainer();

                (from carro in dbcontainer.CarroSet
                 orderby carro.Modelo
                 select carro).Load();

                carroDataGridView.DataSource = dbcontainer.CarroSet.Local.ToBindingList();
            }
        }
    }
}
