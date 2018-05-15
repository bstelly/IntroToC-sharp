using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueTool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            fileDir = "";
            textBox1.TabStop = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                displayFileDir.Text = openFileDialog.FileName;
                fileDir = openFileDialog.FileName;
            }
        }

        private void displayFileDir_TextChanged(object sender, EventArgs e)
        {
            fileDir = displayFileDir.Text;
        }

        private void buttonViewer_Click(object sender, EventArgs e)
        {
            if (fileDir != "")
            {
                viewerForm = new FormViewer(this, fileDir);
                viewerForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("You must enter a directory for a .json file to view it.",
                    "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
