using Microsoft.Win32;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> clienteList = [];
        public Form1()
        {
            InitializeComponent();

            endereco EnderecoEliezer = new endereco()
            {
                Logradouro = "Endereco de Eliezer",
                complemento = "lado do bar",
                NumeroCasa = 10,
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
                NumeroCasa = 40,
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
                NumeroCasa = 15,
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
                MessageBox.Show("Por favor, selecione seu GÍnero.");
            }
        }

          

private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Masculino");
            comboBox1.Items.Add("Femino");
            comboBox1.Items.Add("Outros");
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


            string Nome = textBoxNomeSocial.Text;
            string nomesocial = textNomeCompleto.Text;
            string telefone = maskedTextBoxTel.Text;
            string data = maskedTextBoxData.Text;
            string email = textBoxEmail.Text;

            static bool ValidarFormulario(string nome, string email, string telefone,string nomesocial)
            {
                // ValidaÁ„o do Nome
                if (!Regex.IsMatch(nome, @"^[A-Za-z·‡‚„ÈËÍÌÔÛÙıˆ˙ÁÒ¡¿¬√…» Õœ”‘’÷⁄«—\s]+$"))
                {
                    MessageBox.Show("O nome deve conter apenas letras e espaÁos.");
                    return false;
                }

                // ValidaÁ„o de Email
                if (!Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
                {
                    Console.WriteLine("Por favor, insira um email v·lido.");
                    return false;
                }

                // ValidaÁ„o de Telefone
                if (!Regex.IsMatch(telefone, @"^\d+$"))
                {
                    Console.WriteLine("O telefone deve conter apenas n˙meros.");
                    return false;
                }

                return true; // Se todas as validaÁıes passarem
            }


            if (string.IsNullOrWhiteSpace(nomesocial))
                {
                    MessageBox.Show("Por favor instira um Nome Social");
                    return ;
                }
            
            if (string.IsNullOrWhiteSpace(Nome))
            {
                MessageBox.Show("nome completo precisa ser preenchido. ");
                return;

            }
            else 
                    {
               
            }

                if (string.IsNullOrWhiteSpace(data))
                {
                    MessageBox.Show("Data precisa ser inserido.");
                    return;

                }
                if (string.IsNullOrWhiteSpace(telefone))
                {
                    MessageBox.Show("Telefone precisa ser inserido.");
                    return;

                }
                if (ValidarFormulario(Nome, email, telefone,nomesocial))
                {
                    MessageBox.Show("Formul·rio v·lido. Cadastro realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Formul·rio inv·lido. Verifique os campos.");
                }
            }

            
        }
    }
    


