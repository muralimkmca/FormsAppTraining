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
    public partial class MultipleDocInterface : Form
    {
        public MultipleDocInterface()
        {
            InitializeComponent();
        }

        private void textOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxOperations textBoxOperationsObj = new TextBoxOperations();
            textBoxOperationsObj.Show();
            textBoxOperationsObj.MdiParent = this;


        }

        private void MultipleDocInterface_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void datasetOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SampleDataSet sds = new SampleDataSet();
            sds.Show();
            sds.MdiParent = this;
        }

        private void dialogBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogBoxes dbobj = new DialogBoxes();
            dbobj.Show();
            dbobj.MdiParent = this;
        }
    }
}
