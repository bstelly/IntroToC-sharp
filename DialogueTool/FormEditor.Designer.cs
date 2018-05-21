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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Dialogue Tree");
            this.Tree = new System.Windows.Forms.TreeView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tree
            // 
            this.Tree.ContextMenuStrip = this.contextMenu;
            this.Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tree.Location = new System.Drawing.Point(12, 12);
            this.Tree.Name = "Tree";
            treeNode2.Name = "Dialogue Tree";
            treeNode2.Text = "Dialogue Tree";
            this.Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.Tree.Size = new System.Drawing.Size(207, 658);
            this.Tree.TabIndex = 0;
            this.Tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_NodeMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(225, 354);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 28);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Root";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Tree);
            this.Name = "FormEditor";
            this.Text = "Dialogue Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditor_FormClosed);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FormMain parentForm;
        private string fileDir;
        private DialogueTree dialogue;
        private System.Windows.Forms.TreeView Tree;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}