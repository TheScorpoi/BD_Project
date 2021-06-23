
namespace WineDBInterfaCe
{
    partial class Pessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.countPessoas = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAdega = new System.Windows.Forms.TextBox();
            this.textBoxTerreno = new System.Windows.Forms.TextBox();
            this.textBoxNunFunc = new System.Windows.Forms.TextBox();
            this.textBoxInicioAtiv = new System.Windows.Forms.TextBox();
            this.textBoxSS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIBAN = new System.Windows.Forms.TextBox();
            this.atualizarbutton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.telemovelLabel = new System.Windows.Forms.Label();
            this.GeneroLabel = new System.Windows.Forms.Label();
            this.dataNascLabel = new System.Windows.Forms.Label();
            this.NIFLabel = new System.Windows.Forms.Label();
            this.moradaLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBoxTelemovel = new System.Windows.Forms.TextBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxDataNasc = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listPessoas = new System.Windows.Forms.ListView();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Morada = new System.Windows.Forms.ColumnHeader();
            this.NIF = new System.Windows.Forms.ColumnHeader();
            this.Data_Nasc = new System.Windows.Forms.ColumnHeader();
            this.Genero = new System.Windows.Forms.ColumnHeader();
            this.Telemovel = new System.Windows.Forms.ColumnHeader();
            this.FuncButton = new System.Windows.Forms.Button();
            this.opAgriButton = new System.Windows.Forms.Button();
            this.opAdegaButton = new System.Windows.Forms.Button();
            this.gerenteButton = new System.Windows.Forms.Button();
            this.clienteButton = new System.Windows.Forms.Button();
            this.pessoaButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantidade de Pessoas:";
            // 
            // countPessoas
            // 
            this.countPessoas.AutoSize = true;
            this.countPessoas.Location = new System.Drawing.Point(364, 38);
            this.countPessoas.Name = "countPessoas";
            this.countPessoas.Size = new System.Drawing.Size(31, 20);
            this.countPessoas.TabIndex = 18;
            this.countPessoas.Text = "OO";
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(959, 34);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(94, 29);
            this.Limpar.TabIndex = 17;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(752, 37);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(165, 27);
            this.textBoxPesquisa.TabIndex = 16;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "Morada",
            "NIF",
            "Data de Nascimento",
            "Género",
            "Nº Telemóvel"});
            this.comboBox1.Location = new System.Drawing.Point(562, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(26, 37);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 29);
            this.buttonVoltar.TabIndex = 14;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxAdega);
            this.panel1.Controls.Add(this.textBoxTerreno);
            this.panel1.Controls.Add(this.textBoxNunFunc);
            this.panel1.Controls.Add(this.textBoxInicioAtiv);
            this.panel1.Controls.Add(this.textBoxSS);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxIBAN);
            this.panel1.Controls.Add(this.atualizarbutton);
            this.panel1.Controls.Add(this.inserirButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.telemovelLabel);
            this.panel1.Controls.Add(this.GeneroLabel);
            this.panel1.Controls.Add(this.dataNascLabel);
            this.panel1.Controls.Add(this.NIFLabel);
            this.panel1.Controls.Add(this.moradaLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.textBoxTelemovel);
            this.panel1.Controls.Add(this.textBoxNIF);
            this.panel1.Controls.Add(this.textBoxGenero);
            this.panel1.Controls.Add(this.textBoxMorada);
            this.panel1.Controls.Add(this.textBoxDataNasc);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(26, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 178);
            this.panel1.TabIndex = 13;
            // 
            // textBoxAdega
            // 
            this.textBoxAdega.Location = new System.Drawing.Point(768, 148);
            this.textBoxAdega.Name = "textBoxAdega";
            this.textBoxAdega.PlaceholderText = "(Op. Adega)";
            this.textBoxAdega.Size = new System.Drawing.Size(125, 27);
            this.textBoxAdega.TabIndex = 28;
            // 
            // textBoxTerreno
            // 
            this.textBoxTerreno.Location = new System.Drawing.Point(768, 115);
            this.textBoxTerreno.Name = "textBoxTerreno";
            this.textBoxTerreno.PlaceholderText = "(Op. Agricola)";
            this.textBoxTerreno.Size = new System.Drawing.Size(125, 27);
            this.textBoxTerreno.TabIndex = 27;
            // 
            // textBoxNunFunc
            // 
            this.textBoxNunFunc.Location = new System.Drawing.Point(766, 81);
            this.textBoxNunFunc.Name = "textBoxNunFunc";
            this.textBoxNunFunc.PlaceholderText = "(Op. Agr/Ade/Gerente)";
            this.textBoxNunFunc.Size = new System.Drawing.Size(125, 27);
            this.textBoxNunFunc.TabIndex = 26;
            // 
            // textBoxInicioAtiv
            // 
            this.textBoxInicioAtiv.Location = new System.Drawing.Point(767, 46);
            this.textBoxInicioAtiv.Name = "textBoxInicioAtiv";
            this.textBoxInicioAtiv.PlaceholderText = "(Funcionário)";
            this.textBoxInicioAtiv.Size = new System.Drawing.Size(125, 27);
            this.textBoxInicioAtiv.TabIndex = 25;
            // 
            // textBoxSS
            // 
            this.textBoxSS.Location = new System.Drawing.Point(766, 13);
            this.textBoxSS.Name = "textBoxSS";
            this.textBoxSS.PlaceholderText = "(Funcionário)";
            this.textBoxSS.Size = new System.Drawing.Size(125, 27);
            this.textBoxSS.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID Adega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID Terreno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(699, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nº Func:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Inicio Ativ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nº SS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "IBAN:";
            // 
            // textBoxIBAN
            // 
            this.textBoxIBAN.Location = new System.Drawing.Point(421, 134);
            this.textBoxIBAN.Name = "textBoxIBAN";
            this.textBoxIBAN.PlaceholderText = "(Funcionario)";
            this.textBoxIBAN.Size = new System.Drawing.Size(233, 27);
            this.textBoxIBAN.TabIndex = 17;
            this.textBoxIBAN.Tag = "";
            // 
            // atualizarbutton
            // 
            this.atualizarbutton.Location = new System.Drawing.Point(898, 79);
            this.atualizarbutton.Name = "atualizarbutton";
            this.atualizarbutton.Size = new System.Drawing.Size(94, 29);
            this.atualizarbutton.TabIndex = 16;
            this.atualizarbutton.Text = "Atualizar";
            this.atualizarbutton.UseVisualStyleBackColor = true;
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(898, 34);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(94, 29);
            this.inserirButton.TabIndex = 15;
            this.inserirButton.Text = "Inserir Adega";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Categoria:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pessoa",
            "Op. Agricola",
            "Op. Adega",
            "Gerente",
            "Cliente"});
            this.comboBox2.Location = new System.Drawing.Point(421, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 28);
            this.comboBox2.TabIndex = 13;
            // 
            // telemovelLabel
            // 
            this.telemovelLabel.AutoSize = true;
            this.telemovelLabel.Location = new System.Drawing.Point(331, 54);
            this.telemovelLabel.Name = "telemovelLabel";
            this.telemovelLabel.Size = new System.Drawing.Size(84, 20);
            this.telemovelLabel.TabIndex = 12;
            this.telemovelLabel.Text = "Telemovel: ";
            // 
            // GeneroLabel
            // 
            this.GeneroLabel.AutoSize = true;
            this.GeneroLabel.Location = new System.Drawing.Point(13, 134);
            this.GeneroLabel.Name = "GeneroLabel";
            this.GeneroLabel.Size = new System.Drawing.Size(60, 20);
            this.GeneroLabel.TabIndex = 11;
            this.GeneroLabel.Text = "Genero:";
            // 
            // dataNascLabel
            // 
            this.dataNascLabel.AutoSize = true;
            this.dataNascLabel.Location = new System.Drawing.Point(287, 20);
            this.dataNascLabel.Name = "dataNascLabel";
            this.dataNascLabel.Size = new System.Drawing.Size(127, 20);
            this.dataNascLabel.TabIndex = 10;
            this.dataNascLabel.Text = "Data Nascimento:";
            // 
            // NIFLabel
            // 
            this.NIFLabel.AutoSize = true;
            this.NIFLabel.Location = new System.Drawing.Point(20, 99);
            this.NIFLabel.Name = "NIFLabel";
            this.NIFLabel.Size = new System.Drawing.Size(34, 20);
            this.NIFLabel.TabIndex = 9;
            this.NIFLabel.Text = "NIF:";
            // 
            // moradaLabel
            // 
            this.moradaLabel.AutoSize = true;
            this.moradaLabel.Location = new System.Drawing.Point(5, 62);
            this.moradaLabel.Name = "moradaLabel";
            this.moradaLabel.Size = new System.Drawing.Size(68, 20);
            this.moradaLabel.TabIndex = 8;
            this.moradaLabel.Text = "Morada: ";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(20, 21);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(53, 20);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "Nome:";
            // 
            // textBoxTelemovel
            // 
            this.textBoxTelemovel.Location = new System.Drawing.Point(421, 54);
            this.textBoxTelemovel.Name = "textBoxTelemovel";
            this.textBoxTelemovel.Size = new System.Drawing.Size(233, 27);
            this.textBoxTelemovel.TabIndex = 6;
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(79, 99);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(197, 27);
            this.textBoxNIF.TabIndex = 5;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Location = new System.Drawing.Point(79, 138);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(197, 27);
            this.textBoxGenero.TabIndex = 4;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(79, 55);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(197, 27);
            this.textBoxMorada.TabIndex = 3;
            // 
            // textBoxDataNasc
            // 
            this.textBoxDataNasc.Location = new System.Drawing.Point(421, 21);
            this.textBoxDataNasc.Name = "textBoxDataNasc";
            this.textBoxDataNasc.Size = new System.Drawing.Size(233, 27);
            this.textBoxDataNasc.TabIndex = 2;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(79, 18);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(197, 27);
            this.textBoxNome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(898, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apagar Pessoa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Apagarbutton_Click);
            // 
            // listPessoas
            // 
            this.listPessoas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Morada,
            this.NIF,
            this.Data_Nasc,
            this.Genero,
            this.Telemovel});
            this.listPessoas.HideSelection = false;
            this.listPessoas.Location = new System.Drawing.Point(26, 127);
            this.listPessoas.Name = "listPessoas";
            this.listPessoas.Size = new System.Drawing.Size(1010, 202);
            this.listPessoas.TabIndex = 12;
            this.listPessoas.UseCompatibleStateImageBehavior = false;
            this.listPessoas.View = System.Windows.Forms.View.Details;
            this.listPessoas.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listPessoas_ColumnClick);
            this.listPessoas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listPessoas_ItemSelectionChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 160;
            // 
            // Morada
            // 
            this.Morada.Text = "Morada";
            this.Morada.Width = 270;
            // 
            // NIF
            // 
            this.NIF.Text = "NIF";
            this.NIF.Width = 100;
            // 
            // Data_Nasc
            // 
            this.Data_Nasc.Text = "Data de Nascimento";
            this.Data_Nasc.Width = 200;
            // 
            // Genero
            // 
            this.Genero.Text = "Genero";
            this.Genero.Width = 100;
            // 
            // Telemovel
            // 
            this.Telemovel.Text = "Nº de Telemóvel";
            this.Telemovel.Width = 150;
            // 
            // FuncButton
            // 
            this.FuncButton.Location = new System.Drawing.Point(26, 88);
            this.FuncButton.Name = "FuncButton";
            this.FuncButton.Size = new System.Drawing.Size(105, 29);
            this.FuncButton.TabIndex = 20;
            this.FuncButton.Text = "Funcionários";
            this.FuncButton.UseVisualStyleBackColor = true;
            this.FuncButton.Click += new System.EventHandler(this.FuncButton_Click);
            // 
            // opAgriButton
            // 
            this.opAgriButton.Location = new System.Drawing.Point(150, 88);
            this.opAgriButton.Name = "opAgriButton";
            this.opAgriButton.Size = new System.Drawing.Size(118, 29);
            this.opAgriButton.TabIndex = 21;
            this.opAgriButton.Text = "Op Agricolas";
            this.opAgriButton.UseVisualStyleBackColor = true;
            this.opAgriButton.Click += new System.EventHandler(this.opAgriButton_Click);
            // 
            // opAdegaButton
            // 
            this.opAdegaButton.Location = new System.Drawing.Point(288, 88);
            this.opAdegaButton.Name = "opAdegaButton";
            this.opAdegaButton.Size = new System.Drawing.Size(94, 29);
            this.opAdegaButton.TabIndex = 22;
            this.opAdegaButton.Text = "Op. Adegas";
            this.opAdegaButton.UseVisualStyleBackColor = true;
            this.opAdegaButton.Click += new System.EventHandler(this.opAdegaButton_Click);
            // 
            // gerenteButton
            // 
            this.gerenteButton.Location = new System.Drawing.Point(403, 88);
            this.gerenteButton.Name = "gerenteButton";
            this.gerenteButton.Size = new System.Drawing.Size(94, 29);
            this.gerenteButton.TabIndex = 23;
            this.gerenteButton.Text = "Gerentes";
            this.gerenteButton.UseVisualStyleBackColor = true;
            this.gerenteButton.Click += new System.EventHandler(this.gerenteButton_Click);
            // 
            // clienteButton
            // 
            this.clienteButton.Location = new System.Drawing.Point(518, 88);
            this.clienteButton.Name = "clienteButton";
            this.clienteButton.Size = new System.Drawing.Size(94, 29);
            this.clienteButton.TabIndex = 24;
            this.clienteButton.Text = "Clientes";
            this.clienteButton.UseVisualStyleBackColor = true;
            this.clienteButton.Click += new System.EventHandler(this.clienteButton_Click);
            // 
            // pessoaButton
            // 
            this.pessoaButton.Location = new System.Drawing.Point(631, 88);
            this.pessoaButton.Name = "pessoaButton";
            this.pessoaButton.Size = new System.Drawing.Size(94, 29);
            this.pessoaButton.TabIndex = 25;
            this.pessoaButton.Text = "Pessoas";
            this.pessoaButton.UseVisualStyleBackColor = true;
            this.pessoaButton.Click += new System.EventHandler(this.pessoaButton_Click);
            // 
            // Pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 577);
            this.Controls.Add(this.pessoaButton);
            this.Controls.Add(this.clienteButton);
            this.Controls.Add(this.gerenteButton);
            this.Controls.Add(this.opAdegaButton);
            this.Controls.Add(this.opAgriButton);
            this.Controls.Add(this.FuncButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countPessoas);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listPessoas);
            this.Name = "Pessoa";
            this.Text = "WineDb - Pessoas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countPessoas;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label telemovelLabel;
        private System.Windows.Forms.Label GeneroLabel;
        private System.Windows.Forms.Label dataNascLabel;
        private System.Windows.Forms.Label NIFLabel;
        private System.Windows.Forms.Label moradaLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBoxTelemovel;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxDataNasc;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listPessoas;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Morada;
        private System.Windows.Forms.ColumnHeader NIF;
        private System.Windows.Forms.ColumnHeader Data_Nasc;
        private System.Windows.Forms.ColumnHeader Genero;
        private System.Windows.Forms.ColumnHeader Telemovel;
        private System.Windows.Forms.Button FuncButton;
        private System.Windows.Forms.Button opAgriButton;
        private System.Windows.Forms.Button opAdegaButton;
        private System.Windows.Forms.Button gerenteButton;
        private System.Windows.Forms.Button clienteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button atualizarbutton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.TextBox textBoxAdega;
        private System.Windows.Forms.TextBox textBoxTerreno;
        private System.Windows.Forms.TextBox textBoxNunFunc;
        private System.Windows.Forms.TextBox textBoxInicioAtiv;
        private System.Windows.Forms.TextBox textBoxSS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIBAN;
        private System.Windows.Forms.Button pessoaButton;
    }
}