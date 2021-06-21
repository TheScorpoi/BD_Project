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

        public TerrenoForm(SqlConnection cnn, Form f)
        {
            this.cnn = cnn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listTerreno.Columns.Add("ID");
            listTerreno.Columns.Add("Nome");
            listTerreno.Columns.Add("Localização");
            listTerreno.Columns.Add("Ano de Plantação");
            listTerreno.Columns.Add("ID da Casta");
            listTerreno.Columns.Add("Hectares");
            listTerreno.Columns.Add("ID da Adega");
            
            listTerreno.View = View.Details;

            cmd = new SqlCommand("SELECT * FROM WineDB.Terreno", cnn);

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
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage terreno = new MainPage();
            terreno.ShowDialog();
        }

    }
}
