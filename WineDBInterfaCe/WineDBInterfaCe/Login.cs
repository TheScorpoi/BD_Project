using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WineDBInterfaCe
{
    public partial class Login : Form
    {
        public static SqlConnection cnn; //global variable to be accessed from everywhere
        public bool gerente = false;

        public Login()
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
            //statAdega.Text = count;
            //MessageBox.Show(count);
            reader.Close();

            cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.Armazem", cnn);
            reader = cmd.ExecuteReader();
            reader.Read();
            count = reader["Count"].ToString();
            //statArmazem.Text = count;
            //MessageBox.Show(count);
            reader.Close();

            cmd = new SqlCommand("SELECT COUNT(*) AS Count FROM WineDB.Vinho", cnn);
            reader = cmd.ExecuteReader();
            reader.Read();
            count = reader["Count"].ToString();
            //statVinho.Text = count;
            //MessageBox.Show(count);
            reader.Close();
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            cnn = getConnection();
            verifyConnection();
            //DialogResult userfeedback;
            bool repeat = true;

            while (repeat)
            {
                if (cnn == null || cnn.State != ConnectionState.Open)
                {
                    //userfeedback = MessageBox.Show("Could not connect to DB. Do tou want to retry?", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    //repeat = (userfeedback == DialogResult.Retry);
                    verifyConnection();
                }
                else
                {
                    repeat = false;
                }
            }
            getStats();
        }

        private void login(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||textBox2.Text == "")
            {
                MessageBox.Show("Campos utilizador ou Senha estão vazios");
                return;
            }
        }
    }
}

