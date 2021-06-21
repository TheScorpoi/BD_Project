
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
            this.button1Adega = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAdegas
            // 
            this.listAdegas.HideSelection = false;
            this.listAdegas.Location = new System.Drawing.Point(56, 76);
            this.listAdegas.Name = "listAdegas";
            this.listAdegas.Size = new System.Drawing.Size(1010, 243);
            this.listAdegas.TabIndex = 0;
            this.listAdegas.UseCompatibleStateImageBehavior = false;
            // 
            // button1Adega
            // 
            this.button1Adega.Location = new System.Drawing.Point(949, 27);
            this.button1Adega.Name = "button1Adega";
            this.button1Adega.Size = new System.Drawing.Size(94, 29);
            this.button1Adega.TabIndex = 1;
            this.button1Adega.Text = "Get Data";
            this.button1Adega.UseVisualStyleBackColor = true;
            this.button1Adega.Click += new System.EventHandler(this.button1Adega_Click);
            // 
            // panel1
            // 
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(56, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 178);
            this.panel1.TabIndex = 2;
            // 
            // NifGerenteLabel
            // 
            this.NifGerenteLabel.AutoSize = true;
            this.NifGerenteLabel.Location = new System.Drawing.Point(436, 115);
            this.NifGerenteLabel.Name = "NifGerenteLabel";
            this.NifGerenteLabel.Size = new System.Drawing.Size(94, 20);
            this.NifGerenteLabel.TabIndex = 12;
            this.NifGerenteLabel.Text = "NIF Gerente: ";
            this.NifGerenteLabel.Click += new System.EventHandler(this.NifGerenteLabel_Click);
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
            this.textBoxNCUBAS.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir Adega";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(56, 27);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 29);
            this.buttonVoltar.TabIndex = 6;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // AdegaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 571);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1Adega);
            this.Controls.Add(this.listAdegas);
            this.Name = "AdegaForm";
            this.Text = "WineDB - Adegas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listAdegas;
        private System.Windows.Forms.Button button1Adega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
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
    }
}