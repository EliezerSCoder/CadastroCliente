using Microsoft.Win32;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> clienteList = [];
        private readonly BindingSource BindingSource = [];

        public Form1()
        {
            InitializeComponent();

            endereco EnderecoEliezer = new endereco()
            {
                Logradouro = "Endereco de Eliezer",
                complemento = "lado do bar",
                NumeroCasa = "10",
                Bairro = "pq ",
                Municipio = "Embu",
                Estado = "Sao Paulo",
                Cep = "06900-000",

            };
            Cliente Eliezer = new Cliente
            {
                Id = 1,
                Nome = "Eliezer dos Santos",
                nomesocial = "Eliezer",
                data = "14/11/1996",
                telefone = "1104199999",
                EnderecoCliente = EnderecoEliezer,
                generos = generos.Masculino,
                etnia = etinia.Pardo,
                tipocliente = TipoCliente.PF,
                email = "eliezerdossantos@gmail.com",
            };

            clienteList.Add(Eliezer);



            endereco EnderecoAriane = new endereco()
            {
                Logradouro = "Endereco de Ariane",
                complemento = "lado impar ",
                NumeroCasa = "40",
                Bairro = "jd ",
                Municipio = "grajau",
                Estado = "Sao Paulo",
                Cep = "04940-000",

            };
            Cliente Ariane = new Cliente
            {
                Id = 2,
                Nome = "Ariane Prado",
                nomesocial = "Ariane",
                data = "14/09/1995",
                telefone = "1190411239",
                EnderecoCliente = EnderecoAriane,
                generos = generos.Feminino,
                etnia = etinia.Pardo,
                tipocliente = TipoCliente.PF,
                email = "ariane123@gmail.com",
            };

            clienteList.Add(Ariane);

            endereco EnderecoMarta = new endereco()
            {
                Logradouro = "Endereco de Marta",
                complemento = "lado do bar",
                NumeroCasa = "15",
                Bairro = "pq ",
                Municipio = "Embu",
                Estado = "Sao Paulo",
                Cep = "06900-000",

            };
            Cliente Marta = new Cliente
            {
                Id = 3,
                Nome = "Marta Elias",
                nomesocial = "Marta ",
                data = "29/06/1959",
                telefone = "110411239",
                EnderecoCliente = EnderecoMarta,
                generos = generos.Feminino,
                etnia = etinia.Pardo,
                tipocliente = TipoCliente.PF,
                email = "marta32123@gmail.com",
            };

            clienteList.Add(Marta);

            BindingSource.DataSource = dataGridView1;
            dataGridView1.DataSource = BindingSource;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Masculino");
            comboBox1.Items.Add("Femino");
            comboBox1.Items.Add("Outros");
            if (comboBox1.SelectedItem != null)
            {
                string itemSelecionado = comboBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, selecione seu Gênero.");
            }
        }



        private void comboBoxEtnia_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            comboBox1.Items.Add("Masculino");
            comboBox1.Items.Add("Femino");
            comboBox1.Items.Add("Outros");

            if (comboBox2.SelectedItem != null)
            {

                string itemSelecionado = comboBox2.SelectedItem.ToString();

            }
            else
            {

                MessageBox.Show("Por favor, selecione sua Etnia.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                
            if (!ValidarCampos())
                return;

            if (clienteList.Any(c => c.email == textBoxEmail.Text))
            {
                MessageBox.Show("O email já está cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clienteList.Any(c => c.telefone == maskedCep.Text))
            {
                MessageBox.Show("O telefone já está cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Cliente novoCliente = new Cliente
            {
                Id = ContadorClientes.Contador + 1,
                Nome = textNomeCompleto.Text,
                telefone = maskedTextBoxTel.Text,
                data = maskedTextBoxData.Text,
                nomesocial = textBoxNomeSocial.Text,
                email = textBoxEmail.Text,

            };


            endereco novoEndereco = new endereco
            {
                Cep = maskedCep.Text,
                Logradouro = textBoxLogradouro.Text,
                complemento = textBoxComplemento.Text,
                Bairro = textBoxBairro.Text,
                NumeroCasa = textBoxNumero.Text,


            };

            TipoCliente tipo;
            if (radioButton2.Checked == true)
            {
                tipo = TipoCliente.PF;
            }
            else
            {
                tipo = TipoCliente.PJ;
            }


            clienteList.Add(novoCliente);
            BindingSource.Add(novoEndereco);
            BindingSource.ResetBindings(false);

            ContadorClientes.Incrementar();

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();


        }


        private bool ValidarCampos()
        {
            string mensagemErro = "";

            if (string.IsNullOrWhiteSpace(textBoxNomeSocial.Text))
                mensagemErro += "- O campo Nome Social é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(textNomeCompleto.Text))
                mensagemErro += "- O campo Nome completo é obrigatório.\n";


            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || !textBoxEmail.Text.Contains("@"))
                mensagemErro += "- O campo Email é obrigatório e deve ser válido.\n";

            if (!ValidarData(maskedTextBoxData.Text))
                mensagemErro += "- O campo Data de Nascimento deve estar no formato válido (dia/mês/Ano).\n";

            if (!ValidarCep(maskedCep.Text))
                mensagemErro += "- O campo CEP deve estar no formato válido do Brasil.\n";

            if (string.IsNullOrWhiteSpace(textBoxLogradouro.Text) || !textBoxLogradouro.Text.Contains("@"))
                mensagemErro += "- O campo Logradouro é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(textBoxComplemento.Text) || !textBoxComplemento.Text.Contains("@"))
                mensagemErro += "- O campo Complemento é obrigatório .\n";



            if (!string.IsNullOrEmpty(mensagemErro))
            {
                label17.Text = mensagemErro;
                label17.ForeColor = System.Drawing.Color.Red;
                return false;
            }


            label17.Text = "";
            return true;
        }
        

        private bool ValidarCep(string cep)
        {
            if (cep.Length == 9 && cep.Contains("-"))
            {
                string[] partesCep = cep.Split('-');
                if (partesCep.Length == 2 && partesCep[0].Length == 5 && partesCep[1].Length == 3)
                {
                    return int.TryParse(partesCep[0], out _) && int.TryParse(partesCep[1], out _);
                }
            }
            return false;
        }

        private bool ValidarTelefone(string telefone)
        {
            if (telefone.StartsWith("(") && telefone.Contains(")") && telefone.Contains("-"))
            {
                string numerosTelefone = telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                return numerosTelefone.Length == 11 && long.TryParse(numerosTelefone, out _);
            }
            return false;
        }

        private bool ValidarData(string data)
        {
            DateTime temp;
            return DateTime.TryParse(data, out temp);
        }


        private void LimparCampos()
        {

            maskedCep.Clear();
            maskedTextBoxData.Clear();
            textBoxLogradouro.Clear();
            comboBox1.SelectedIndex = -1;
            textBoxEmail.Clear();
            maskedTextBoxData.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            textBoxComplemento.Clear();


            radioButton2.Checked = false;
            radioButton1.Checked = false;
            checkBox1.Checked = false;


            label8.Text = "";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("AC");
            comboBox1.Items.Add("AL");
            comboBox1.Items.Add("AP");
            comboBox1.Items.Add("AM");
            comboBox1.Items.Add("BA");
            comboBox1.Items.Add("CE");
            comboBox1.Items.Add("DF");
            comboBox1.Items.Add("ES");
            comboBox1.Items.Add("GO");
            comboBox1.Items.Add("MA");
            comboBox1.Items.Add("MT");
            comboBox1.Items.Add("MS");
            comboBox1.Items.Add("MG");           
            comboBox1.Items.Add("PA");
            comboBox1.Items.Add("PR");
            comboBox1.Items.Add("PE");
            comboBox1.Items.Add("PI");
            comboBox1.Items.Add("RJ");
            comboBox1.Items.Add("RN");
            comboBox1.Items.Add("RS");
            comboBox1.Items.Add("RO");
            comboBox1.Items.Add("RR");
            comboBox1.Items.Add("SC");
            comboBox1.Items.Add("SP");
            comboBox1.Items.Add("SE");
            comboBox1.Items.Add("TO");

            if (comboBox1.SelectedItem != null)
            {
                string itemSelecionado = comboBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, selecione seu Gênero.");
            }
        }
    }


    public class CadastroCliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }
        public string NomeSocial { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public bool CategoriaPF { get; set; }
        public bool CategoriaPJ { get; set; }
        public bool Estrangeiro { get; set; }
    }
}


