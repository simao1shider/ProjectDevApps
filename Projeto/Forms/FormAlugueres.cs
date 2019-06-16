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
    public partial class FormAlugueres : Form
    {
        public dbStandContainerDA dbcontainer = null;
        public FormAlugueres(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
        }

        private void FormAlugueres_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = dbcontainer.Cliente.ToList<Cliente>();
            listBoxCarros.DataSource = dbcontainer.Carro.OfType<CarroAluguer>().ToList();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;

            listBoxAlugueres.DataSource = null;

            if (cliente != null)
            {
                listBoxAlugueres.DataSource = cliente.Aluguer.ToList<Aluguer>();

            }
        }

        private void guardarCarro_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;

            CarroAluguer carroAluguer = new CarroAluguer();


            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir este carro ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if(cliente == null)
                {
                    MessageBox.Show("Tem de inserir clientes!", "ERRO");
                    return;
                }

                if (EmptyTextBoxVerify(textNChassis, textMarca, textModelo, textCombustivel, textMatricula))
                {

                    carroAluguer.NumeroChassis = textNChassis.Text;
                    carroAluguer.Marca = textMarca.Text;
                    carroAluguer.Modelo = textModelo.Text;
                    carroAluguer.Combustivel = textCombustivel.Text;
                    carroAluguer.Matricula = textMatricula.Text;
                    carroAluguer.Estado = "Disponivel";

                    dbcontainer.Carro.Add(carroAluguer);

                    dbcontainer.SaveChanges();

                    listBoxCarros.DataSource = dbcontainer.Carro.OfType<CarroAluguer>().ToList();
                    MessageBox.Show("Carro inserido!", "SUCESSO");
                }
            }

        }

        private void ApagarCarro_Click(object sender, EventArgs e)
        {
            CarroAluguer carroAluguer = listBoxCarros.SelectedItem as CarroAluguer;

            DialogResult delete = MessageBox.Show("Quer mesmo remover o carro? ", "Apagar", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                if (carroAluguer == null)
                {
                    MessageBox.Show("Nao existem carros para remover!", "ERRO");
                    return;
                }

                if (carroAluguer.Estado == "Indisponivel")
                {
                    MessageBox.Show("Nao e possivel apagar porque o carro tem Alugueres associados", "Erro");
                }
                else
                {
                    dbcontainer.Carro.Remove(carroAluguer);

                    dbcontainer.SaveChanges();

                    listBoxCarros.DataSource = dbcontainer.Carro.OfType<CarroAluguer>().ToList();

                    MessageBox.Show("Carro Removido!", "SUCESSO");
                }
            }
        }

        private void guardarAluguer_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            CarroAluguer carroAluguer = listBoxCarros.SelectedItem as CarroAluguer;
            Aluguer aluguer = new Aluguer();


            DialogResult save = MessageBox.Show("Quer mesmo inserir aluguer?", "SALVAR", MessageBoxButtons.YesNo);

            if (save == DialogResult.Yes)
            {
                if (EmptyTextBoxVerify(textValor, textKms))
                {
                    if (!decimal.TryParse(textValor.Text.Replace('.', ','), out decimal valor))
                    {
                        textValor.Text = string.Empty;
                        textValor.Focus();
                        MessageBox.Show("Tem de introduzir um numero!", "Erro");
                        return;
                    }

                    if(carroAluguer.Estado == "Indisponivel")
                    {
                        MessageBox.Show("Tem de inserir outro carro este ja está em aluguer!", "Erro");
                        return;
                    }

                    carroAluguer.Estado = "Indisponivel";
                    aluguer.DataInicio = Convert.ToDateTime(dateTimePickerInicio.Text);
                    aluguer.DataFim = Convert.ToDateTime(dateTimePickerFim.Text);
                    aluguer.Kms = Convert.ToInt32(textKms.Text);
                    aluguer.Valor = valor;
                    aluguer.Cliente = cliente;
                    aluguer.CarroAluguer = carroAluguer;

                    dbcontainer.Aluguer.Add(aluguer);

                    dbcontainer.SaveChanges();

                    cliente = listBoxClientes.SelectedItem as Cliente;
                    listBoxAlugueres.DataSource = cliente.Aluguer.ToList();
                    listBoxCarros.DataSource = dbcontainer.Carro.OfType<CarroAluguer>().ToList();
                    MessageBox.Show("Aluguer Inserido!", "SUCESSO");
                }
            }
        }

        private void apagarAluguer_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            Aluguer aluguer = listBoxAlugueres.SelectedItem as Aluguer;

            DialogResult delete = MessageBox.Show("Quer mesmo remover o Aluguer? ", "Apagar", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                if(aluguer == null)
                {
                    MessageBox.Show("Nao existem alugueres para remover!", "ERRO");
                    return;
                }
                aluguer.CarroAluguer.Estado = "Disponivel";
                dbcontainer.Aluguer.Remove(aluguer);
                dbcontainer.SaveChanges();

                listBoxAlugueres.DataSource = cliente.Aluguer.ToList();
                listBoxCarros.DataSource = dbcontainer.Carro.OfType<CarroAluguer>().ToList();
                MessageBox.Show("Aluguer Removido!", "SUCESSO");

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex != -1 || listBoxAlugueres.SelectedIndex != -1)
            {

                Cliente cliente = listBoxClientes.SelectedItem as Cliente;
                Aluguer aluguer = listBoxAlugueres.SelectedItem as Aluguer;
                if (cliente != null)
                {
                    if (aluguer != null)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Tem de ter alugueres para exportar fatura!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tem de ter clientes para exportar fatura!");
                    return;
                }

                saveFileDialog.Filter = "Ficheiro TXT (.txt)|.txt";
                saveFileDialog.FileName = cliente.Nome + "_Kms" + aluguer.Kms + ".txt";

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
                    ficheiro.WriteLine("N Chassi: " + aluguer.CarroAluguer.NumeroChassis);
                    ficheiro.WriteLine("Marca: " + aluguer.CarroAluguer.Marca);
                    ficheiro.WriteLine("Modelo: " + aluguer.CarroAluguer.Modelo);
                    ficheiro.WriteLine("Combustivel: " + aluguer.CarroAluguer.Combustivel);
                    ficheiro.WriteLine("Matricula: " + aluguer.CarroAluguer.Matricula);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine("____________Aluguer____________");
                    ficheiro.WriteLine("Kms: " + aluguer.Kms);
                    ficheiro.WriteLine("Data Inicio: " + aluguer.DataInicio);
                    ficheiro.WriteLine("Data Fim: " + aluguer.DataFim);
                    ficheiro.WriteLine("Valor: " + aluguer.Valor);
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
