
namespace WineDBInterfaCe
{
    partial class VinhoForm
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
            this.listVinho = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.ID_Cuba = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.DOC = new System.Windows.Forms.ColumnHeader();
            this.ID_Adega = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idCastaLabel = new System.Windows.Forms.Label();
            this.DOCLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.IDCubaLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxIDCasta = new System.Windows.Forms.TextBox();
            this.textBoxIDCuba = new System.Windows.Forms.TextBox();
            this.textBoxDOC = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.apagarbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.countVinhos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.atualizarbutton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVinho
            // 
            this.listVinho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ID_Cuba,
            this.Nome,
            this.DOC,
            this.ID_Adega});
            this.listVinho.HideSelection = false;
            this.listVinho.Location = new System.Drawing.Point(42, 67);
            this.listVinho.Name = "listVinho";
            this.listVinho.Size = new System.Drawing.Size(989, 234);
            this.listVinho.TabIndex = 0;
            this.listVinho.UseCompatibleStateImageBehavior = false;
            this.listVinho.View = System.Windows.Forms.View.Details;
            this.listVinho.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listAdegas_ColumnClick);
            this.listVinho.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listVinho_ItemSelectionChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 75;
            // 
            // ID_Cuba
            // 
            this.ID_Cuba.Text = "ID da Cuba";
            this.ID_Cuba.Width = 150;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 150;
            // 
            // DOC
            // 
            this.DOC.Text = "DOC";
            this.DOC.Width = 200;
            // 
            // ID_Adega
            // 
            this.ID_Adega.Text = "Adega";
            this.ID_Adega.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(42, 22);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 29);
            this.buttonVoltar.TabIndex = 6;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.atualizarbutton);
            this.panel1.Controls.Add(this.inserirButton);
            this.panel1.Controls.Add(this.idCastaLabel);
            this.panel1.Controls.Add(this.DOCLabel);
            this.panel1.Controls.Add(this.nomeLabel);
            this.panel1.Controls.Add(this.IDCubaLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.textBoxIDCasta);
            this.panel1.Controls.Add(this.textBoxIDCuba);
            this.panel1.Controls.Add(this.textBoxDOC);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.apagarbutton);
            this.panel1.Location = new System.Drawing.Point(42, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 178);
            this.panel1.TabIndex = 7;
            // 
            // idCastaLabel
            // 
            this.idCastaLabel.AutoSize = true;
            this.idCastaLabel.Location = new System.Drawing.Point(436, 73);
            this.idCastaLabel.Name = "idCastaLabel";
            this.idCastaLabel.Size = new System.Drawing.Size(88, 20);
            this.idCastaLabel.TabIndex = 11;
            this.idCastaLabel.Text = "ID da Casta:";
            // 
            // DOCLabel
            // 
            this.DOCLabel.AutoSize = true;
            this.DOCLabel.Location = new System.Drawing.Point(481, 22);
            this.DOCLabel.Name = "DOCLabel";
            this.DOCLabel.Size = new System.Drawing.Size(43, 20);
            this.DOCLabel.TabIndex = 10;
            this.DOCLabel.Text = "DOC:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(92, 115);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(53, 20);
            this.nomeLabel.TabIndex = 9;
            this.nomeLabel.Text = "Nome:";
            // 
            // IDCubaLabel
            // 
            this.IDCubaLabel.AutoSize = true;
            this.IDCubaLabel.Location = new System.Drawing.Point(59, 73);
            this.IDCubaLabel.Name = "IDCubaLabel";
            this.IDCubaLabel.Size = new System.Drawing.Size(86, 20);
            this.IDCubaLabel.TabIndex = 8;
            this.IDCubaLabel.Text = "ID da Cuba:";
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
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(164, 115);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(233, 27);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxIDCasta
            // 
            this.textBoxIDCasta.Location = new System.Drawing.Point(536, 73);
            this.textBoxIDCasta.Name = "textBoxIDCasta";
            this.textBoxIDCasta.Size = new System.Drawing.Size(209, 27);
            this.textBoxIDCasta.TabIndex = 4;
            // 
            // textBoxIDCuba
            // 
            this.textBoxIDCuba.Location = new System.Drawing.Point(164, 73);
            this.textBoxIDCuba.Name = "textBoxIDCuba";
            this.textBoxIDCuba.Size = new System.Drawing.Size(233, 27);
            this.textBoxIDCuba.TabIndex = 3;
            // 
            // textBoxDOC
            // 
            this.textBoxDOC.Location = new System.Drawing.Point(536, 22);
            this.textBoxDOC.Name = "textBoxDOC";
            this.textBoxDOC.Size = new System.Drawing.Size(209, 27);
            this.textBoxDOC.TabIndex = 2;
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
            this.apagarbutton.Click += new System.EventHandler(this.Apagarbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "ID da Cuba",
            "Nome",
            "DOC",
            "Adega "});
            this.comboBox1.Location = new System.Drawing.Point(556, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(744, 24);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(166, 27);
            this.textBoxPesquisa.TabIndex = 9;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // countVinhos
            // 
            this.countVinhos.AutoSize = true;
            this.countVinhos.Location = new System.Drawing.Point(372, 26);
            this.countVinhos.Name = "countVinhos";
            this.countVinhos.Size = new System.Drawing.Size(31, 20);
            this.countVinhos.TabIndex = 10;
            this.countVinhos.Text = "OO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantidade de Vinhos:";
            // 
            // atualizarbutton
            // 
            this.atualizarbutton.Location = new System.Drawing.Point(847, 83);
            this.atualizarbutton.Name = "atualizarbutton";
            this.atualizarbutton.Size = new System.Drawing.Size(94, 29);
            this.atualizarbutton.TabIndex = 13;
            this.atualizarbutton.Text = "Atualizar";
            this.atualizarbutton.UseVisualStyleBackColor = true;
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(847, 38);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(94, 29);
            this.inserirButton.TabIndex = 12;
            this.inserirButton.Text = "Inserir Vinho";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserir_Click);
            // 
            // VinhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countVinhos);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listVinho);
            this.Name = "VinhoForm";
            this.Text = "WineDB - Vinho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listVinho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label idCastaLabel;
        private System.Windows.Forms.Label DOCLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label IDCubaLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxIDCasta;
        private System.Windows.Forms.TextBox textBoxIDCuba;
        private System.Windows.Forms.TextBox textBoxDOC;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button apagarbutton;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID_Cuba;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader DOC;
        private System.Windows.Forms.ColumnHeader ID_Adega;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label countVinhos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button atualizarbutton;
        private System.Windows.Forms.Button inserirButton;
    }
}