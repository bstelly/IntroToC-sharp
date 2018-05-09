﻿namespace DialogueTool
{
    partial class FormMain
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
            this.buttonEditor = new System.Windows.Forms.Button();
            this.buttonViewer = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.displayFileDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEditor
            // 
            this.buttonEditor.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditor.Location = new System.Drawing.Point(13, 121);
            this.buttonEditor.Name = "buttonEditor";
            this.buttonEditor.Size = new System.Drawing.Size(160, 90);
            this.buttonEditor.TabIndex = 0;
            this.buttonEditor.Text = "Editor";
            this.buttonEditor.UseVisualStyleBackColor = true;
            // 
            // buttonViewer
            // 
            this.buttonViewer.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewer.Location = new System.Drawing.Point(194, 121);
            this.buttonViewer.Name = "buttonViewer";
            this.buttonViewer.Size = new System.Drawing.Size(160, 90);
            this.buttonViewer.TabIndex = 1;
            this.buttonViewer.Text = "Viewer";
            this.buttonViewer.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "dialogue.json";
            this.openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            this.openFileDialog.Tag = "";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(13, 40);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(62, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(80, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(274, 13);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Select a .json file. Leave blank if creating a brand new file.";
            // 
            // displayFileDir
            // 
            this.displayFileDir.Location = new System.Drawing.Point(81, 43);
            this.displayFileDir.Name = "displayFileDir";
            this.displayFileDir.Size = new System.Drawing.Size(274, 20);
            this.displayFileDir.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 229);
            this.Controls.Add(this.displayFileDir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonViewer);
            this.Controls.Add(this.buttonEditor);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditor;
        private System.Windows.Forms.Button buttonViewer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox displayFileDir;
        private string fileDir;
    }
}

