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

            DataRow row = dset.Tables["tblProduct"].NewRow();
            row["Id"] = 3;
            row["ProductName"] = "Powder";
            row["ProductPrice"] = "100";
            row["Datetime"] = "2022-02-01";

            dset.Tables["tblProduct"].Rows.Add(row);

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
