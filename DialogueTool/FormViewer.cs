using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace DialogueTool
{
    public partial class FormViewer : Form
    {
        public FormViewer(string FileDirectory)
        {
            InitializeComponent();
            grid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dialogue = JsonConvert.DeserializeObject<DialogueTree>(File.ReadAllText(FileDirectory));
        }
    }
}
