using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppTraining
{
    public partial class TextBoxOperations : Form
    {
        public TextBoxOperations()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var Age = Convert.ToInt32(txtAge.Text);

            if (Age > 18)
            {
                MessageBox.Show("you are eligible to vote", "Warning", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("Not eligible to vote", "Warning");
            }
        }
    }
}
