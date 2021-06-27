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
    public partial class CubaForm : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataAdapter adaper;
        readonly DataTable dataTable = new DataTable();
        ListViewColumnSorter lvwColumnSorter;

        public CubaForm(SqlConnection cnn, Form f)
        {
            this.cnn = cnn;
            InitializeComponent();
            statsTiposCubas();
            cubaLoad();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listCuba.ListViewItemSorter = (System.Collections.IComparer)lvwColumnSorter;
        }

        public void statsTiposCubas()
        {
            statInox();
            statDuplo();
            statFundoPlano();
            statFundoConico();
            statCarvalho();
            statFrancesa();
            statAmericana();
            statBalao();
        }

        public void statInox()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.TipoCuba WHERE TipoCuba = 'Depósito Inox'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String count = reader["Count"].ToString();
            label10.Text = count;
            reader.Close();
        }

        public void statDuplo()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.TipoCuba WHERE TipoCuba = 'Depósito Duplo'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String count = reader["Count"].ToString();
            label12.Text = count;
            reader.Close();
        }

        public void statFundoPlano()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.TipoCuba WHERE TipoCuba = 'Depósito Fundo Plano'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String count = reader["Count"].ToString();
            label13.Text = count;
            reader.Close();
        }

        public void statFundoConico()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.TipoCuba WHERE TipoCuba = 'Depóstio Fundo Cónico'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String count = reader["Count"].ToString();
            label14.Text = count;
            reader.Close();
        }

        public void statCarvalho()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.TipoCuba WHERE TipoCuba = 'Barril de Carvalho'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String count = reader["Count"].ToString();
            label15.Text = count;
            reader.Close();
        }

        public void statFrancesa()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.TipoCuba WHERE TipoCuba = 'Barril de Madeira Francesa'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String count = reader["Count"].ToString();
            label16.Text = count;
            reader.Close();
        }

        public void statAmericana()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.TipoCuba WHERE TipoCuba = 'Barril Estilo Barrica Americana'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String count = reader["Count"].ToString();
            label17.Text = count;
            reader.Close();
        }

        public void statBalao()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.TipoCuba WHERE TipoCuba = 'Deposito em Balão'", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String count = reader["Count"].ToString();
            label18.Text = count;
            reader.Close();
        }

        private void populate(String ID, String adega, String cap_max, String tipoCuba)
        {
            listCuba.Items.Add(new ListViewItem(new[] { ID, adega, cap_max, tipoCuba }));
        }

        private void cubaLoad()
        {
            listCuba.Items.Clear();
            listCuba.View = View.Details;

            cmd = new SqlCommand("SELECT C.ID, A.Nome, C.Cap_Max, TC.TipoCuba FROM WineDB.Cuba AS C JOIN WineDB.TipoCuba AS TC ON C.ID = TC.ID JOIN WineDB.Adega AS A ON C.ID_Adega = A.ID", cnn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tableCuba");

            dt = ds.Tables["tableCuba"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listCuba.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listCuba.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listCuba.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listCuba.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
            countadorCubas();
        }

        public void pesquisar()
        {
            String atributo = comboBox1.Text;
            String pesquisaText = textBoxPesquisa.Text;
            String filter = "";

            switch (atributo)
            {
                case "ID":
                    filter = "ID";
                    break;
                case "Adega":
                    filter = "ID_Adega";
                    break;
                case "Cap. Máxima":
                    filter = "Cap_Max";
                    break;
  
            }


            listCuba.Items.Clear();
            cmd = new SqlCommand("SELECT C.ID, A.Nome, C.Cap_Max, TC.TipoCuba FROM WineDB.Cuba AS C JOIN WineDB.TipoCuba AS TC ON C.ID = TC.ID JOIN WineDB.Adega AS A ON C.ID_Adega = A.ID WHERE C." + filter + " LIKE '%" + pesquisaText + "%'", cnn);
            try
            {
                adaper = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adaper.Fill(ds, "tableCubaSearch");

                dt = ds.Tables["tableCubaSearch"];


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

        void listCuba_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (e.IsSelected)
                {
                    string id = listCuba.SelectedItems[0].SubItems[0].Text;
                    string id_adega = listCuba.SelectedItems[0].SubItems[1].Text;
                    string cap_max = listCuba.SelectedItems[0].SubItems[2].Text;
                    string tipo = listCuba.SelectedItems[0].SubItems[3].Text;

                    textBoxID.Text = id;
                    textBoxIDAdega.Text = id_adega;
                    textBoxCapMax.Text = cap_max;
                    textBoxTipo.Text = tipo;
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

        private void countadorCubas()
        {
            int count = listCuba.Items.Count;
            countCuba.Text = count.ToString();
        }

        private void listCuba_ColumnClick(object sender, ColumnClickEventArgs e)
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

            this.listCuba.Sort();
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
            string nome_adega = textBoxIDAdega.Text;
            int cap_max = Int32.Parse(textBoxCapMax.Text);
            string tipo = textBoxTipo.Text;

            try
            {
                SqlCommand command = new SqlCommand("WineDB.AdicionarCuba", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", id));
                command.Parameters.Add(new SqlParameter("@Nome_Adega", nome_adega));
                command.Parameters.Add(new SqlParameter("@Cap_Max", cap_max));
                command.Parameters.Add(new SqlParameter("@TipoCuba", tipo));

                rdr = command.ExecuteReader();

                MessageBox.Show("Cuba adicionada com sucesso");

            }
            catch
            {

                textBoxID.Text = "";
                textBoxIDAdega.Text = "";
                textBoxCapMax.Text = "";
                textBoxTipo.Text = "";

                MessageBox.Show("Algum dado passado de forma incorreta");
            }

            if (rdr != null)
            {
                rdr.Close();
            }

            cubaLoad();
            statsTiposCubas();
        }
        
        private void Apagarbutton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxID.Text);

            if (id == 0)
            {
                MessageBox.Show("Armazem não foi selecionado corretamente");
            }

            SqlCommand command2 = new SqlCommand("DELETE FROM WineDB.TipoCuba WHERE ID = " + id, cnn);
            SqlCommand command = new SqlCommand("DELETE FROM WineDB.Cuba WHERE ID = " + id, cnn);
            command2.ExecuteNonQuery();
            command.ExecuteNonQuery();

            //to refrsh
            statsTiposCubas();
            cubaLoad();
        }
    }
}

