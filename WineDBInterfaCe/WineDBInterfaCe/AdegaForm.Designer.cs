
namespace WineDBInterfaCe
{
    partial class AdegaForm
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
            this.listAdegas = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Endereço = new System.Windows.Forms.ColumnHeader();
            this.Cap_Max = new System.Windows.Forms.ColumnHeader();
            this.Num_Cubas = new System.Windows.Forms.ColumnHeader();
            this.NomeGerente = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.atualizarbutton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.NifGerenteLabel = new System.Windows.Forms.Label();
            this.numCubasLabel = new System.Windows.Forms.Label();
            this.capMaxLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBoxNIFGERENTE = new System.Windows.Forms.TextBox();
            this.textBoxENDERECO = new System.Windows.Forms.TextBox();
            this.textBoxNCUBAS = new System.Windows.Forms.TextBox();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxCAPMAX = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.apagarbutton = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.countAdegas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAdegas
            // 
            this.listAdegas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Endereço,
            this.Cap_Max,
            this.Num_Cubas,
            this.NomeGerente});
            this.listAdegas.HideSelection = false;
            this.listAdegas.Location = new System.Drawing.Point(56, 78);
            this.listAdegas.Name = "listAdegas";
            this.listAdegas.Size = new System.Drawing.Size(1010, 243);
            this.listAdegas.TabIndex = 0;
            this.listAdegas.UseCompatibleStateImageBehavior = false;
            this.listAdegas.View = System.Windows.Forms.View.Details;
            this.listAdegas.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listAdegas_ColumnClick);
            this.listAdegas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listAdegas_ItemSelectionChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 75;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 150;
            // 
            // Endereço
            // 
            this.Endereço.Text = "Endereco";
            this.Endereço.Width = 325;
            // 
            // Cap_Max
            // 
            this.Cap_Max.Text = "Capacidade Máxima";
            this.Cap_Max.Width = 150;
            // 
            // Num_Cubas
            // 
            this.Num_Cubas.Text = "Numero Cubas";
            this.Num_Cubas.Width = 150;
            // 
            // NomeGerente
            // 
            this.NomeGerente.Text = "Nome do Gerente";
            this.NomeGerente.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.atualizarbutton);
            this.panel1.Controls.Add(this.inserirButton);
            this.panel1.Controls.Add(this.NifGerenteLabel);
            this.panel1.Controls.Add(this.numCubasLabel);
            this.panel1.Controls.Add(this.capMaxLabel);
            this.panel1.Controls.Add(this.enderecoLabel);
            this.panel1.Controls.Add(this.nomeLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.textBoxNIFGERENTE);
            this.panel1.Controls.Add(this.textBoxENDERECO);
            this.panel1.Controls.Add(this.textBoxNCUBAS);
            this.panel1.Controls.Add(this.textBoxNOME);
            this.panel1.Controls.Add(this.textBoxCAPMAX);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.apagarbutton);
            this.panel1.Location = new System.Drawing.Point(56, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 178);
            this.panel1.TabIndex = 2;
            // 
            // atualizarbutton
            // 
            this.atualizarbutton.Location = new System.Drawing.Point(847, 80);
            this.atualizarbutton.Name = "atualizarbutton";
            this.atualizarbutton.Size = new System.Drawing.Size(94, 29);
            this.atualizarbutton.TabIndex = 14;
            this.atualizarbutton.Text = "Atualizar";
            this.atualizarbutton.UseVisualStyleBackColor = true;
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(847, 35);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(94, 29);
            this.inserirButton.TabIndex = 13;
            this.inserirButton.Text = "Inserir Adega";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // NifGerenteLabel
            // 
            this.NifGerenteLabel.AutoSize = true;
            this.NifGerenteLabel.Location = new System.Drawing.Point(436, 115);
            this.NifGerenteLabel.Name = "NifGerenteLabel";
            this.NifGerenteLabel.Size = new System.Drawing.Size(94, 20);
            this.NifGerenteLabel.TabIndex = 12;
            this.NifGerenteLabel.Text = "NIF Gerente: ";
            // 
            // numCubasLabel
            // 
            this.numCubasLabel.AutoSize = true;
            this.numCubasLabel.Location = new System.Drawing.Point(457, 76);
            this.numCubasLabel.Name = "numCubasLabel";
            this.numCubasLabel.Size = new System.Drawing.Size(73, 20);
            this.numCubasLabel.TabIndex = 11;
            this.numCubasLabel.Text = "Nº Cubas:";
            // 
            // capMaxLabel
            // 
            this.capMaxLabel.AutoSize = true;
            this.capMaxLabel.Location = new System.Drawing.Point(458, 22);
            this.capMaxLabel.Name = "capMaxLabel";
            this.capMaxLabel.Size = new System.Drawing.Size(72, 20);
            this.capMaxLabel.TabIndex = 10;
            this.capMaxLabel.Text = "Cap_Max:";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(71, 115);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(74, 20);
            this.enderecoLabel.TabIndex = 9;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(92, 73);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(53, 20);
            this.nomeLabel.TabIndex = 8;
            this.nomeLabel.Text = "Nome:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(118, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 20);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID:";
            // 
            // textBoxNIFGERENTE
            // 
            this.textBoxNIFGERENTE.Location = new System.Drawing.Point(536, 115);
            this.textBoxNIFGERENTE.Name = "textBoxNIFGERENTE";
            this.textBoxNIFGERENTE.Size = new System.Drawing.Size(209, 27);
            this.textBoxNIFGERENTE.TabIndex = 6;
            // 
            // textBoxENDERECO
            // 
            this.textBoxENDERECO.Location = new System.Drawing.Point(164, 115);
            this.textBoxENDERECO.Name = "textBoxENDERECO";
            this.textBoxENDERECO.Size = new System.Drawing.Size(233, 27);
            this.textBoxENDERECO.TabIndex = 5;
            // 
            // textBoxNCUBAS
            // 
            this.textBoxNCUBAS.Location = new System.Drawing.Point(536, 73);
            this.textBoxNCUBAS.Name = "textBoxNCUBAS";
            this.textBoxNCUBAS.Size = new System.Drawing.Size(209, 27);
            this.textBoxNCUBAS.TabIndex = 4;
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(164, 73);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(233, 27);
            this.textBoxNOME.TabIndex = 3;
            // 
            // textBoxCAPMAX
            // 
            this.textBoxCAPMAX.Location = new System.Drawing.Point(536, 22);
            this.textBoxCAPMAX.Name = "textBoxCAPMAX";
            this.textBoxCAPMAX.Size = new System.Drawing.Size(209, 27);
            this.textBoxCAPMAX.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(164, 22);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(233, 27);
            this.textBoxID.TabIndex = 1;
            // 
            // apagarbutton
            // 
            this.apagarbutton.Location = new System.Drawing.Point(847, 125);
            this.apagarbutton.Name = "apagarbutton";
            this.apagarbutton.Size = new System.Drawing.Size(94, 29);
            this.apagarbutton.TabIndex = 0;
            this.apagarbutton.Text = "Apagar Adega";
            this.apagarbutton.UseVisualStyleBackColor = true;
            this.apagarbutton.Click += new System.EventHandler(this.apagarButton_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(56, 29);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 29);
            this.buttonVoltar.TabIndex = 6;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Endereço",
            "Cap Máxima",
            "Nº Cubas",
            "NIF Gerente"});
            this.comboBox1.Location = new System.Drawing.Point(592, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(782, 29);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(165, 27);
            this.textBoxPesquisa.TabIndex = 8;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.button1Adega_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(989, 26);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(94, 29);
            this.Limpar.TabIndex = 9;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // countAdegas
            // 
            this.countAdegas.AutoSize = true;
            this.countAdegas.Location = new System.Drawing.Point(394, 33);
            this.countAdegas.Name = "countAdegas";
            this.countAdegas.Size = new System.Drawing.Size(31, 20);
            this.countAdegas.TabIndex = 10;
            this.countAdegas.Text = "OO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número de Adegas: ";
            // 
            // AdegaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countAdegas);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listAdegas);
            this.Name = "AdegaForm";
            this.Text = "WineDB - Adegas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listAdegas;
        private System.Windows.Forms.Button button1Adega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button apagarbutton;
        private System.Windows.Forms.Label NifGerenteLabel;
        private System.Windows.Forms.Label numCubasLabel;
        private System.Windows.Forms.Label capMaxLabel;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBoxNIFGERENTE;
        private System.Windows.Forms.TextBox textBoxENDERECO;
        private System.Windows.Forms.TextBox textBoxNCUBAS;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxCAPMAX;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Endereço;
        private System.Windows.Forms.ColumnHeader Cap_Max;
        private System.Windows.Forms.ColumnHeader Num_Cubas;
        private System.Windows.Forms.ColumnHeader NomeGerente;
        private System.Windows.Forms.Label countAdegas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button atualizarbutton;
        private System.Windows.Forms.Button inserirButton;
    }
}