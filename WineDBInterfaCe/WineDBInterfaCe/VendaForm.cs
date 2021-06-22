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

        public VendaForm()
        {

            InitializeComponent();
        }
    }
}
