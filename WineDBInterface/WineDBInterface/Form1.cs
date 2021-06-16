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
    public partial class Form1 : Form
    {
        private SqlConnection cnn;

        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn = getConnection();
            verifyConnection();
            DialogResult userfeedback;
            bool repeat = true;
            while (repeat)
            {
                if (cnn == null || cnn.State != ConnectionState.Open)
                {
                    userfeedback = MessageBox.Show("Could not connect to DB. Do tou want to retry?", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    repeat = (userfeedback == DialogResult.Retry);
                    if (userfeedback == DialogResult.Cancel)
                        this.Close();
                    verifyConnection();
                }
                else
                {
                    repeat = false;
                }

            }
            //getStats();
        }
    }
}

