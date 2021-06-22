using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WineDBInterfaCe
{
    public partial class TerrenoForm : Form
    {

        private SqlConnection cnn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        readonly DataTable dataTable = new DataTable();
        ListViewColumnSorter lvwColumnSorter;

        public TerrenoForm(SqlConnection cnn, Form f)
        {
            this.cnn = cnn;
            InitializeComponent();
            terrenoLoad();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listTerreno.ListViewItemSorter = (System.Collections.IComparer)lvwColumnSorter;
        }

        private void terrenoLoad()
        {   
            listTerreno.View = View.Details;

            cmd = new SqlCommand("SELECT T.ID, T.Nome, T.Localizacao, T.Ano_plantacao, C.Nome, T.Hectares, T.ID_Adega FROM WineDB.Terreno AS T JOIN WineDB.Casta AS C ON T.ID_CASTA = C.ID", cnn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tableTerreno");

            dt = ds.Tables["tableTerreno"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listTerreno.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listTerreno.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listTerreno.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listTerreno.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listTerreno.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listTerreno.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listTerreno.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
            }
            contadorTerrenos();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage terreno = new MainPage();
            terreno.ShowDialog();
        }

        private void contadorTerrenos()
        {
            int count = listTerreno.Items.Count;
            countTerrenos.Text = count.ToString();
        }

        private void listTerreno_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            this.listTerreno.Sort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPesquisa.Text = "";
            comboBox1.Text = "";
        }

        void listTerreno_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (e.IsSelected)
                {
                    string id = listTerreno.SelectedItems[0].SubItems[0].Text;
                    string nome = listTerreno.SelectedItems[0].SubItems[1].Text;
                    string endereco = listTerreno.SelectedItems[0].SubItems[2].Text;
                    string ano_plantacao = listTerreno.SelectedItems[0].SubItems[3].Text;
                    string id_Casta = listTerreno.SelectedItems[0].SubItems[4].Text;
                    string hectares = listTerreno.SelectedItems[0].SubItems[5].Text;
                    string id_Adega = listTerreno.SelectedItems[0].SubItems[6].Text;

                    textBoxID.Text = id;
                    textBoxNOME.Text = nome;
                    textBoxENDERECO.Text = endereco;
                    textBoxAnoPlantacao.Text = ano_plantacao;
                    textBoxIdCASTA.Text = id_Casta;
                    textBoxHECTARES.Text = hectares;
                    textBoxIdADEGA.Text = id_Adega;

                    //MessageBox.Show("Terreno " + nome + "\n\nID: " + id + "\nEndereço: " + endereco + "\nAno de Plantação: " + ano_plantacao + " \nID da Casta: " + id_Casta + "\nHectares: " + hectares+ "\nID da Adega: " + id_Adega);
                }

            }
            catch (ArgumentOutOfRangeException t)
            {
                MessageBox.Show(t.Message);
            }
        }

        private void populate(String ID, String nome, String endereco, String ano, String casta, String hectares, String adega)
        {
            listTerreno.Items.Add(new ListViewItem(new[] { ID, nome, endereco, ano, casta, hectares, adega }));
        }


        public void pesquisar()
        {
            String atributo = comboBox1.Text;
            String pesquisaText = textBoxPesquisa.Text;
            String filter = "";

            switch (atributo)
            {
                case "Nome":
                    filter = "Nome";
                    break;
                case "ID":
                    filter = "ID";
                    break;
                case "Localização":
                    filter = "Localizacao";
                    break;
                case "Ano de Plantação":
                    filter = "Ano_plantacao";
                    break;
                case "ID de Casta":
                    filter = "ID_Casta";
                    break;
                case "Hectares":
                    filter = "Hectares";
                    break;
                case "ID da Adega":
                    filter = "ID_Adega";
                    break;
            }

            listTerreno.Items.Clear();
            cmd = new SqlCommand("SELECT T.ID, T.Nome, T.Localizacao, T.Ano_plantacao, C.Nome, T.Hectares, T.ID_Adega FROM WineDB.Terreno AS T JOIN WineDB.Casta AS C ON T.ID_Casta = C.ID WHERE T." + filter + " LIKE '%" + pesquisaText + "%'", cnn);
            try
            {
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "tableTerrenoSearch");

                dt = ds.Tables["tableTerrenoSearch"];


                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
                }
                dt.Rows.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisar();
        }
    }
}
