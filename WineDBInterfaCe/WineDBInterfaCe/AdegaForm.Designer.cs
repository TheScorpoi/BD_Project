
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
            this.AdegaID = new System.Windows.Forms.ColumnHeader();
            this.AdegaNome = new System.Windows.Forms.ColumnHeader();
            this.AdegaEndereco = new System.Windows.Forms.ColumnHeader();
            this.AdegaCapMax = new System.Windows.Forms.ColumnHeader();
            this.AdegaNum_Cubas = new System.Windows.Forms.ColumnHeader();
            this.AdegaNIF_Gerente = new System.Windows.Forms.ColumnHeader();
            this.button1Adega = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAdegas
            // 
            this.listAdegas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AdegaID,
            this.AdegaNome,
            this.AdegaEndereco,
            this.AdegaCapMax,
            this.AdegaNum_Cubas,
            this.AdegaNIF_Gerente});
            this.listAdegas.HideSelection = false;
            this.listAdegas.Location = new System.Drawing.Point(123, 53);
            this.listAdegas.Name = "listAdegas";
            this.listAdegas.Size = new System.Drawing.Size(898, 423);
            this.listAdegas.TabIndex = 0;
            this.listAdegas.UseCompatibleStateImageBehavior = false;
            // 
            // AdegaID
            // 
            this.AdegaID.Text = "ID";
            // 
            // AdegaNome
            // 
            this.AdegaNome.Text = "Nome";
            // 
            // AdegaEndereco
            // 
            this.AdegaEndereco.Text = "Endereço";
            // 
            // AdegaCapMax
            // 
            this.AdegaCapMax.Text = "Cap_Max";
            // 
            // AdegaNum_Cubas
            // 
            this.AdegaNum_Cubas.Text = "Num_Cubas";
            // 
            // AdegaNIF_Gerente
            // 
            this.AdegaNIF_Gerente.Text = "NIF Gerente";
            // 
            // button1Adega
            // 
            this.button1Adega.Location = new System.Drawing.Point(534, 507);
            this.button1Adega.Name = "button1Adega";
            this.button1Adega.Size = new System.Drawing.Size(94, 29);
            this.button1Adega.TabIndex = 1;
            this.button1Adega.Text = "Get Data";
            this.button1Adega.UseVisualStyleBackColor = true;
            this.button1Adega.Click += new System.EventHandler(this.button1Adega_Click);
            // 
            // AdegaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 571);
            this.Controls.Add(this.button1Adega);
            this.Controls.Add(this.listAdegas);
            this.Name = "AdegaForm";
            this.Text = "AdegaFormcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listAdegas;
        private System.Windows.Forms.ColumnHeader AdegaID;
        private System.Windows.Forms.ColumnHeader AdegaNome;
        private System.Windows.Forms.ColumnHeader AdegaEndereco;
        private System.Windows.Forms.ColumnHeader AdegaCapMax;
        private System.Windows.Forms.ColumnHeader AdegaNum_Cubas;
        private System.Windows.Forms.ColumnHeader AdegaNIF_Gerente;
        private System.Windows.Forms.Button button1Adega;
    }
}