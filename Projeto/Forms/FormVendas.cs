using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormVendas : Form
    {
        public dbStandContainer dbcontainer = null;
        public Cliente cliente = null;
        public Venda venda = null;

        public FormVendas(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;

            listBoxClientes.DataSource = dbcontainer.ClienteSet.ToList<Cliente>();
        }

        private void guardarParcela_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            Venda venda = new Venda();
            venda.CarroVenda = new CarroVenda();

            DialogResult save = MessageBox.Show("Tem a certeza que quer inserir esta venda?", "Sim", MessageBoxButtons.YesNo);

            if (save == DialogResult.Yes)
            {
                if (EmptyTextBoxVerify(textNChassi, textMarca, textModelo, textCombustivel, textExtras, textEstado, textValor)) {
                     
                    if (!decimal.TryParse(textValor.Text.Replace('.', ','), out decimal valor))
                    {
                        textValor.Text = string.Empty;
                        textValor.Focus();
                        MessageBox.Show("Tem de introduzir um numero!", "Erro");
                        return;
                    }

                    venda.Estado = textEstado.Text;
                    venda.Data = Convert.ToDateTime(dateTimePicker.Text);
                    venda.Valor = valor;

                    venda.CarroVenda.NumeroChassis = textNChassi.Text;
                    venda.CarroVenda.Marca = textMarca.Text;
                    venda.CarroVenda.Modelo = textModelo.Text;
                    venda.CarroVenda.Combustivel = textCombustivel.Text;
                    venda.CarroVenda.Extras = textExtras.Text;

                    cliente.Vendas.Add(venda);

                    try
                    {
                        dbcontainer.SaveChanges();
                    }
                    catch(System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("Erro, tem de iserir os dados corretamente!", "Erro");
                    }
                    

                    cliente = listBoxClientes.SelectedItem as Cliente;

                    listBoxVendas.DataSource = null;

                    if (cliente != null)
                    {
                        listBoxVendas.DataSource = cliente.Vendas.ToList<Venda>();

                    }

                    limpaTextBox();
                    MessageBox.Show("Venda inserida com sucesso!", "GUARDAR");
                }
            }
            else
            {
                limpaTextBox();
            }
        }

        private void apagarParcela_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            Venda venda = listBoxVendas.SelectedItem as Venda;
            CarroVenda carroVenda = venda.CarroVenda;

            DialogResult delete = MessageBox.Show("Tem a certeza que pretende apagar a Parcela?", "Sim, Apagar!!", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                dbcontainer.CarroSet.Remove(carroVenda);
                dbcontainer.VendaSet.Remove(venda);
                dbcontainer.SaveChanges();

                MessageBox.Show("Venda removido com sucesso!", "REMOVER", MessageBoxButtons.OK);

                listBoxVendas.DataSource = null;
                if (cliente != null)
                {
                    listBoxVendas.DataSource = cliente.Vendas.ToList<Venda>();
                }
            }
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente = listBoxClientes.SelectedItem as Cliente;

            listBoxVendas.DataSource = null;

            if (cliente != null)
            {
                listBoxVendas.DataSource = cliente.Vendas.ToList<Venda>();

            }
            
        }

        private void listBoxVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            venda = listBoxVendas.SelectedItem as Venda;
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

        public void limpaTextBox()
        {
            textNChassi.Text = "";
            textMarca.Text = "";
            textModelo.Text = "";
            textCombustivel.Text = "";
            textExtras.Text = "";
            textEstado.Text = "";
            textValor.Text = "";
        }
    }
}
