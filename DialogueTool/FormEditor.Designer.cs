using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DialogueTool
{
    partial class FormEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Dialogue Root", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Dialogue Tree", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.Tree = new System.Windows.Forms.TreeView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAddNode = new System.Windows.Forms.Button();
            this.buttonAddRoot = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.checkBoxRootWarn = new System.Windows.Forms.CheckBox();
            this.checkBoxNodeWarn = new System.Windows.Forms.CheckBox();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tree
            // 
            this.Tree.ContextMenuStrip = this.contextMenu;
            this.Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tree.Location = new System.Drawing.Point(12, 12);
            this.Tree.Name = "Tree";
            treeNode4.Name = "1";
            treeNode4.Text = "1";
            treeNode5.Name = "Dialogue Root";
            treeNode5.Text = "Dialogue Root";
            treeNode6.Name = "Dialogue Tree";
            treeNode6.Text = "Dialogue Tree";
            this.Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.Tree.Size = new System.Drawing.Size(207, 658);
            this.Tree.TabIndex = 0;
            this.Tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_NodeMouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // buttonAddNode
            // 
            this.buttonAddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNode.Location = new System.Drawing.Point(225, 69);
            this.buttonAddNode.Name = "buttonAddNode";
            this.buttonAddNode.Size = new System.Drawing.Size(67, 51);
            this.buttonAddNode.TabIndex = 2;
            this.buttonAddNode.Text = "Add Node";
            this.toolTip.SetToolTip(this.buttonAddNode, "Adds a Node to the selected Dialogue Root");
            this.buttonAddNode.UseVisualStyleBackColor = true;
            this.buttonAddNode.Click += new System.EventHandler(this.buttonAddNode_Click);
            // 
            // buttonAddRoot
            // 
            this.buttonAddRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoot.Location = new System.Drawing.Point(225, 12);
            this.buttonAddRoot.Name = "buttonAddRoot";
            this.buttonAddRoot.Size = new System.Drawing.Size(67, 51);
            this.buttonAddRoot.TabIndex = 3;
            this.buttonAddRoot.Text = "Add Root";
            this.toolTip.SetToolTip(this.buttonAddRoot, "Add a Root to the Tree");
            this.buttonAddRoot.UseVisualStyleBackColor = true;
            this.buttonAddRoot.Click += new System.EventHandler(this.buttonAddRoot_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(225, 619);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(102, 51);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove Root/Node";
            this.toolTip.SetToolTip(this.buttonRemove, "Remove the currently selected Root or Node");
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // checkBoxRootWarn
            // 
            this.checkBoxRootWarn.AutoSize = true;
            this.checkBoxRootWarn.Checked = true;
            this.checkBoxRootWarn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRootWarn.Location = new System.Drawing.Point(337, 625);
            this.checkBoxRootWarn.Name = "checkBoxRootWarn";
            this.checkBoxRootWarn.Size = new System.Drawing.Size(158, 17);
            this.checkBoxRootWarn.TabIndex = 5;
            this.checkBoxRootWarn.Text = "Warn when removing Roots";
            this.checkBoxRootWarn.UseVisualStyleBackColor = true;
            // 
            // checkBoxNodeWarn
            // 
            this.checkBoxNodeWarn.AutoSize = true;
            this.checkBoxNodeWarn.Checked = true;
            this.checkBoxNodeWarn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNodeWarn.Location = new System.Drawing.Point(337, 647);
            this.checkBoxNodeWarn.Name = "checkBoxNodeWarn";
            this.checkBoxNodeWarn.Size = new System.Drawing.Size(161, 17);
            this.checkBoxNodeWarn.TabIndex = 6;
            this.checkBoxNodeWarn.Text = "Warn when removing Nodes";
            this.checkBoxNodeWarn.UseVisualStyleBackColor = true;
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.checkBoxNodeWarn);
            this.Controls.Add(this.checkBoxRootWarn);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddRoot);
            this.Controls.Add(this.buttonAddNode);
            this.Controls.Add(this.Tree);
            this.Name = "FormEditor";
            this.Text = "Dialogue Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditor_FormClosed);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormMain parentForm;
        private string fileDir;
        private DialogueTree dialogue;
        private System.Windows.Forms.TreeView Tree;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private ToolTip toolTip;
        private Button buttonAddNode;
        private Button buttonAddRoot;
        private Button buttonRemove;
        private CheckBox checkBoxRootWarn;
        private CheckBox checkBoxNodeWarn;
    }
}