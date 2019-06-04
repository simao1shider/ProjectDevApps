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
    public partial class FormOficina : Form
    {
        public dbStandContainer dbcontainer = null;
        public Cliente cliente = null;
        public Home formu = null;


        public FormOficina(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
            cliente = form.cliente;
            formu = form;
            (from pessoa in dbcontainer.ClienteSet
             orderby pessoa.Nome
             select pessoa).Load();
            listBoxClientes.DataSource = dbcontainer.ClienteSet.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCarros carro = new FormCarros(formu);
            carro.Show();
        }
    }
}
