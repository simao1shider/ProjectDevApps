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
    public partial class FormAlugueres : Form
    {
        public dbStandContainer dbcontainer = null;
        public FormAlugueres(Home form)
        {
            InitializeComponent();
            dbcontainer = form.dbcontainer;
        }

        private void FormAlugueres_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = dbcontainer.ClienteSet.ToList<Cliente>();
            listBoxCarros.DataSource = dbcontainer.CarroSet.OfType<CarroAluguer>().ToList();
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
            Cliente clienteSelecionado = listBoxClientes.SelectedItem as Cliente;

            CarroAluguer carroAluguer = new CarroAluguer();


            DialogResult guardar = MessageBox.Show("Tem a certeza que pertende inserir este carro ? ", "SALVAR", MessageBoxButtons.YesNo);

            if (guardar == DialogResult.Yes)
            {
                if (EmptyTextBoxVerify(textNChassis, textMarca, textModelo, textCombustivel, textMatricula))
                {

                    carroAluguer.NumeroChassis = textNChassis.Text;
                    carroAluguer.Marca = textMarca.Text;
                    carroAluguer.Modelo = textModelo.Text;
                    carroAluguer.Combustivel = textCombustivel.Text;
                    carroAluguer.Matricula = textMatricula.Text;
                    carroAluguer.Estado = "Disponivel";

                    dbcontainer.CarroSet.Add(carroAluguer);

                    dbcontainer.SaveChanges();

                    listBoxCarros.DataSource = dbcontainer.CarroSet.OfType<CarroAluguer>().ToList();
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
                if (carroAluguer.Estado == "Indisponivel")
                {
                    MessageBox.Show("Nao e possivel apagar porque o carro tem Alugueres associados", "Erro");
                }
                else
                {
                    dbcontainer.CarroSet.Remove(carroAluguer);

                    dbcontainer.SaveChanges();

                    listBoxCarros.DataSource = dbcontainer.CarroSet.OfType<CarroAluguer>().ToList();

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

                    carroAluguer.Estado = "Indisponivel";
                    aluguer.DataInicio = Convert.ToDateTime(dateTimePickerInicio.Text);
                    aluguer.DataFim = Convert.ToDateTime(dateTimePickerFim.Text);
                    aluguer.Kms = Convert.ToInt32(textKms.Text);
                    aluguer.Valor = valor;
                    aluguer.Cliente = cliente;
                    aluguer.CarroAluguer = carroAluguer;

                    dbcontainer.AluguerSet.Add(aluguer);

                    dbcontainer.SaveChanges();

                    listBoxCarros.DataSource = dbcontainer.CarroSet.OfType<CarroAluguer>().ToList();
                    cliente = listBoxClientes.SelectedItem as Cliente;
                    listBoxAlugueres.DataSource = dbcontainer.CarroSet.OfType<CarroAluguer>().ToList();
                    MessageBox.Show("Aluguer Inserido!", "SUCESSO");
                }
            }
        }

        private void apagarAluguer_Click(object sender, EventArgs e)
        {
            Aluguer aluguer = listBoxAlugueres.SelectedItem as Aluguer;

            DialogResult delete = MessageBox.Show("Quer mesmo remover o Aluguer? ", "Apagar", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                aluguer.CarroAluguer.Estado = "Disponivel";
                dbcontainer.AluguerSet.Remove(aluguer);
                dbcontainer.SaveChanges();

                listBoxAlugueres.DataSource = dbcontainer.AluguerSet.OfType<Aluguer>().ToList();
                listBoxCarros.DataSource = dbcontainer.CarroSet.OfType<CarroAluguer>().ToList();
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

        
    }
}
