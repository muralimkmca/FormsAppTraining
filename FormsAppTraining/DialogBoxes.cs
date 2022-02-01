using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppTraining
{
    public partial class DialogBoxes : Form
    {
        public DialogBoxes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a Text File";
            ofd.Filter = "All Files(*.*) | *.*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            else if(dr == DialogResult.Cancel)
            {
                MessageBox.Show("Please select any text document");
            }
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Filter = "Text Files (*.txt) | *.txt"; 
            if (sfdlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(sfdlg.FileName);
                sr.Write(textBox1.Text);
                sr.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Font Dialog
            FontDialog fdlg = new FontDialog();
            fdlg.ShowDialog();
            textBox1.Font = fdlg.Font;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Color Dialog
            var cdlg = new ColorDialog();
            cdlg.ShowDialog();
            textBox1.ForeColor = cdlg.Color;
        }
    }
}
