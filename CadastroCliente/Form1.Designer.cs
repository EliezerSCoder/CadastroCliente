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
            textNomeCompleto = new TextBox();
            maskedTextBoxData = new MaskedTextBox();
            maskedTextBoxTel = new MaskedTextBox();
            textBoxEmail = new TextBox();
            comboBox1 = new ComboBox();
            textBoxNomeSocial = new TextBox();
            comboBoxEtnia = new ComboBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
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
            SuspendLayout();
            // 
            // textNomeCompleto
            // 
            textNomeCompleto.Location = new Point(326, 135);
            textNomeCompleto.Name = "textNomeCompleto";
            textNomeCompleto.Size = new Size(316, 23);
            textNomeCompleto.TabIndex = 0;
            // 
            // maskedTextBoxData
            // 
            maskedTextBoxData.Location = new Point(454, 82);
            maskedTextBoxData.Name = "maskedTextBoxData";
            maskedTextBoxData.Size = new Size(123, 23);
            maskedTextBoxData.TabIndex = 1;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(518, 187);
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(124, 23);
            maskedTextBoxTel.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(327, 187);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(178, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Feminino ", "Outros" });
            comboBox1.Location = new Point(521, 239);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(327, 82);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(100, 23);
            textBoxNomeSocial.TabIndex = 5;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco", "Pardo", "Negro", "Amarelo", "Indigina " });
            comboBoxEtnia.Location = new Point(327, 239);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(125, 23);
            comboBoxEtnia.TabIndex = 6;
            comboBoxEtnia.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(534, 116);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Sou Estrangeiro";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(439, 292);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pessoa Física";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 135);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(161, 186);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(91, 23);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 239);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(138, 23);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 186);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 13;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(12, 288);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 117);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 16;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 64);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 17;
            label2.Text = "Data De Nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 169);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 18;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 168);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 19;
            label4.Text = "E-mail Valido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 221);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 20;
            label5.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 64);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 21;
            label6.Text = "Nome Social:";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(321, 221);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 23;
            label8.Text = "Etnia:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(538, 292);
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
            label9.Location = new Point(12, 117);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 25;
            label9.Text = "Logradouro:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(161, 168);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 26;
            label10.Text = "Numero:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 221);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 27;
            label11.Text = "Complemento:";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 168);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 28;
            label12.Text = "Bairro:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(161, 221);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 29;
            label13.Text = "Cidade:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 270);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 30;
            label14.Text = "Cep:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(338, 296);
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
            label7.Location = new Point(12, 82);
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
            label16.Location = new Point(327, 9);
            label16.Name = "label16";
            label16.Size = new Size(297, 37);
            label16.TabIndex = 33;
            label16.Text = "CADASTRAR CLIENTE ";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(418, 335);
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
            comboBox2.Location = new Point(161, 239);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(47, 23);
            comboBox2.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 394);
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
            Controls.Add(maskedTextBox3);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
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
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private MaskedTextBox maskedTextBox3;
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
    }
}
