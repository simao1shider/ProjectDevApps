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
    public partial class FormCarros1 : Form
    {
        public dbStandContainer dbcontainer = null;
        public Carro carro = null;
        public FormCarros1(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
            carro = form.carro;
            (from pessoa in dbcontainer.ClienteSet
             orderby pessoa.Nome
             select pessoa).Load();
            carroDataGridView.DataSource = dbcontainer.ClienteSet.Local.ToBindingList();
        }

        private void carroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dbcontainer.SaveChanges();
            carro = carroDataGridView.CurrentRow.DataBoundItem as Carro;
        }

        private void FormCarros_Load(object sender, EventArgs e)
        {
            carro = carroDataGridView.CurrentRow.DataBoundItem as Carro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxfiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;

                dbcontainer = new dbStandContainer();
                String textoFiltro = textBoxfiltrar.Text;

                (from carro in dbcontainer.CarroSet
                 where carro.Modelo.ToUpper().Contains(textoFiltro.ToUpper())
                 orderby carro.Modelo
                 select carro).Load();

                carroDataGridView.DataSource = dbcontainer.ClienteSet.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                dbcontainer.Dispose();
                dbcontainer = new dbStandContainer();

                (from carro in dbcontainer.CarroSet
                 orderby carro.Modelo
                 select carro).Load();

                carroDataGridView.DataSource = dbcontainer.ClienteSet.Local.ToBindingList();
            }
        }
    }
}
