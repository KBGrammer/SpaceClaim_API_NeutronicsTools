using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCFE_Toolbox.UI
{
    public partial class MaterialRenamingForm : Form
    {
        public MaterialRenamingForm()
        {
            InitializeComponent();
            textBox1.Text = Environment.CurrentDirectory + @"\Material And Append Lists.csv";
        }
        public string FileName
        {
            get { return textBox1.Text; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                //MessageBox.Show(file);
                textBox1.Text = file;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void MaterialRenamingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
