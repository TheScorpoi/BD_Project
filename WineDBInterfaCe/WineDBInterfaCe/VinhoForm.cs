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


        public VinhoForm(SqlConnection cnn, Form f)
        {
            this.cnn = cnn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listVinho.Columns.Add("ID");
            listVinho.Columns.Add("ID da Cuba");
            listVinho.Columns.Add("Nome");
            listVinho.Columns.Add("DOC");
            listVinho.Columns.Add("ID da Casta");

            listVinho.View = View.Details;

            cmd = new SqlCommand("SELECT * FROM WineDB.Vinho", cnn);

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
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage terreno = new MainPage();
            terreno.ShowDialog();
        }
        private void DOCLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
