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

namespace DialogueTool
{
    public partial class FormEditor : Form
    {
        public FormEditor(FormMain parent, string directory)
        {
            InitializeComponent();
            dialogue = new DialogueTree();
            parentForm = parent;
            fileDir = directory;
            if (File.Exists(fileDir))
            {
                int count = 1;
                dialogue.Load(fileDir);
                for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
                {
                    Tree.Nodes[0].Nodes.Add(new TreeNode());
                    for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                    {
                        Tree.Nodes[0].Nodes[i].Nodes.Add(new TreeNode());
                        Tree.Nodes[0].Nodes[i].Text = dialogue.DialogueRoot[i].DialogueNode[j].ConversationID;
                        Tree.Nodes[0].Nodes[i].Nodes[j].Text = count.ToString();
                        count += 1;
                    }

                    count = 1;
                }
            }

        }

        private void FormEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }

        private void Tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Tree.SelectedNode = e.Node;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tree.Nodes[0].IsSelected)
            {
                Tree.Nodes[0].Nodes.Add(new TreeNode("New Root"));
                return;
            }
            for (int i = 0; i < Tree.Nodes[0].Nodes.Count; i++)
            {
                if (Tree.Nodes[0].Nodes[i].IsSelected)
                {
                    Tree.Nodes[0].Nodes[i].Nodes.Add(new TreeNode("New Node"));
                }
            }
        }

        private void buttonAddNode_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRoot_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
