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
    public partial class Home : Form
    {
        private DateTime contadorTempo;
        public dbStandContainer dbcontainer = new dbStandContainer();
        public Cliente cliente = new Cliente();
        public Venda venda = new Venda();
        public Aluguer aluguer = new Aluguer();
        public Carro carro = new Carro();
        public CarroOfficina carroOficina = new CarroOfficina();
        public Servico servico = new Servico();
        public Parcela parcela = new Parcela();

        public Home()
        {
            InitializeComponent();
            contadorTempo = new DateTime(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToLongTimeString();

            numClientes.Text = "Clientes: " + (from cliente in dbcontainer.ClienteSet
                                               select cliente).Count();
            numVendas.Text = "Vendas: " + (from venda in dbcontainer.VendaSet
                                               select venda).Count();
            numAlugueres.Text = "Alugueres: " + (from aluguer in dbcontainer.AluguerSet
                                               select aluguer).Count();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes(this);
            clientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOficina oficina = new FormOficina(this);
            oficina.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormVendas vendas = new FormVendas(this);
            vendas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAlugueres alugueres = new FormAlugueres(this);
            alugueres.Show();
        }
    }
}
