namespace CadastroCliente
{
    partial class Form1
    {
       

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textNomeCompleto = new TextBox();
            maskedTextBoxData = new MaskedTextBox();
            maskedTextBoxTel = new MaskedTextBox();
            textBoxEmail = new TextBox();
            comboBox1 = new ComboBox();
            textBoxNomeSocial = new TextBox();
            comboBoxEtnia = new ComboBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            textBoxLogradouro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxBairro = new TextBox();
            maskedCep = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            radioButton2 = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label7 = new Label();
            label16 = new Label();
            buttonCadastrar = new Button();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textNomeCompleto
            // 
            textNomeCompleto.Location = new Point(320, 145);
            textNomeCompleto.Name = "textNomeCompleto";
            textNomeCompleto.Size = new Size(321, 23);
            textNomeCompleto.TabIndex = 0;
            textNomeCompleto.TextChanged += textNomeCompleto_TextChanged;
            // 
            // maskedTextBoxData
            // 
            maskedTextBoxData.Location = new Point(521, 91);
            maskedTextBoxData.Name = "maskedTextBoxData";
            maskedTextBoxData.Size = new Size(123, 23);
            maskedTextBoxData.TabIndex = 1;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(516, 189);
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(124, 23);
            maskedTextBoxTel.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(320, 189);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(177, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Feminino ", "Outros" });
            comboBox1.Location = new Point(514, 236);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(320, 91);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(100, 23);
            textBoxNomeSocial.TabIndex = 5;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco", "Pardo", "Negro", "Amarelo", "Indigina " });
            comboBoxEtnia.Location = new Point(320, 236);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(125, 23);
            comboBoxEtnia.TabIndex = 6;
            comboBoxEtnia.SelectedIndexChanged += comboBoxEtnia_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(536, 126);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Sou Estrangeiro";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(417, 270);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pessoa Física";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(2, 91);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(240, 23);
            textBoxLogradouro.TabIndex = 10;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(130, 145);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(91, 23);
            textBoxNumero.TabIndex = 11;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(2, 213);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(138, 23);
            textBoxComplemento.TabIndex = 12;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(2, 145);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(100, 23);
            textBoxBairro.TabIndex = 13;
            textBoxBairro.TextChanged += textBox8_TextChanged;
            // 
            // maskedCep
            // 
            maskedCep.Location = new Point(2, 265);
            maskedCep.Name = "maskedCep";
            maskedCep.Size = new Size(100, 23);
            maskedCep.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 126);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 16;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(521, 73);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 17;
            label2.Text = "Data De Nascimento:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 171);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 18;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 171);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 19;
            label4.Text = "E-mail Valido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 221);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 20;
            label5.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 73);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 21;
            label6.Text = "Nome Social:";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(320, 221);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 23;
            label8.Text = "Etnia:";
            label8.Click += label8_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(525, 269);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 19);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pessoa Juridica";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 73);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 25;
            label9.Text = "Logradouro:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(130, 126);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 26;
            label10.Text = "Numero:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(2, 189);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 27;
            label11.Text = "Complemento:";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(2, 126);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 28;
            label12.Text = "Bairro:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(161, 189);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 29;
            label13.Text = "Cidade:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(2, 247);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 30;
            label14.Text = "Cep:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(323, 274);
            label15.Name = "label15";
            label15.Size = new Size(88, 15);
            label15.TabIndex = 31;
            label15.Text = "Tipo de Pessoa:";
            label15.Click += label15_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(2, 14);
            label7.Name = "label7";
            label7.Size = new Size(288, 32);
            label7.TabIndex = 32;
            label7.Text = "CADASTRAR ENDEREÇO";
            label7.Click += label7_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(321, 9);
            label16.Name = "label16";
            label16.Size = new Size(297, 37);
            label16.TabIndex = 33;
            label16.Text = "CADASTRAR CLIENTE ";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(130, 252);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(139, 37);
            buttonCadastrar.TabIndex = 34;
            buttonCadastrar.Text = "CADASTRAR";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBox2.Location = new Point(161, 213);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(47, 23);
            comboBox2.TabIndex = 35;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(756, 117);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(2, 291);
            label17.Name = "label17";
            label17.Size = new Size(0, 15);
            label17.TabIndex = 36;
            label17.Click += label17_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 403);
            Controls.Add(label17);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(buttonCadastrar);
            Controls.Add(label16);
            Controls.Add(label7);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(radioButton2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedCep);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(comboBoxEtnia);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(comboBox1);
            Controls.Add(textBoxEmail);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(maskedTextBoxData);
            Controls.Add(textNomeCompleto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNomeCompleto;
        private MaskedTextBox maskedTextBoxData;
        private MaskedTextBox maskedTextBoxTel;
        private TextBox textBoxEmail;
        private ComboBox comboBox1;
        private TextBox textBoxNomeSocial;
        private ComboBox comboBoxEtnia;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumero;
        private TextBox textBoxComplemento;
        private TextBox textBoxBairro;
        private MaskedTextBox maskedCep;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private RadioButton radioButton2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label7;
        private Label label16;
        private Button buttonCadastrar;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label17;
    }
}
