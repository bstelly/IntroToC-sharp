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
    }
}
