﻿
namespace WineDBInterfaCe
{
    partial class ArmazemForm
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
            this.listArmazem = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Localizacao = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Adega = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDAdegaLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBoxAdega = new System.Windows.Forms.TextBox();
            this.textBoxENDERECO = new System.Windows.Forms.TextBox();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.countArmazem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listArmazem
            // 
            this.listArmazem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Localizacao,
            this.Nome,
            this.Adega});
            this.listArmazem.HideSelection = false;
            this.listArmazem.Location = new System.Drawing.Point(32, 83);
            this.listArmazem.Name = "listArmazem";
            this.listArmazem.Size = new System.Drawing.Size(1010, 206);
            this.listArmazem.TabIndex = 0;
            this.listArmazem.UseCompatibleStateImageBehavior = false;
            this.listArmazem.View = System.Windows.Forms.View.Details;
            this.listArmazem.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listArmazem_ColumnClick);
            this.listArmazem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listArmazem_ItemSelectionChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 75;
            // 
            // Localizacao
            // 
            this.Localizacao.Text = "Localização";
            this.Localizacao.Width = 350;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 250;
            // 
            // Adega
            // 
            this.Adega.Text = "Adega a que está associado";
            this.Adega.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IDAdegaLabel);
            this.panel1.Controls.Add(this.enderecoLabel);
            this.panel1.Controls.Add(this.nomeLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.textBoxAdega);
            this.panel1.Controls.Add(this.textBoxENDERECO);
            this.panel1.Controls.Add(this.textBoxNOME);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(32, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 178);
            this.panel1.TabIndex = 3;
            // 
            // IDAdegaLabel
            // 
            this.IDAdegaLabel.AutoSize = true;
            this.IDAdegaLabel.Location = new System.Drawing.Point(432, 29);
            this.IDAdegaLabel.Name = "IDAdegaLabel";
            this.IDAdegaLabel.Size = new System.Drawing.Size(100, 20);
            this.IDAdegaLabel.TabIndex = 12;
            this.IDAdegaLabel.Text = "ID da Adega: ";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(84, 76);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(74, 20);
            this.enderecoLabel.TabIndex = 9;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(473, 76);
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
            // textBoxAdega
            // 
            this.textBoxAdega.Location = new System.Drawing.Point(545, 26);
            this.textBoxAdega.Name = "textBoxAdega";
            this.textBoxAdega.Size = new System.Drawing.Size(233, 27);
            this.textBoxAdega.TabIndex = 6;
            // 
            // textBoxENDERECO
            // 
            this.textBoxENDERECO.Location = new System.Drawing.Point(164, 76);
            this.textBoxENDERECO.Name = "textBoxENDERECO";
            this.textBoxENDERECO.Size = new System.Drawing.Size(233, 27);
            this.textBoxENDERECO.TabIndex = 5;
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(545, 76);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(233, 27);
            this.textBoxNOME.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(164, 22);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(233, 27);
            this.textBoxID.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Inserir Adega";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(32, 30);
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
            "Localização",
            "Nome",
            "Adega"});
            this.comboBox1.Location = new System.Drawing.Point(542, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(763, 34);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(163, 27);
            this.textBoxPesquisa.TabIndex = 8;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // countArmazem
            // 
            this.countArmazem.AutoSize = true;
            this.countArmazem.Location = new System.Drawing.Point(368, 34);
            this.countArmazem.Name = "countArmazem";
            this.countArmazem.Size = new System.Drawing.Size(31, 20);
            this.countArmazem.TabIndex = 9;
            this.countArmazem.Text = "OO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nº de Armazens:";
            // 
            // ArmazemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countArmazem);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listArmazem);
            this.Name = "ArmazemForm";
            this.Text = "WineDB - Armazem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listArmazem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IDAdegaLabel;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBoxAdega;
        private System.Windows.Forms.TextBox textBoxENDERECO;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Localizacao;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Adega;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label countArmazem;
        private System.Windows.Forms.Label label2;
    }
}