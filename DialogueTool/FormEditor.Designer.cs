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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Dialogue Root", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Dialogue Tree", new System.Windows.Forms.TreeNode[] {
            treeNode2});
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
            this.textBoxConvIdInput = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxParticipantInput = new System.Windows.Forms.TextBox();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tree
            // 
            this.Tree.ContextMenuStrip = this.contextMenu;
            this.Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tree.Location = new System.Drawing.Point(16, 15);
            this.Tree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tree.Name = "Tree";
            treeNode1.Name = "1";
            treeNode1.Text = "1";
            treeNode2.Name = "Dialogue Root";
            treeNode2.Text = "Dialogue Root";
            treeNode3.Name = "Dialogue Tree";
            treeNode3.Text = "Dialogue Tree";
            this.Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.Tree.Size = new System.Drawing.Size(275, 809);
            this.Tree.TabIndex = 0;
            this.Tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_NodeMouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(133, 52);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // buttonAddNode
            // 
            this.buttonAddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNode.Location = new System.Drawing.Point(300, 85);
            this.buttonAddNode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddNode.Name = "buttonAddNode";
            this.buttonAddNode.Size = new System.Drawing.Size(89, 63);
            this.buttonAddNode.TabIndex = 2;
            this.buttonAddNode.Text = "Add Node";
            this.toolTip.SetToolTip(this.buttonAddNode, "Adds a Node to the selected Dialogue Root");
            this.buttonAddNode.UseVisualStyleBackColor = true;
            this.buttonAddNode.Click += new System.EventHandler(this.buttonAddNode_Click);
            // 
            // buttonAddRoot
            // 
            this.buttonAddRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoot.Location = new System.Drawing.Point(300, 15);
            this.buttonAddRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddRoot.Name = "buttonAddRoot";
            this.buttonAddRoot.Size = new System.Drawing.Size(89, 63);
            this.buttonAddRoot.TabIndex = 3;
            this.buttonAddRoot.Text = "Add Root";
            this.toolTip.SetToolTip(this.buttonAddRoot, "Add a Root to the Tree");
            this.buttonAddRoot.UseVisualStyleBackColor = true;
            this.buttonAddRoot.Click += new System.EventHandler(this.buttonAddRoot_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(300, 762);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(136, 63);
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
            this.checkBoxRootWarn.Location = new System.Drawing.Point(449, 769);
            this.checkBoxRootWarn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRootWarn.Name = "checkBoxRootWarn";
            this.checkBoxRootWarn.Size = new System.Drawing.Size(204, 21);
            this.checkBoxRootWarn.TabIndex = 5;
            this.checkBoxRootWarn.Text = "Warn when removing Roots";
            this.checkBoxRootWarn.UseVisualStyleBackColor = true;
            // 
            // checkBoxNodeWarn
            // 
            this.checkBoxNodeWarn.AutoSize = true;
            this.checkBoxNodeWarn.Checked = true;
            this.checkBoxNodeWarn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNodeWarn.Location = new System.Drawing.Point(449, 796);
            this.checkBoxNodeWarn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxNodeWarn.Name = "checkBoxNodeWarn";
            this.checkBoxNodeWarn.Size = new System.Drawing.Size(208, 21);
            this.checkBoxNodeWarn.TabIndex = 6;
            this.checkBoxNodeWarn.Text = "Warn when removing Nodes";
            this.checkBoxNodeWarn.UseVisualStyleBackColor = true;
            // 
            // textBoxConvIdInput
            // 
            this.textBoxConvIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConvIdInput.Location = new System.Drawing.Point(348, 410);
            this.textBoxConvIdInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxConvIdInput.Name = "textBoxConvIdInput";
            this.textBoxConvIdInput.ReadOnly = true;
            this.textBoxConvIdInput.Size = new System.Drawing.Size(159, 26);
            this.textBoxConvIdInput.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(348, 390);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(133, 15);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Conversation ID";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(564, 374);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(133, 32);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Number of\r\nParticipants";
            // 
            // textBoxParticipantInput
            // 
            this.textBoxParticipantInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParticipantInput.Location = new System.Drawing.Point(564, 410);
            this.textBoxParticipantInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxParticipantInput.Name = "textBoxParticipantInput";
            this.textBoxParticipantInput.ReadOnly = true;
            this.textBoxParticipantInput.Size = new System.Drawing.Size(48, 26);
            this.textBoxParticipantInput.TabIndex = 10;
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.textBoxParticipantInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxConvIdInput);
            this.Controls.Add(this.checkBoxNodeWarn);
            this.Controls.Add(this.checkBoxRootWarn);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddRoot);
            this.Controls.Add(this.buttonAddNode);
            this.Controls.Add(this.Tree);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1701, 875);
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
        private TextBox textBoxConvIdInput;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBoxParticipantInput;
    }
}