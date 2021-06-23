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
    public partial class VendaForm : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataAdapter adaper;
        readonly DataTable dataTable = new DataTable();
        ListViewColumnSorter lvwColumnSorter;

        public VendaForm(SqlConnection cnn, Form f)
        {
            this.cnn = cnn;
            InitializeComponent();
            vendaLoad();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listVenda.ListViewItemSorter = (System.Collections.IComparer)lvwColumnSorter;
        }


        private void populate(String ID_Produto, String preco, String iva, String quantidade, String nif)
        {
            listVenda.Items.Add(new ListViewItem(new[] { ID_Produto, preco, iva, quantidade, nif}));
        }

        private void vendaLoad()
        {
            listVenda.Items.Clear();
            listVenda.View = View.Details;

            cmd = new SqlCommand("SELECT V.ID_Venda, VI.Nome, V.Preco, V.IVA, V.Quantidade, P.Nome FROM WineDB.Venda AS V JOIN WineDB.Vinho AS VI ON V.ID_Produto = VI.ID JOIN WineDB.Pessoa AS P ON V.NIF_Cliente = P.NIF", cnn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tableVenda");

            dt = ds.Tables["tableVenda"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listVenda.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listVenda.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listVenda.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listVenda.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listVenda.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listVenda.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
            }
            countadorVenda();
        }

        public void pesquisar()
        {
            String atributo = comboBox1.Text;
            String pesquisaText = textBoxPesquisa.Text;
            String filter = "";

            switch (atributo)
            {
                case "ID da Venda":
                    filter = "ID_Venda";
                    break;
                case "Preço":
                    filter = "Preco";
                    break;
                case "Quantidade":
                    filter = "Quantidade";
                    break;
                case "Cliente":
                    filter = "NIF_Cliente";
                    break;
            }


            listVenda.Items.Clear();
            cmd = new SqlCommand("SELECT V.ID_Venda, VI.Nome, V.Preco, V.IVA, V.Quantidade, P.Nome FROM WineDB.Venda AS V JOIN WineDB.Vinho AS VI ON V.ID_Produto = VI.ID JOIN WineDB.Pessoa AS P ON V.NIF_Cliente = P.NIF WHERE V." + filter + " LIKE '%" + pesquisaText + "%'", cnn);
            try
            {
                adaper = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adaper.Fill(ds, "tableArmazemSearch");

                dt = ds.Tables["tableArmazemSearch"];


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

        void listVenda_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (e.IsSelected)
                {
                    string id_venda = listVenda.SelectedItems[0].SubItems[0].Text;
                    string produto = listVenda.SelectedItems[0].SubItems[1].Text;
                    string preco = listVenda.SelectedItems[0].SubItems[2].Text;
                    string iva = listVenda.SelectedItems[0].SubItems[3].Text;
                    string quantidade = listVenda.SelectedItems[0].SubItems[4].Text;
                    string cliente = listVenda.SelectedItems[0].SubItems[5].Text;

                    textBoxID.Text = id_venda;
                    textBoxProduto.Text = produto;
                    textBoxPreco.Text = preco;
                    textBoxIVA.Text = iva;
                    textBoxQuantidade.Text = quantidade;
                    textBoxCliente.Text = cliente;

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

        private void countadorVenda()
        {
            int count = listVenda.Items.Count;
            countVenda.Text = count.ToString();
        }

        private void listVenda_ColumnClick(object sender, ColumnClickEventArgs e)
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

            this.listVenda.Sort();
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //https://csharp-station.com/Tutorial/AdoDotNet/Lesson07
            SqlDataReader rdr = null;

            int id = Int32.Parse(textBoxID.Text);
            string produto = textBoxProduto.Text;
            float preco = float.Parse(textBoxPreco.Text);
            int iva = Int32.Parse(textBoxIVA.Text);
            int quantidade = Int32.Parse(textBoxQuantidade.Text);
            int cliente = Int32.Parse(textBoxCliente.Text);
            try
            {
                SqlCommand command = new SqlCommand("WineDB.AdicionarVenda", cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID_Venda", id));
                command.Parameters.Add(new SqlParameter("@ID_Produto", produto));
                command.Parameters.Add(new SqlParameter("@Preco", preco));
                command.Parameters.Add(new SqlParameter("@IVA", iva));
                command.Parameters.Add(new SqlParameter("@Quantidade", quantidade));
                command.Parameters.Add(new SqlParameter("@NIF_Cliente", cliente));

                rdr = command.ExecuteReader();
            }
            catch
            {
                textBoxID.Text = "";
                textBoxProduto.Text = "";
                textBoxPreco.Text = "";
                textBoxIVA.Text = "";
                textBoxQuantidade.Text = "";
                textBoxCliente.Text = "";

                MessageBox.Show("Algum dado passado de forma incorreta");
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            vendaLoad();
        }

        private void Apagarbutton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxID.Text);

            if (id == 0)
            {
                MessageBox.Show("Armazem não foi selecionado corretamente");
            }

            SqlCommand command = new SqlCommand("DELETE FROM WineDB.Venda WHERE ID_Venda = " + id , cnn);
            command.ExecuteNonQuery();

            //to refrsh
            vendaLoad();
        }


    }
}
