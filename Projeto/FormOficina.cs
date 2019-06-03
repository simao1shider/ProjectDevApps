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


        public FormOficina(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
            cliente = form.cliente;
            (from pessoa in dbcontainer.ClienteSet
             orderby pessoa.Nome
             select pessoa).Load();
            listBoxClientes.DataSource = dbcontainer.ClienteSet.Local.ToBindingList();
        }

    }
}
