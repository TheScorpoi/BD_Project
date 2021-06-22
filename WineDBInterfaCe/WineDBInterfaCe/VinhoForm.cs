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
    public partial class VinhoForm : Form
    {
        private SqlConnection cnn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        readonly DataTable dataTable = new DataTable();
        ListViewColumnSorter lvwColumnSorter;


        public VinhoForm(SqlConnection cnn, Form f)
        {
            this.cnn = cnn;
            InitializeComponent();
            vinhoLoad();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listVinho.ListViewItemSorter = (System.Collections.IComparer)lvwColumnSorter;
        }

        private void populate(String ID, String id_cuba, String nome, String doc, String id_casta)
        {
            listVinho.Items.Add(new ListViewItem(new[] { ID, id_cuba, nome, doc, id_casta}));
        }

        private void vinhoLoad()
        {
            listVinho.Items.Clear();
            listVinho.View = View.Details;

            cmd = new SqlCommand("SELECT V.ID, V.ID_Cuba, V.Nome, V.DOC, C.Nome FROM WineDB.Vinho AS V JOIN WineDB.Casta AS C ON V.ID_Casta = C.ID", cnn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tableVinho");

            dt = ds.Tables["tableVinho"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listVinho.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listVinho.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listVinho.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listVinho.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listVinho.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
            contadorVinhos();
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage terreno = new MainPage();
            terreno.ShowDialog();
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
                case "ID da Cuba":
                    filter = "ID_Cuba";
                    break;
                case "DOC":
                    filter = "DOC";
                    break;
                case "ID da Casta":
                    filter = "ID_Casta";
                    break;

            }


            listVinho.Items.Clear();
            cmd = new SqlCommand("SELECT V.ID, V.ID_Cuba, V.Nome, V.DOC, C.Nome FROM WineDB.Vinho AS V JOIN WineDB.Casta AS C ON V.ID_Casta = C.ID WHERE V." + filter + " LIKE '%" + pesquisaText + "%'", cnn);
            try
            {
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "tableAdegaSearch");

                dt = ds.Tables["tableAdegaSearch"];


                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPesquisa.Text = "";
            comboBox1.Text = "";
        }

        private void contadorVinhos()
        {
            int count = listVinho.Items.Count;
            countVinhos.Text = count.ToString();
        }

        void listVinho_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (e.IsSelected)
                {
                    string id = listVinho.SelectedItems[0].SubItems[0].Text;
                    string id_cuba = listVinho.SelectedItems[0].SubItems[1].Text;
                    string nome = listVinho.SelectedItems[0].SubItems[2].Text;
                    string doc = listVinho.SelectedItems[0].SubItems[3].Text;
                    string id_casta = listVinho.SelectedItems[0].SubItems[4].Text;

                    textBoxID.Text = id;
                    textBoxIDCuba.Text = id_cuba;
                    textBoxNome.Text = nome;
                    textBoxDOC.Text = doc;
                    textBoxIDCasta.Text = id_casta;

                    //MessageBox.Show("VINHO " + nome + "\n\nID: " + id + "\nID da Cuba: " + id_cuba + "\nDOC: " + doc + " \nCASTA: " + id_casta);
                }

            }
            catch (ArgumentOutOfRangeException t)
            {
                MessageBox.Show(t.Message);
            }
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

            this.listVinho.Sort();
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            //https://csharp-station.com/Tutorial/AdoDotNet/Lesson07
            SqlDataReader rdr = null;

            string id = textBoxID.Text;
            int id_cuba = Int32.Parse(textBoxIDCuba.Text);
            string nome = textBoxNome.Text;
            string doc = textBoxDOC.Text;
            int id_casta = Int32.Parse(textBoxIDCasta.Text);

            try
            {
                SqlCommand command = new SqlCommand("WineDB.AdicionarVinho", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", id));
                command.Parameters.Add(new SqlParameter("@ID_Cuba", id_cuba));
                command.Parameters.Add(new SqlParameter("@Nome", nome));
                command.Parameters.Add(new SqlParameter("@DOC", doc));
                command.Parameters.Add(new SqlParameter("@ID_Casta", id_casta));

                rdr = command.ExecuteReader();
            }
            catch
            {

                textBoxID.Text = "";
                textBoxIDCuba.Text = "";
                textBoxNome.Text = "";
                textBoxDOC.Text = "";
                textBoxIDCasta.Text = "";
                MessageBox.Show("Algum dado passado de forma incorreta");
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            vinhoLoad();
        }

        private void Apagarbutton_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;

            if (id == "")
            {
                MessageBox.Show("Armazem não foi selecionado corretamente");
            }

            SqlCommand command = new SqlCommand("DELETE FROM WineDB.Vinho WHERE ID = '" + id + "'", cnn);
            command.ExecuteNonQuery();

            //to refrsh
            vinhoLoad();
        }
    }
}
