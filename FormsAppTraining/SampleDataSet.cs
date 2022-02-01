using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppTraining
{
    public partial class SampleDataSet : Form
    {
        public SampleDataSet()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.AppSettings["ConnectionString"];
            string Query = "SELECT * FROM tblProduct";

            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConString);
            DataSet dset = new DataSet();

            adapter.Fill(dset, "tblProduct");
            dgvDataset.DataSource = dset.Tables["tblProduct"];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.AppSettings["ConnectionString"];
            string Query = "SELECT * FROM tblProduct";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConString);
            DataSet set = new DataSet();
            adapter.Fill(set, "tblProduct");

            set.Tables["tblProduct"].Rows[1].Delete();

            dgvDataset.DataSource = set.Tables["tblProduct"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.AppSettings["ConnectionString"];
            string Query = "SELECT * FROM tblProduct";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConString);
            DataSet set = new DataSet();
            adapter.Fill(set, "tblProduct");           

            dgvDataset.DataSource = set.Tables["tblProduct"];
            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.AppSettings["ConnectionString"];
            string Query = "SELECT * FROM tblProduct";

            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConString);
            DataSet set = new DataSet();

            adapter.Fill(set, "tblProduct");
            dgvDataset.DataSource = set.Tables["tblProduct"];
        }
    }
}
