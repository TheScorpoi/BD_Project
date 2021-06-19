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
        SqlConnection conn = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p5g8; uid = p5g8; password = AAaa1234");

        public AdegaForm()
        {
            InitializeComponent();
        }

        private void button1Adega_Click(object sender, EventArgs e)
        {

            //https://www.youtube.com/watch?v=JXwZQo4KW40&t=296s

            listAdegas.Columns.Add("ID");
            listAdegas.Columns.Add("Nome");
            listAdegas.Columns.Add("Endereço");
            listAdegas.Columns.Add("Capacidade Máxima");
            listAdegas.Columns.Add("Número de Cubas");
            listAdegas.Columns.Add("NIF do Ger");

            listAdegas.View = View.Details;

            cmd = new SqlCommand("SELECT * FROM WineDB.Adega", conn);

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
        }
    }
}
