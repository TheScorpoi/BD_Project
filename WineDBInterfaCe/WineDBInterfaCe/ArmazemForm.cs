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
        private SqlConnection cnn; 
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;

        public ArmazemForm(SqlConnection cnn, Form f)
        {
            InitializeComponent();
            this.cnn = cnn;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listArmazem.Columns.Add("ID");
            listArmazem.Columns.Add("Localização");
            listArmazem.Columns.Add("Nome");
            listArmazem.Columns.Add("ID da Adega Associada");

            listArmazem.View = View.Details;

            cmd = new SqlCommand("SELECT * FROM WineDB.Armazem", cnn);

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
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage terreno = new MainPage();
            terreno.ShowDialog();
        }
    }
}
