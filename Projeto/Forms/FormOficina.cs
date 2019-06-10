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

        public FormOficina(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
            
            listBoxClientes.DataSource = dbcontainer.ClienteSet.ToList<Cliente>();
        }

        private void guardarCarro_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            CarroOfficina carroOficina = new CarroOfficina();

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

                    cliente.CarrosOfficina.Add(carroOficina);
                    dbcontainer.SaveChanges();
                    limpaTextBox();

                    listBoxCarros.DataSource = null;
                    if (cliente != null)
                    {
                        listBoxCarros.DataSource = cliente.CarrosOfficina.ToList<CarroOfficina>();
                    }
                }
            }
        }

        private void guardarServico_Click(object sender, EventArgs e)
        {
            CarroOfficina carroOficina = listBoxCarros.SelectedItem as CarroOfficina;
            Servico servico = new Servico();
            DialogResult save = MessageBox.Show("Quer inserir o servico?", "Sim", MessageBoxButtons.YesNo);

            if (save == DialogResult.Yes)
            {
                if (EmptyTextBoxVerify(textTipo))
                {
                    servico.DataEntrada = Convert.ToDateTime(dateTimePickerInicio.Text);
                    servico.DataSaida = Convert.ToDateTime(dateTimePickerFim.Text);
                    servico.Tipo = textTipo.Text;

                    carroOficina.Servicos.Add(servico);
                    dbcontainer.SaveChanges();
                    limpaTextBox();

                    listBoxServicos.DataSource = null;
                    if (carroOficina != null)
                    {
                        listBoxServicos.DataSource = carroOficina.Servicos.ToList<Servico>();
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
            CarroOfficina carroOficina = listBoxCarros.SelectedItem as CarroOfficina;
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

                parcela.Descricao = textDescricao.Text;
                parcela.Valor = valor;

                servico.Parcelas.Add(parcela);
                dbcontainer.SaveChanges();
                limpaTextBox();

                listBoxServicos.DataSource = null;
                if (carroOficina != null)
                {
                    listBoxServicos.DataSource = carroOficina.Servicos.ToList<Servico>();
                }

                listBoxParcelas.DataSource = null;
                if (servico != null)
                {
                    listBoxParcelas.DataSource = servico.Parcelas.ToList<Parcela>();
                }
            }
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            listBoxCarros.DataSource = null;

            if (cliente != null)
            {
                listBoxCarros.DataSource = cliente.CarrosOfficina.ToList<CarroOfficina>();
            }
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOfficina carroOficina = listBoxCarros.SelectedItem as CarroOfficina;
            listBoxServicos.DataSource = null;

            if (carroOficina != null)
            {
                listBoxServicos.DataSource = carroOficina.Servicos.ToList<Servico>();
            }
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servico = listBoxServicos.SelectedItem as Servico;
            listBoxParcelas.DataSource = null;

            if (servico != null)
            {
                listBoxParcelas.DataSource = servico.Parcelas.ToList<Parcela>();
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

            CarroOfficina carroOficina = listBoxCarros.SelectedItem as CarroOfficina;

            DialogResult delete = MessageBox.Show("Tem a certeza que pretende apagar o Carro?", "Sim, Apagar!!", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                if (listBoxServicos.SelectedItem != null)
                {
                    MessageBox.Show("Nao pode apagar carro com servicos associados!", "ERRO", MessageBoxButtons.OK);
                    return;
                }
                   
                dbcontainer.CarroSet.Remove(carroOficina);
                dbcontainer.SaveChanges();

                MessageBox.Show("Carro removido com sucesso!", "REMOVER", MessageBoxButtons.OK);

                listBoxCarros.DataSource = null;
                if (cliente != null)
                {
                    listBoxCarros.DataSource = cliente.CarrosOfficina.ToList<CarroOfficina>();
                }
            }
        }

        private void apagarServico_Click(object sender, EventArgs e)
        {
            CarroOfficina carroOficina = listBoxCarros.SelectedItem as CarroOfficina;

            Servico servico = listBoxServicos.SelectedItem as Servico;

            DialogResult delete = MessageBox.Show("Tem a certeza que pretende apagar o Servico?", "Sim, Apagar!!", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                if (listBoxParcelas.SelectedItem != null)
                {
                    MessageBox.Show("Nao pode apagar servico com parcelas associados!", "ERRO", MessageBoxButtons.OK);
                    return;
                }

                dbcontainer.ServicoSet.Remove(servico);
                dbcontainer.SaveChanges();

                MessageBox.Show("Servico removido com sucesso!", "REMOVER", MessageBoxButtons.OK);

                listBoxServicos.DataSource = null;
                if (carroOficina != null)
                {
                    listBoxServicos.DataSource = carroOficina.Servicos.ToList<Servico>();
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
                dbcontainer.ParcelaSet.Remove(parcela);
                dbcontainer.SaveChanges();

                MessageBox.Show("Parcela removido com sucesso!", "REMOVER", MessageBoxButtons.OK);

                listBoxParcelas.DataSource = null;
                if (servico != null)
                {
                    listBoxParcelas.DataSource = servico.Parcelas.ToList<Parcela>();
                }
            }
        }
    }
}
