
namespace WineDBInterfaCe
{
    partial class TerrenoForm
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
            this.listTerreno = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Localizacao = new System.Windows.Forms.ColumnHeader();
            this.Ano_plantacao = new System.Windows.Forms.ColumnHeader();
            this.ID_Casta = new System.Windows.Forms.ColumnHeader();
            this.Hectares = new System.Windows.Forms.ColumnHeader();
            this.ID_Adega = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.atualizarbutton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.textBoxIdADEGA = new System.Windows.Forms.TextBox();
            this.textBoxHECTARES = new System.Windows.Forms.TextBox();
            this.textBoxIdCASTA = new System.Windows.Forms.TextBox();
            this.IDAdegaLabel = new System.Windows.Forms.Label();
            this.Hectareslabel = new System.Windows.Forms.Label();
            this.IDCastaLabel = new System.Windows.Forms.Label();
            this.AnoPlatancaoLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBoxAnoPlantacao = new System.Windows.Forms.TextBox();
            this.textBoxENDERECO = new System.Windows.Forms.TextBox();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.apagarbutton = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.countTerrenos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTerreno
            // 
            this.listTerreno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Localizacao,
            this.Ano_plantacao,
            this.ID_Casta,
            this.Hectares,
            this.ID_Adega});
            this.listTerreno.HideSelection = false;
            this.listTerreno.Location = new System.Drawing.Point(54, 71);
            this.listTerreno.Name = "listTerreno";
            this.listTerreno.Size = new System.Drawing.Size(1010, 236);
            this.listTerreno.TabIndex = 0;
            this.listTerreno.UseCompatibleStateImageBehavior = false;
            this.listTerreno.View = System.Windows.Forms.View.Details;
            this.listTerreno.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listTerreno_ColumnClick);
            this.listTerreno.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listTerreno_ItemSelectionChanged);
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
            // Localizacao
            // 
            this.Localizacao.Text = "Localização";
            this.Localizacao.Width = 200;
            // 
            // Ano_plantacao
            // 
            this.Ano_plantacao.Text = "Ano de Plantação";
            this.Ano_plantacao.Width = 150;
            // 
            // ID_Casta
            // 
            this.ID_Casta.Text = "Casta";
            this.ID_Casta.Width = 150;
            // 
            // Hectares
            // 
            this.Hectares.Text = "Hectares";
            this.Hectares.Width = 100;
            // 
            // ID_Adega
            // 
            this.ID_Adega.Text = "Adega";
            this.ID_Adega.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(970, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.atualizarbutton);
            this.panel1.Controls.Add(this.inserirButton);
            this.panel1.Controls.Add(this.textBoxIdADEGA);
            this.panel1.Controls.Add(this.textBoxHECTARES);
            this.panel1.Controls.Add(this.textBoxIdCASTA);
            this.panel1.Controls.Add(this.IDAdegaLabel);
            this.panel1.Controls.Add(this.Hectareslabel);
            this.panel1.Controls.Add(this.IDCastaLabel);
            this.panel1.Controls.Add(this.AnoPlatancaoLabel);
            this.panel1.Controls.Add(this.enderecoLabel);
            this.panel1.Controls.Add(this.nomeLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.textBoxAnoPlantacao);
            this.panel1.Controls.Add(this.textBoxENDERECO);
            this.panel1.Controls.Add(this.textBoxNOME);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.apagarbutton);
            this.panel1.Location = new System.Drawing.Point(54, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 178);
            this.panel1.TabIndex = 4;
            // 
            // atualizarbutton
            // 
            this.atualizarbutton.Location = new System.Drawing.Point(847, 84);
            this.atualizarbutton.Name = "atualizarbutton";
            this.atualizarbutton.Size = new System.Drawing.Size(94, 29);
            this.atualizarbutton.TabIndex = 20;
            this.atualizarbutton.Text = "Atualizar";
            this.atualizarbutton.UseVisualStyleBackColor = true;
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(847, 39);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(94, 29);
            this.inserirButton.TabIndex = 19;
            this.inserirButton.Text = "Inserir Terreno";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // textBoxIdADEGA
            // 
            this.textBoxIdADEGA.Location = new System.Drawing.Point(571, 148);
            this.textBoxIdADEGA.Name = "textBoxIdADEGA";
            this.textBoxIdADEGA.Size = new System.Drawing.Size(233, 27);
            this.textBoxIdADEGA.TabIndex = 18;
            // 
            // textBoxHECTARES
            // 
            this.textBoxHECTARES.Location = new System.Drawing.Point(571, 106);
            this.textBoxHECTARES.Name = "textBoxHECTARES";
            this.textBoxHECTARES.Size = new System.Drawing.Size(233, 27);
            this.textBoxHECTARES.TabIndex = 17;
            // 
            // textBoxIdCASTA
            // 
            this.textBoxIdCASTA.Location = new System.Drawing.Point(571, 65);
            this.textBoxIdCASTA.Name = "textBoxIdCASTA";
            this.textBoxIdCASTA.Size = new System.Drawing.Size(233, 27);
            this.textBoxIdCASTA.TabIndex = 16;
            // 
            // IDAdegaLabel
            // 
            this.IDAdegaLabel.AutoSize = true;
            this.IDAdegaLabel.Location = new System.Drawing.Point(465, 148);
            this.IDAdegaLabel.Name = "IDAdegaLabel";
            this.IDAdegaLabel.Size = new System.Drawing.Size(100, 20);
            this.IDAdegaLabel.TabIndex = 15;
            this.IDAdegaLabel.Text = "ID da Adega: ";
            // 
            // Hectareslabel
            // 
            this.Hectareslabel.AutoSize = true;
            this.Hectareslabel.Location = new System.Drawing.Point(495, 106);
            this.Hectareslabel.Name = "Hectareslabel";
            this.Hectareslabel.Size = new System.Drawing.Size(70, 20);
            this.Hectareslabel.TabIndex = 14;
            this.Hectareslabel.Text = "Hectares:";
            // 
            // IDCastaLabel
            // 
            this.IDCastaLabel.AutoSize = true;
            this.IDCastaLabel.Location = new System.Drawing.Point(480, 65);
            this.IDCastaLabel.Name = "IDCastaLabel";
            this.IDCastaLabel.Size = new System.Drawing.Size(88, 20);
            this.IDCastaLabel.TabIndex = 13;
            this.IDCastaLabel.Text = "ID da Casta:";
            // 
            // AnoPlatancaoLabel
            // 
            this.AnoPlatancaoLabel.AutoSize = true;
            this.AnoPlatancaoLabel.Location = new System.Drawing.Point(432, 29);
            this.AnoPlatancaoLabel.Name = "AnoPlatancaoLabel";
            this.AnoPlatancaoLabel.Size = new System.Drawing.Size(133, 20);
            this.AnoPlatancaoLabel.TabIndex = 12;
            this.AnoPlatancaoLabel.Text = "Ano de Platanção: ";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(71, 129);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(74, 20);
            this.enderecoLabel.TabIndex = 9;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(92, 65);
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
            // textBoxAnoPlantacao
            // 
            this.textBoxAnoPlantacao.Location = new System.Drawing.Point(571, 25);
            this.textBoxAnoPlantacao.Name = "textBoxAnoPlantacao";
            this.textBoxAnoPlantacao.Size = new System.Drawing.Size(233, 27);
            this.textBoxAnoPlantacao.TabIndex = 6;
            // 
            // textBoxENDERECO
            // 
            this.textBoxENDERECO.Location = new System.Drawing.Point(164, 126);
            this.textBoxENDERECO.Name = "textBoxENDERECO";
            this.textBoxENDERECO.Size = new System.Drawing.Size(233, 27);
            this.textBoxENDERECO.TabIndex = 5;
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(164, 65);
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
            // apagarbutton
            // 
            this.apagarbutton.Location = new System.Drawing.Point(847, 125);
            this.apagarbutton.Name = "apagarbutton";
            this.apagarbutton.Size = new System.Drawing.Size(94, 29);
            this.apagarbutton.TabIndex = 0;
            this.apagarbutton.Text = "Apagar Adega";
            this.apagarbutton.UseVisualStyleBackColor = true;
            this.apagarbutton.Click += new System.EventHandler(this.apagarbutton_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(43, 22);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 29);
            this.buttonVoltar.TabIndex = 5;
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
            "Localização",
            "Ano de Plantação",
            "ID de Casta",
            "Hectares",
            "ID da Adega"});
            this.comboBox1.Location = new System.Drawing.Point(571, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(776, 24);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(158, 27);
            this.textBoxPesquisa.TabIndex = 7;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // countTerrenos
            // 
            this.countTerrenos.AutoSize = true;
            this.countTerrenos.Location = new System.Drawing.Point(380, 26);
            this.countTerrenos.Name = "countTerrenos";
            this.countTerrenos.Size = new System.Drawing.Size(31, 20);
            this.countTerrenos.TabIndex = 8;
            this.countTerrenos.Text = "OO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantidade de Terrenos:";
            // 
            // TerrenoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countTerrenos);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listTerreno);
            this.Name = "TerrenoForm";
            this.Text = "WineDB - Terrenos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listTerreno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AnoPlatancaoLabel;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBoxAnoPlantacao;
        private System.Windows.Forms.TextBox textBoxENDERECO;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button apagarbutton;
        private System.Windows.Forms.TextBox textBoxIdADEGA;
        private System.Windows.Forms.TextBox textBoxHECTARES;
        private System.Windows.Forms.TextBox textBoxIdCASTA;
        private System.Windows.Forms.Label IDAdegaLabel;
        private System.Windows.Forms.Label Hectareslabel;
        private System.Windows.Forms.Label IDCastaLabel;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label countTerrenos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Localizacao;
        private System.Windows.Forms.ColumnHeader Ano_plantacao;
        private System.Windows.Forms.ColumnHeader ID_Casta;
        private System.Windows.Forms.ColumnHeader Hectares;
        private System.Windows.Forms.ColumnHeader ID_Adega;
        private System.Windows.Forms.Button atualizarbutton;
        private System.Windows.Forms.Button inserirButton;
    }
}