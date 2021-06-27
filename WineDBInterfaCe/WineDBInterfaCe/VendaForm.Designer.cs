
namespace WineDBInterfaCe
{
    partial class VendaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.countVenda = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.atualizarbutton = new System.Windows.Forms.Button();
            this.Apagarbutton = new System.Windows.Forms.Button();
            this.precoLabel = new System.Windows.Forms.Label();
            this.produtoLabel = new System.Windows.Forms.Label();
            this.IVALabel = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.textBoxIVA = new System.Windows.Forms.TextBox();
            this.inserirButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listVenda = new System.Windows.Forms.ListView();
            this.ID_Venda = new System.Windows.Forms.ColumnHeader();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Preco = new System.Windows.Forms.ColumnHeader();
            this.IVA = new System.Windows.Forms.ColumnHeader();
            this.Quantidade = new System.Windows.Forms.ColumnHeader();
            this.Cliente = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nº de Vendas:";
            // 
            // countVenda
            // 
            this.countVenda.AutoSize = true;
            this.countVenda.Location = new System.Drawing.Point(379, 53);
            this.countVenda.Name = "countVenda";
            this.countVenda.Size = new System.Drawing.Size(31, 20);
            this.countVenda.TabIndex = 17;
            this.countVenda.Text = "OO";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(774, 53);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(163, 27);
            this.textBoxPesquisa.TabIndex = 16;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID da Venda",
            "Localização",
            "Nome",
            "Adega"});
            this.comboBox1.Location = new System.Drawing.Point(553, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(43, 49);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 29);
            this.buttonVoltar.TabIndex = 14;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxCliente);
            this.panel1.Controls.Add(this.textBoxQuantidade);
            this.panel1.Controls.Add(this.clienteLabel);
            this.panel1.Controls.Add(this.quantidadeLabel);
            this.panel1.Controls.Add(this.atualizarbutton);
            this.panel1.Controls.Add(this.Apagarbutton);
            this.panel1.Controls.Add(this.precoLabel);
            this.panel1.Controls.Add(this.produtoLabel);
            this.panel1.Controls.Add(this.IVALabel);
            this.panel1.Controls.Add(this.textBoxPreco);
            this.panel1.Controls.Add(this.textBoxProduto);
            this.panel1.Controls.Add(this.textBoxIVA);
            this.panel1.Controls.Add(this.inserirButton);
            this.panel1.Location = new System.Drawing.Point(43, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 178);
            this.panel1.TabIndex = 13;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(545, 123);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(233, 27);
            this.textBoxCliente.TabIndex = 17;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(164, 121);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(233, 27);
            this.textBoxQuantidade.TabIndex = 16;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(445, 124);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(62, 20);
            this.clienteLabel.TabIndex = 15;
            this.clienteLabel.Text = "Cliente: ";
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(66, 121);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(90, 20);
            this.quantidadeLabel.TabIndex = 14;
            this.quantidadeLabel.Text = "Quantidade:";
            // 
            // atualizarbutton
            // 
            this.atualizarbutton.Location = new System.Drawing.Point(868, 74);
            this.atualizarbutton.Name = "atualizarbutton";
            this.atualizarbutton.Size = new System.Drawing.Size(94, 29);
            this.atualizarbutton.TabIndex = 11;
            this.atualizarbutton.Text = "Atualizar";
            this.atualizarbutton.UseVisualStyleBackColor = true;
            // 
            // Apagarbutton
            // 
            this.Apagarbutton.Location = new System.Drawing.Point(868, 121);
            this.Apagarbutton.Name = "Apagarbutton";
            this.Apagarbutton.Size = new System.Drawing.Size(94, 29);
            this.Apagarbutton.TabIndex = 13;
            this.Apagarbutton.Text = "Apagar";
            this.Apagarbutton.UseVisualStyleBackColor = true;
            this.Apagarbutton.Click += new System.EventHandler(this.Apagarbutton_Click);
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(473, 29);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(53, 20);
            this.precoLabel.TabIndex = 12;
            this.precoLabel.Text = "Preço: ";
            // 
            // produtoLabel
            // 
            this.produtoLabel.AutoSize = true;
            this.produtoLabel.Location = new System.Drawing.Point(84, 76);
            this.produtoLabel.Name = "produtoLabel";
            this.produtoLabel.Size = new System.Drawing.Size(65, 20);
            this.produtoLabel.TabIndex = 9;
            this.produtoLabel.Text = "Produto:";
            // 
            // IVALabel
            // 
            this.IVALabel.AutoSize = true;
            this.IVALabel.Location = new System.Drawing.Point(473, 76);
            this.IVALabel.Name = "IVALabel";
            this.IVALabel.Size = new System.Drawing.Size(34, 20);
            this.IVALabel.TabIndex = 8;
            this.IVALabel.Text = "IVA:";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(545, 26);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(233, 27);
            this.textBoxPreco.TabIndex = 6;
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(164, 76);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(233, 27);
            this.textBoxProduto.TabIndex = 5;
            // 
            // textBoxIVA
            // 
            this.textBoxIVA.Location = new System.Drawing.Point(545, 76);
            this.textBoxIVA.Name = "textBoxIVA";
            this.textBoxIVA.Size = new System.Drawing.Size(233, 27);
            this.textBoxIVA.TabIndex = 3;
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(868, 29);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(94, 29);
            this.inserirButton.TabIndex = 0;
            this.inserirButton.Text = "Inserir Adega";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(959, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listVenda
            // 
            this.listVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Venda,
            this.ID,
            this.Nome,
            this.Preco,
            this.IVA,
            this.Quantidade,
            this.Cliente});
            this.listVenda.HideSelection = false;
            this.listVenda.Location = new System.Drawing.Point(43, 102);
            this.listVenda.Name = "listVenda";
            this.listVenda.Size = new System.Drawing.Size(1010, 206);
            this.listVenda.TabIndex = 11;
            this.listVenda.UseCompatibleStateImageBehavior = false;
            this.listVenda.View = System.Windows.Forms.View.Details;
            this.listVenda.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listVenda_ColumnClick);
            this.listVenda.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listVenda_ItemSelectionChanged);
            // 
            // ID_Venda
            // 
            this.ID_Venda.Text = "ID Venda";
            this.ID_Venda.Width = 100;
            // 
            // ID
            // 
            this.ID.Text = "ID Produto";
            this.ID.Width = 150;
            // 
            // Nome
            // 
            this.Nome.Text = "Produto";
            this.Nome.Width = 100;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.Width = 75;
            // 
            // IVA
            // 
            this.IVA.Text = "IVA";
            this.IVA.Width = 125;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 200;
            // 
            // Cliente
            // 
            this.Cliente.Text = "Cliente";
            this.Cliente.Width = 150;
            // 
            // VendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countVenda);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listVenda);
            this.Name = "VendaForm";
            this.Text = "WineDB - Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countVenda;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button atualizarbutton;
        private System.Windows.Forms.Button Apagarbutton;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.Label produtoLabel;
        private System.Windows.Forms.Label IVALabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.TextBox textBoxIVA;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listVenda;
        private System.Windows.Forms.ColumnHeader ID_Venda;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ColumnHeader IVA;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.ColumnHeader Cliente;
    }
}