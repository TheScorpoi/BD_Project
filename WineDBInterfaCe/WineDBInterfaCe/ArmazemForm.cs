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
    public partial class ArmazemForm : Form
    {
        SqlConnection cnn; 
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataAdapter adaper;
        readonly DataTable dataTable = new DataTable();
        ListViewColumnSorter lvwColumnSorter;

        public ArmazemForm(SqlConnection cnn, Form f)
        {
            this.cnn = cnn;
            InitializeComponent();
            armazemLoad();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listArmazem.ListViewItemSorter = (System.Collections.IComparer)lvwColumnSorter;
        }


        private void populate(String ID, String localizacao, String nome, String ID_Adega)
        {
            listArmazem.Items.Add(new ListViewItem(new[] { ID, localizacao, nome, ID_Adega }));
        }

        private void armazemLoad()
        {
            listArmazem.Items.Clear();
            listArmazem.View = View.Details;

            cmd = new SqlCommand("SELECT A.ID, A.Localizacao, A.Nome, AD.Nome FROM WineDB.Armazem AS A JOIN WineDB.Adega AS AD ON A.ID_Adega = AD.ID", cnn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tableArmazem");

            dt = ds.Tables["tableArmazem"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listArmazem.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listArmazem.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listArmazem.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listArmazem.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
            countadorArmazem();
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
                case "Adega a que está associado":
                    filter = "ID_Adega";
                    break;
            }


            listArmazem.Items.Clear();
            cmd = new SqlCommand("SELECT A.ID, A.Localizacao, A.Nome, AD.Nome FROM WineDB.Armazem AS A JOIN WineDB.Adega AS AD ON A.ID_Adega = AD.ID WHERE A." + filter + " LIKE '%" + pesquisaText + "%'", cnn);
            try
            {
                adaper = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adaper.Fill(ds, "tableArmazemSearch");

                dt = ds.Tables["tableArmazemSearch"];


                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }
                dt.Rows.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }

        void listArmazem_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (e.IsSelected)
                {
                    string id = listArmazem.SelectedItems[0].SubItems[0].Text;
                    string endereco = listArmazem.SelectedItems[0].SubItems[1].Text;
                    string nome = listArmazem.SelectedItems[0].SubItems[2].Text;
                    string adegaAssociado = listArmazem.SelectedItems[0].SubItems[3].Text;

                    textBoxID.Text = id;
                    textBoxENDERECO.Text = endereco;
                    textBoxNOME.Text = nome;
                    textBoxAdega.Text = adegaAssociado;

                    //MessageBox.Show("ARMAZÉM " + nome + "\n\nID: " + id + "\nEndereço: " + endereco + "\nAdega associdado: " + adegaAssociado);
                }

            }
            catch (ArgumentOutOfRangeException t)
            {
                MessageBox.Show(t.Message);
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage terreno = new MainPage();
            terreno.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPesquisa.Text = "";
            comboBox1.Text = "";
        }

        private void countadorArmazem()
        {
            int count = listArmazem.Items.Count;
            countArmazem.Text = count.ToString();
        }

        private void listArmazem_ColumnClick(object sender, ColumnClickEventArgs e)
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

            this.listArmazem.Sort();
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //https://csharp-station.com/Tutorial/AdoDotNet/Lesson07
            SqlDataReader rdr = null;

            string id = textBoxID.Text;
            string endereco = textBoxENDERECO.Text;
            string nome = textBoxNOME.Text;
            string adegaAssociado = textBoxAdega.Text;
            try
            {
                SqlCommand command = new SqlCommand("WineDB.AdicionarArmazem", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", id));
                command.Parameters.Add(new SqlParameter("@Localizacao", endereco));
                command.Parameters.Add(new SqlParameter("@Nome", nome));
                command.Parameters.Add(new SqlParameter("@ID_Adega", adegaAssociado));

                rdr = command.ExecuteReader();
            } catch
            {

                textBoxID.Text = "";
                textBoxAdega.Text = "";
                textBoxENDERECO.Text = "";
                textBoxNOME.Text = "";
                MessageBox.Show("Algum dado passado de forma incorreta");
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            armazemLoad();
        }

        private void Apagarbutton_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;

            if (id == "")
            {
                MessageBox.Show("Armazem não foi selecionado corretamente");
            }

            SqlCommand command = new SqlCommand("DELETE FROM WineDB.Armazem WHERE ID = '" + id + "'", cnn);
            command.ExecuteNonQuery();

            //to refrsh
            armazemLoad();
        }
    }
}
