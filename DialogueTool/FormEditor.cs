using System;
using System.IO;
using System.Windows.Forms;

namespace DialogueTool
{
    public partial class FormEditor : Form
    {
        //Prototype:
        //Arguments:
        //Description:
        //Precondition:
        //Postcondition:
        //Protection Level:
        public FormEditor(FormMain parent, string directory)
        {
            InitializeComponent();
            dialogue = new DialogueTree();
            parentForm = parent;
            fileDir = directory;
            if (File.Exists(fileDir))
            {
                var count = 1;
                dialogue.Load(fileDir);
                for (var i = 0; i < dialogue.DialogueRoot.Count; i++)
                {
                    Tree.Nodes[0].Nodes.Add(new TreeNode());
                    for (var j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
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

        //Prototype:
        //Arguments:
        //Description:
        //Precondition:
        //Postcondition:
        //Protection Level:
        private void FormEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }

        //Prototype:
        //Arguments:
        //Description:
        //Precondition:
        //Postcondition:
        //Protection Level:
        private void Tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Tree.SelectedNode = e.Node;
        }

        //Prototype:
        //Arguments:
        //Description:
        //Precondition:
        //Postcondition:
        //Protection Level:
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tree.Nodes[0].IsSelected)
            {
                Tree.Nodes[0].Nodes.Add(new TreeNode("New Root"));
                return;
            }

            for (var i = 0; i < Tree.Nodes[0].Nodes.Count; i++)
                if (Tree.Nodes[0].Nodes[i].IsSelected)
                    Tree.Nodes[0].Nodes[i].Nodes.Add(new TreeNode((Tree.Nodes[0].Nodes[i].Nodes.Count + 1).ToString()));
        }

        //Prototype:
        //Arguments:
        //Description:
        //Precondition:
        //Postcondition:
        //Protection Level:
        private void buttonAddNode_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < Tree.Nodes[0].Nodes.Count; i++)
                if (Tree.Nodes[0].Nodes[i].IsSelected)
                    Tree.Nodes[0].Nodes[i].Nodes.Add(new TreeNode((Tree.Nodes[0].Nodes[i].Nodes.Count + 1).ToString()));

            for (var i = 0; i < Tree.Nodes[0].Nodes.Count; i++)
            for (var j = 0; j < Tree.Nodes[0].Nodes[i].Nodes.Count; j++)
                if (Tree.Nodes[0].Nodes[i].Nodes[j].IsSelected)
                    Tree.Nodes[0].Nodes[i].Nodes
                        .Add(new TreeNode((Tree.Nodes[0].Nodes[i].Nodes.Count + 1).ToString()));
        }

        //Prototype:
        //Arguments:
        //Description:
        //Precondition:
        //Postcondition:
        //Protection Level:
        private void buttonAddRoot_Click(object sender, EventArgs e)
        {
            Tree.Nodes[0].Nodes.Add(new TreeNode("New Root"));
        }

        //Prototype:
        //Arguments:
        //Description:
        //Precondition:
        //Postcondition:
        //Protection Level:
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var result = DialogResult.OK;
            if (Tree.SelectedNode != Tree.Nodes[0])
            {
                if (Tree.Nodes[0].Nodes.Contains(Tree.SelectedNode))
                {
                    if (checkBoxRootWarn.Checked)
                        result = MessageBox.Show("Are you sure you want to delete this node?",
                            "Delete Node", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        Tree.SelectedNode.Remove();
                        return;
                    }
                }

                for (var i = 0; i < Tree.Nodes[0].Nodes.Count; i++)
                for (var j = 0; j < Tree.Nodes[0].Nodes[i].Nodes.Count; j++)
                    if (Tree.Nodes[0].Nodes[i].Nodes[j].IsSelected)
                    {
                        if (checkBoxNodeWarn.Checked)
                            result = MessageBox.Show("Are you sure you want to delete this node?",
                                "Delete Node", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            Tree.SelectedNode.Remove();
                            return;
                        }
                    }
            }
        }
    }
}