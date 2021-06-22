
namespace WineDBInterfaCe
{
    partial class CubaForm
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
            this.countCuba = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.atualizarbutton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.capMaxLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBoxCapMax = new System.Windows.Forms.TextBox();
            this.textBoxIDAdega = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.apagarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listCuba = new System.Windows.Forms.ListView();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.ID_Adega = new System.Windows.Forms.ColumnHeader();
            this.Cap_Max = new System.Windows.Forms.ColumnHeader();
            this.TipoCuba = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quantidade de Cubas:";
            // 
            // countCuba
            // 
            this.countCuba.AutoSize = true;
            this.countCuba.Location = new System.Drawing.Point(364, 27);
            this.countCuba.Name = "countCuba";
            this.countCuba.Size = new System.Drawing.Size(31, 20);
            this.countCuba.TabIndex = 16;
            this.countCuba.Text = "OO";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(760, 25);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(158, 27);
            this.textBoxPesquisa.TabIndex = 15;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Adega",
            "Cap. Máxima"});
            this.comboBox1.Location = new System.Drawing.Point(555, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 28);
            this.comboBox1.TabIndex = 14;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(27, 23);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 29);
            this.buttonVoltar.TabIndex = 13;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tipoLabel);
            this.panel1.Controls.Add(this.textBoxTipo);
            this.panel1.Controls.Add(this.atualizarbutton);
            this.panel1.Controls.Add(this.inserirButton);
            this.panel1.Controls.Add(this.capMaxLabel);
            this.panel1.Controls.Add(this.nomeLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.textBoxCapMax);
            this.panel1.Controls.Add(this.textBoxIDAdega);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.apagarbutton);
            this.panel1.Location = new System.Drawing.Point(38, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 151);
            this.panel1.TabIndex = 12;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(432, 88);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(101, 20);
            this.tipoLabel.TabIndex = 39;
            this.tipoLabel.Text = "Tipo de Cuba:";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(539, 88);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(233, 27);
            this.textBoxTipo.TabIndex = 38;
            // 
            // atualizarbutton
            // 
            this.atualizarbutton.Location = new System.Drawing.Point(872, 65);
            this.atualizarbutton.Name = "atualizarbutton";
            this.atualizarbutton.Size = new System.Drawing.Size(94, 29);
            this.atualizarbutton.TabIndex = 20;
            this.atualizarbutton.Text = "Atualizar";
            this.atualizarbutton.UseVisualStyleBackColor = true;
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(872, 20);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(94, 29);
            this.inserirButton.TabIndex = 19;
            this.inserirButton.Text = "Inserir Terreno";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // capMaxLabel
            // 
            this.capMaxLabel.AutoSize = true;
            this.capMaxLabel.Location = new System.Drawing.Point(431, 48);
            this.capMaxLabel.Name = "capMaxLabel";
            this.capMaxLabel.Size = new System.Drawing.Size(102, 20);
            this.capMaxLabel.TabIndex = 12;
            this.capMaxLabel.Text = "Cap. Máxima: ";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(58, 95);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(75, 20);
            this.nomeLabel.TabIndex = 8;
            this.nomeLabel.Text = "ID Adega:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(106, 48);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 20);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID:";
            // 
            // textBoxCapMax
            // 
            this.textBoxCapMax.Location = new System.Drawing.Point(539, 48);
            this.textBoxCapMax.Name = "textBoxCapMax";
            this.textBoxCapMax.Size = new System.Drawing.Size(233, 27);
            this.textBoxCapMax.TabIndex = 6;
            // 
            // textBoxIDAdega
            // 
            this.textBoxIDAdega.Location = new System.Drawing.Point(152, 88);
            this.textBoxIDAdega.Name = "textBoxIDAdega";
            this.textBoxIDAdega.Size = new System.Drawing.Size(233, 27);
            this.textBoxIDAdega.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(152, 45);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(233, 27);
            this.textBoxID.TabIndex = 1;
            // 
            // apagarbutton
            // 
            this.apagarbutton.Location = new System.Drawing.Point(872, 106);
            this.apagarbutton.Name = "apagarbutton";
            this.apagarbutton.Size = new System.Drawing.Size(94, 29);
            this.apagarbutton.TabIndex = 0;
            this.apagarbutton.Text = "Apagar Adega";
            this.apagarbutton.UseVisualStyleBackColor = true;
            this.apagarbutton.Click += new System.EventHandler(this.Apagarbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(954, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listCuba
            // 
            this.listCuba.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.ID_Adega,
            this.Cap_Max,
            this.TipoCuba});
            this.listCuba.HideSelection = false;
            this.listCuba.Location = new System.Drawing.Point(38, 77);
            this.listCuba.Name = "listCuba";
            this.listCuba.Size = new System.Drawing.Size(483, 286);
            this.listCuba.TabIndex = 18;
            this.listCuba.UseCompatibleStateImageBehavior = false;
            this.listCuba.View = System.Windows.Forms.View.Details;
            this.listCuba.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listCuba_ColumnClick);
            this.listCuba.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listCuba_ItemSelectionChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 75;
            // 
            // ID_Adega
            // 
            this.ID_Adega.Text = "Adega";
            this.ID_Adega.Width = 140;
            // 
            // Cap_Max
            // 
            this.Cap_Max.Text = "Cap. Máxima";
            this.Cap_Max.Width = 100;
            // 
            // TipoCuba
            // 
            this.TipoCuba.Text = "Tipo Cuba";
            this.TipoCuba.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(186, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Duplo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(353, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fundo Plano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fundo Cónico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(144, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Barril de Carvalho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(295, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Barril Madeira Francesa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(59, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Barrica Americana";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(305, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "Balão";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(116, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Quantidades de Tipos de Cubas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(43, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 28);
            this.label10.TabIndex = 29;
            this.label10.Text = "OO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(194, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 28);
            this.label12.TabIndex = 30;
            this.label12.Text = "OO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(376, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 28);
            this.label13.TabIndex = 31;
            this.label13.Text = "OO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(43, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 28);
            this.label14.TabIndex = 32;
            this.label14.Text = "OO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(194, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 28);
            this.label15.TabIndex = 33;
            this.label15.Text = "OO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(376, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 28);
            this.label16.TabIndex = 34;
            this.label16.Text = "OO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(116, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 28);
            this.label17.TabIndex = 35;
            this.label17.Text = "OO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(319, 256);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 28);
            this.label18.TabIndex = 36;
            this.label18.Text = "OO";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(544, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 286);
            this.panel2.TabIndex = 37;
            // 
            // CubaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listCuba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countCuba);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "CubaForm";
            this.Text = "WineDB - Cuba";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countCuba;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button atualizarbutton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Label capMaxLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox textBoxCapMax;
        private System.Windows.Forms.TextBox textBoxIDAdega;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button apagarbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listCuba;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID_Adega;
        private System.Windows.Forms.ColumnHeader Cap_Max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader TipoCuba;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.ColumnHeader Nome;
    }
}