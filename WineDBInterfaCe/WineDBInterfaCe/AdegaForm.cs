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
    public partial class AdegaForm : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection cnn;
        SqlDataAdapter adapter;
        readonly DataTable dataTable = new DataTable();
        ListViewColumnSorter lvwColumnSorter;



        public AdegaForm(SqlConnection cnn, Form f)
        {
            this.cnn = cnn;
            InitializeComponent();
            loadInicial();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listAdegas.ListViewItemSorter = (System.Collections.IComparer)lvwColumnSorter;
        }

        private void button1Adega_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void populate(String ID, String nome, String endereco, String cap_Max, String num_Cubas, String nif_Gerente)
        {
            listAdegas.Items.Add(new ListViewItem(new[] { ID, nome, endereco, cap_Max, num_Cubas, nif_Gerente }));
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
                case "Endereço":
                    filter = "Endereco";
                    break;
                case "NIF Gerente":
                    filter = "NIF_Gerente";
                    break;
                case "Cap Máxima":
                    filter = "Cap_Max";
                    break;
                case "Nº Cubas":
                    filter = "Num_Cubas";
                    break;

            }


            listAdegas.Items.Clear();
            cmd = new SqlCommand("SELECT A.ID, A.Nome, A.Endereco, A.Cap_Max, A.Num_Cubas, P.Nome FROM WineDB.Adega AS A JOIN WineDB.Pessoa AS P ON A.NIF_Gerente = P.NIF WHERE A." + filter + " LIKE '%" + pesquisaText + "%'", cnn);
            try
            {
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "tableAdegaSearch");

                dt = ds.Tables["tableAdegaSearch"];


                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                }
                dt.Rows.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }

        void listAdegas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (e.IsSelected)
                {
                    string id = listAdegas.SelectedItems[0].SubItems[0].Text;
                    string nome = listAdegas.SelectedItems[0].SubItems[1].Text;
                    string endereco = listAdegas.SelectedItems[0].SubItems[2].Text;
                    string cap_max = listAdegas.SelectedItems[0].SubItems[3].Text;
                    string nCubas = listAdegas.SelectedItems[0].SubItems[4].Text;
                    string nifGerente = listAdegas.SelectedItems[0].SubItems[5].Text;

                    textBoxID.Text = id;
                    textBoxNOME.Text = nome;
                    textBoxENDERECO.Text = endereco;
                    textBoxCAPMAX.Text = cap_max;
                    textBoxNCUBAS.Text = nCubas;
                    textBoxNIFGERENTE.Text = nifGerente;


                    //MessageBox.Show("ADEGA " + nome + "\n\nID: " + id + "\nEndereço: " + endereco + "\nCapacidade Máxima: " + cap_max + " (litros)\nNº Cubas: " + nCubas + "\nNome Gerente: " + nifGerente + "\n");
                }

            }
            catch (ArgumentOutOfRangeException t)
            {
                MessageBox.Show(t.Message);
            }
        }

        public void loadInicial()
        {
            //https://www.youtube.com/watch?v=JXwZQo4KW40&t=296s


            listAdegas.View = View.Details;

            cmd = new SqlCommand("SELECT A.ID, A.Nome, A.Endereco, A.Cap_Max, A.Num_Cubas, P.Nome FROM WineDB.Adega AS A JOIN WineDB.Pessoa AS P ON A.NIF_Gerente = P.NIF", cnn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tableAdega");

            dt = ds.Tables["tableAdega"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listAdegas.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listAdegas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listAdegas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listAdegas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listAdegas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listAdegas.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
            }
            contadorAdegas();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPesquisa.Text = "";
            comboBox1.Text = "";
        }

        private void contadorAdegas()
        {
            int count = listAdegas.Items.Count;
            countAdegas.Text = count.ToString();
        }

        private void listAdegas_ColumnClick(object sender, ColumnClickEventArgs e)
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

            this.listAdegas.Sort();
        }


    }
}
