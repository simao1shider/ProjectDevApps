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
    [Serializable]
    public partial class FormOficina : Form
    {
        public dbStandContainerDA dbcontainer = null;

        public FormOficina(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
            
            listBoxClientes.DataSource = dbcontainer.Cliente.ToList<Cliente>();
        }

        private void guardarCarro_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            CarroOficina carroOficina = new CarroOficina();

            DialogResult save = MessageBox.Show("Quer guardar o carro?", "Sim", MessageBoxButtons.YesNo);

            if (save == DialogResult.Yes)
            {
                if (EmptyTextBoxVerify(textNChassis, textMarca, textModelo, textCombustivel, textMatricula, textKms))
                {
                    carroOficina.NumeroChassis = textNChassis.Text;
                    carroOficina.Marca = textMarca.Text;
                    carroOficina.Matricula = textMatricula.Text;
                    carroOficina.Modelo = textModelo.Text;
                    carroOficina.Kms = Convert.ToInt32(textKms.Text);
                    carroOficina.Combustivel = textCombustivel.Text;

                    cliente.CarroOficina.Add(carroOficina);
                    dbcontainer.SaveChanges();
                    limpaTextBox();

                    listBoxCarros.DataSource = null;
                    if (cliente != null)
                    {
                        listBoxCarros.DataSource = cliente.CarroOficina.ToList<CarroOficina>();
                    }
                }
            }
        }

        private void guardarServico_Click(object sender, EventArgs e)
        {
            CarroOficina carroOficina = listBoxCarros.SelectedItem as CarroOficina;
            Servico servico = new Servico();
            DialogResult save = MessageBox.Show("Quer inserir o servico?", "Sim", MessageBoxButtons.YesNo);

            if (save == DialogResult.Yes)
            {
                if (EmptyTextBoxVerify(textTipo))
                {
                    servico.DataEntrada = Convert.ToDateTime(dateTimePickerInicio.Text);
                    servico.DataSaida = Convert.ToDateTime(dateTimePickerFim.Text);
                    servico.Tipo = textTipo.Text;

                    
                    if (carroOficina != null)
                    {
                        carroOficina.Servico.Add(servico);
                        dbcontainer.SaveChanges();
                        limpaTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Tem de selecionar um Carro!", "Erro");
                    }

                    listBoxServicos.DataSource = null;
                    if (carroOficina != null)
                    {
                        listBoxServicos.DataSource = carroOficina.Servico.ToList<Servico>();
                    }
                }
            }
            else
            {
                limpaTextBox();
            }
        }

        private void guardarParcela_Click(object sender, EventArgs e)
        {
            Servico servico = listBoxServicos.SelectedItem as Servico;
            CarroOficina carroOficina = listBoxCarros.SelectedItem as CarroOficina;
            Parcela parcela = new Parcela();
            DialogResult save = MessageBox.Show("Quer inserir parcela?", "Sim", MessageBoxButtons.YesNo);

            if (EmptyTextBoxVerify(textDescricao, textValor))
            {
                if (!decimal.TryParse(textValor.Text.Replace('.', ','), out decimal valor))
                {
                    textValor.Text = string.Empty;
                    textValor.Focus();
                    MessageBox.Show("Tem de introduzir um numero!", "Erro");
                    return;
                }

                parcela.Valor = valor;
                parcela.Descricao = textDescricao.Text;

                if (servico != null)
                {
                    servico.Parcela.Add(parcela);
                    dbcontainer.SaveChanges();
                    limpaTextBox();
                }
                else
                {
                    MessageBox.Show("Tem de selecionar um servico!", "Erro");
                }
                

                listBoxServicos.DataSource = null;
                if (carroOficina != null)
                {
                    listBoxServicos.DataSource = carroOficina.Servico.ToList<Servico>();
                }

                listBoxParcelas.DataSource = null;
                if (servico != null)
                {
                    listBoxParcelas.DataSource = servico.Parcela.ToList<Parcela>();
                }
            }
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            listBoxCarros.DataSource = null;

            if (cliente != null)
            {
                listBoxCarros.DataSource = cliente.CarroOficina.ToList<CarroOficina>();
            }
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOficina carroOficina = listBoxCarros.SelectedItem as CarroOficina;
            listBoxServicos.DataSource = null;

            if (carroOficina != null)
            {
                listBoxServicos.DataSource = carroOficina.Servico.ToList<Servico>();
            }
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servico = listBoxServicos.SelectedItem as Servico;
            listBoxParcelas.DataSource = null;

            if (servico != null)
            {
                listBoxParcelas.DataSource = servico.Parcela.ToList<Parcela>();
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

        public void limpaTextBox()
        {
            textNChassis.Text = "";
            textMarca.Text = "";
            textModelo.Text = "";
            textCombustivel.Text = "";
            textMatricula.Text = "";
            textKms.Text = "";
            textTipo.Text = "";
            textDescricao.Text = "";
            textValor.Text = "";
        }

        private void ApagarCarro_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;

            CarroOficina carroOficina = listBoxCarros.SelectedItem as CarroOficina;

            DialogResult delete = MessageBox.Show("Tem a certeza que pretende apagar o Carro?", "Sim, Apagar!!", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                if (listBoxServicos.SelectedItem != null)
                {
                    MessageBox.Show("Nao pode apagar carro com servicos associados!", "ERRO", MessageBoxButtons.OK);
                    return;
                }

                if (carroOficina != null)
                {
                    dbcontainer.Carro.Remove(carroOficina);
                    dbcontainer.SaveChanges();
                    MessageBox.Show("Carro removido com sucesso!", "REMOVER", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Nenhum Carro selecionado!", "REMOVER", MessageBoxButtons.OK);
                }                

                listBoxCarros.DataSource = null;
                if (cliente != null)
                {
                    listBoxCarros.DataSource = cliente.CarroOficina.ToList<CarroOficina>();
                }
            }
        }

        private void apagarServico_Click(object sender, EventArgs e)
        {
            CarroOficina carroOficina = listBoxCarros.SelectedItem as CarroOficina;

            Servico servico = listBoxServicos.SelectedItem as Servico;

            DialogResult delete = MessageBox.Show("Tem a certeza que pretende apagar o Servico?", "Sim, Apagar!!", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                if (listBoxParcelas.SelectedItem != null)
                {
                    MessageBox.Show("Nao pode apagar servico com parcelas associados!", "ERRO", MessageBoxButtons.OK);
                    return;
                }

                dbcontainer.Servico.Remove(servico);
                dbcontainer.SaveChanges();

                MessageBox.Show("Servico removido com sucesso!", "REMOVER", MessageBoxButtons.OK);

                listBoxServicos.DataSource = null;
                if (carroOficina != null)
                {
                    listBoxServicos.DataSource = carroOficina.Servico.ToList<Servico>();
                }
            }
        }

        private void apagarParcela_Click(object sender, EventArgs e)
        {
            Servico servico = listBoxServicos.SelectedItem as Servico;

            Parcela parcela = listBoxParcelas.SelectedItem as Parcela;

            DialogResult delete = MessageBox.Show("Tem a certeza que pretende apagar a Parcela?", "Sim, Apagar!!", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                if (parcela != null)
                {
                    dbcontainer.Parcela.Remove(parcela);
                    dbcontainer.SaveChanges();
                    MessageBox.Show("Parcela removido com sucesso!", "REMOVER", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Nenhuma Parcela selecionada!", "REMOVER", MessageBoxButtons.OK);
                }

                listBoxParcelas.DataSource = null;
                if (servico != null)
                {
                    listBoxParcelas.DataSource = servico.Parcela.ToList<Parcela>();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBoxClientes.SelectedIndex != -1 || listBoxCarros.SelectedIndex != -1 || listBoxServicos.SelectedIndex != -1)
            {

                Cliente cliente = listBoxClientes.SelectedItem as Cliente;
                CarroOficina carroOficina = listBoxCarros.SelectedItem as CarroOficina;
                Servico servico = listBoxServicos.SelectedItem as Servico;

                if(cliente != null)
                {
                    if(carroOficina != null)
                    {
                        if(servico != null) {

                        }
                        else
                        {
                            MessageBox.Show("Tem de ter servicos para exportar fatura!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tem de ter carros para exportar fatura!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tem de ter clientes para exportar fatura!");
                    return;
                }

                saveFileDialog.Filter = "Ficheiro TXT (.txt)|.txt";
                saveFileDialog.FileName = cliente.Nome + "" + carroOficina.Matricula + "" + servico.Tipo + ".txt";

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
                    ficheiro.WriteLine("Marca: " + carroOficina.Marca);
                    ficheiro.WriteLine("Modelo: " + carroOficina.Modelo);
                    ficheiro.WriteLine("Matrícula: " + carroOficina.Matricula);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine("____________SERVIÇOS____________");
                    ficheiro.WriteLine("Serviço: " + servico.Tipo);
                    ficheiro.WriteLine("Entrada: " + servico.DataEntrada.ToString("MM/dd/yyyy"));
                    ficheiro.WriteLine("Saída: " + servico.DataSaida.ToString("MM/dd/yyyy"));
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine(separador);
                    ficheiro.WriteLine(string.Empty);
                    ficheiro.WriteLine("____________PARCELAS____________");
                    ficheiro.WriteLine("Parcelas: ");
                    foreach (Parcela parcela in servico.Parcela)
                    {
                        ficheiro.WriteLine(parcela.Descricao + " (" + parcela.Valor + "€)");
                    }
                    ficheiro.WriteLine(separador);
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
