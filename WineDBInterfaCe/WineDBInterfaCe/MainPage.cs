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
    public partial class MainPage : Form
    {
        public static SqlConnection cnn; //global variable to be accessed from everywhere


        public MainPage()
        {
            InitializeComponent();
        }

        private SqlConnection getConnection()
        {
            return new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p5g8; uid = p5g8; password = AAaa1234");
        }

        private bool verifyConnection()
        {
            if (cnn == null)
            {
                cnn = getConnection();
            }

            if (cnn != null)
            {
                try
                {
                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                    }
                }
                catch (SqlException e)
                {
                    MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + e.Message, "Connection Test", MessageBoxButtons.OK);
                    return false;
                }
                return cnn.State == ConnectionState.Open;
            }
            return false;
        }

        private void getStats()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.Adega", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String count = reader["Count"].ToString();
            statAdegasLabel.Text = count;
            reader.Close();

            cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.Armazem", cnn);
            reader = cmd.ExecuteReader();
            reader.Read();
            count = reader["Count"].ToString();
            statArmazemLabel.Text = count;
            //MessageBox.Show(count);
            reader.Close();

            cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.Terreno", cnn);
            reader = cmd.ExecuteReader();
            reader.Read();
            count = reader["Count"].ToString();
            statTerrenosLabel.Text = count;
            //MessageBox.Show(count);
            reader.Close();

            cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.Vinho", cnn);
            reader = cmd.ExecuteReader();
            reader.Read();
            count = reader["Count"].ToString();
            statVinhosLabel.Text = count;
            //MessageBox.Show(count);
            reader.Close();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            cnn = getConnection();
            verifyConnection();
            //DialogResult userfeedback;
            bool repeat = true;

            while (repeat)
            {
                if (cnn == null || cnn.State != ConnectionState.Open)
                {
                    verifyConnection();
                }
                else
                {
                    repeat = false;
                }
            }
            getStats();
        }


        private void AdegaForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdegaForm adega = new AdegaForm(cnn, this);
            adega.ShowDialog();
        }

        private void ArmazemForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArmazemForm armazem = new ArmazemForm(cnn, this);
            armazem.ShowDialog();
        }

        private void TerrenoForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            TerrenoForm terreno= new TerrenoForm(cnn, this);
            terreno.ShowDialog();
        }

        private void VinhoForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            VinhoForm vinho = new VinhoForm(cnn, this);
            vinho.ShowDialog();
        }

    }
}
