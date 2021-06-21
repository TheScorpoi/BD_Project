
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idCastaLabel = new System.Windows.Forms.Label();
            this.DOCLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.IDCubaLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBoxENDERECO = new System.Windows.Forms.TextBox();
            this.textBoxNCUBAS = new System.Windows.Forms.TextBox();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxCAPMAX = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVinho
            // 
            this.listVinho.HideSelection = false;
            this.listVinho.Location = new System.Drawing.Point(42, 67);
            this.listVinho.Name = "listVinho";
            this.listVinho.Size = new System.Drawing.Size(989, 234);
            this.listVinho.TabIndex = 0;
            this.listVinho.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
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
            this.panel1.Controls.Add(this.idCastaLabel);
            this.panel1.Controls.Add(this.DOCLabel);
            this.panel1.Controls.Add(this.nomeLabel);
            this.panel1.Controls.Add(this.IDCubaLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.textBoxENDERECO);
            this.panel1.Controls.Add(this.textBoxNCUBAS);
            this.panel1.Controls.Add(this.textBoxNOME);
            this.panel1.Controls.Add(this.textBoxCAPMAX);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.button2);
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
            this.DOCLabel.Click += new System.EventHandler(this.DOCLabel_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Inserir Adega";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // VinhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listVinho);
            this.Name = "VinhoForm";
            this.Text = "WineDB - Vinho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBoxENDERECO;
        private System.Windows.Forms.TextBox textBoxNCUBAS;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxCAPMAX;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button button2;
    }
}