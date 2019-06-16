using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormVendas : Form
    {
        public dbStandContainerDA dbcontainer = null;
        public Cliente cliente = null;
        public Venda venda = null;

        public FormVendas(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;

            listBoxClientes.DataSource = dbcontainer.Cliente.ToList<Cliente>();
        }

        private void guardarParcela_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            Venda venda = new Venda();
            venda.CarroVenda = new CarroVenda();
            if(cliente == null)
            {
                MessageBox.Show("Tem de inserir um cliente para registar uma venda!", "Erro");
                return;
            }
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

                    cliente.Venda.Add(venda);

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
                        listBoxVendas.DataSource = cliente.Venda.ToList<Venda>();

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
            if(venda == null)
            {
                MessageBox.Show("Nao existem vendas da remover!", "ERRO");
                return;
            }
            CarroVenda carroVenda = venda.CarroVenda;

            DialogResult delete = MessageBox.Show("Tem a certeza que pretende apagar a Parcela?", "Sim, Apagar!!", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                dbcontainer.Carro.Remove(carroVenda);
                dbcontainer.Venda.Remove(venda);
                dbcontainer.SaveChanges();

                MessageBox.Show("Venda removido com sucesso!", "REMOVER", MessageBoxButtons.OK);

                listBoxVendas.DataSource = null;
                if (cliente != null)
                {
                    listBoxVendas.DataSource = cliente.Venda.ToList<Venda>();
                }
            }
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente = listBoxClientes.SelectedItem as Cliente;

            listBoxVendas.DataSource = null;

            if (cliente != null)
            {
                listBoxVendas.DataSource = cliente.Venda.ToList<Venda>();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex != -1 || listBoxVendas.SelectedIndex != -1)
            {

                Cliente cliente = listBoxClientes.SelectedItem as Cliente;
                Venda venda = listBoxVendas.SelectedItem as Venda;

                if (cliente != null)
                {
                    if (venda != null)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Tem de ter vendas para exportar fatura!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tem de ter clientes para exportar fatura!");
                    return;
                }

                saveFileDialog.Filter = "Ficheiro TXT (.txt)|.txt";
                saveFileDialog.FileName = cliente.Nome + "" + venda.Estado + ".txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter ficheiro = new StreamWriter(saveFileDialog.FileName, false);
                    string separador = "#########################################################";
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine("Fatura Simplificada");
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine("____________CLIENTE____________");
                    ficheiro.WriteLine("Cliente: " + cliente.Nome);
                    ficheiro.WriteLine("Nif: " + cliente.NIF);
                    ficheiro.WriteLine("Contacto: " + cliente.Contacto);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine("____________CARRO____________");
                    ficheiro.WriteLine("N Chassi: " + venda.CarroVenda.NumeroChassis);
                    ficheiro.WriteLine("Marca: " + venda.CarroVenda.Marca);
                    ficheiro.WriteLine("Modelo: " + venda.CarroVenda.Modelo);
                    ficheiro.WriteLine("Combustivel: " + venda.CarroVenda.Combustivel);
                    ficheiro.WriteLine("Extras: " + venda.CarroVenda.Extras);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine("____________VENDA____________");
                    ficheiro.WriteLine("Estado: " + venda.Estado);
                    ficheiro.WriteLine("Data: " + venda.Data);
                    ficheiro.WriteLine("Valor: " + venda.Valor);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine("Data de Exportação: " + DateTime.Now.ToString());
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(separador);

                    ficheiro.Close();
                    MessageBox.Show("Fatura Exportada com sucesso!");
                }
            }
        }
    }
}
