﻿namespace DialogueTool
{
    partial class FormViewer
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.ConversationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmoteType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityAnimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConversationSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.display = new System.Windows.Forms.TextBox();
            this.buttonNextLine = new System.Windows.Forms.Button();
            this.buttonPrevConv = new System.Windows.Forms.Button();
            this.buttonNextConv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConversationID,
            this.ParticipantName,
            this.EmoteType,
            this.Side,
            this.Line,
            this.SpecialityAnimation,
            this.SpecialtyCamera,
            this.Participants,
            this.ConversationSummary});
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1240, 343);
            this.grid.TabIndex = 4;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_RowHeaderMouseClick);
            // 
            // ConversationID
            // 
            this.ConversationID.DividerWidth = 1;
            this.ConversationID.HeaderText = "Conversation ID";
            this.ConversationID.Name = "ConversationID";
            this.ConversationID.ReadOnly = true;
            this.ConversationID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ParticipantName
            // 
            this.ParticipantName.DividerWidth = 1;
            this.ParticipantName.HeaderText = "Participant Name";
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.ReadOnly = true;
            // 
            // EmoteType
            // 
            this.EmoteType.DividerWidth = 1;
            this.EmoteType.HeaderText = "Emote Type";
            this.EmoteType.Name = "EmoteType";
            this.EmoteType.ReadOnly = true;
            // 
            // Side
            // 
            this.Side.DividerWidth = 1;
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            // 
            // Line
            // 
            this.Line.DividerWidth = 1;
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Width = 240;
            // 
            // SpecialityAnimation
            // 
            this.SpecialityAnimation.DividerWidth = 1;
            this.SpecialityAnimation.HeaderText = "Speciality Animation";
            this.SpecialityAnimation.Name = "SpecialityAnimation";
            this.SpecialityAnimation.ReadOnly = true;
            // 
            // SpecialtyCamera
            // 
            this.SpecialtyCamera.DividerWidth = 1;
            this.SpecialtyCamera.HeaderText = "Specialty Camera";
            this.SpecialtyCamera.Name = "SpecialtyCamera";
            this.SpecialtyCamera.ReadOnly = true;
            // 
            // Participants
            // 
            this.Participants.DividerWidth = 1;
            this.Participants.HeaderText = "Participants";
            this.Participants.Name = "Participants";
            this.Participants.ReadOnly = true;
            // 
            // ConversationSummary
            // 
            this.ConversationSummary.DividerWidth = 1;
            this.ConversationSummary.HeaderText = "Conversation Summary";
            this.ConversationSummary.Name = "ConversationSummary";
            this.ConversationSummary.ReadOnly = true;
            this.ConversationSummary.Width = 240;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.White;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(101, 373);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(1058, 105);
            this.display.TabIndex = 3;
            // 
            // buttonNextLine
            // 
            this.buttonNextLine.Location = new System.Drawing.Point(600, 484);
            this.buttonNextLine.Name = "buttonNextLine";
            this.buttonNextLine.Size = new System.Drawing.Size(150, 90);
            this.buttonNextLine.TabIndex = 0;
            this.buttonNextLine.Text = "Next Dialogue Line\r\n";
            this.buttonNextLine.UseVisualStyleBackColor = true;
            this.buttonNextLine.Click += new System.EventHandler(this.buttonNextLine_Click);
            // 
            // buttonPrevConv
            // 
            this.buttonPrevConv.Location = new System.Drawing.Point(481, 580);
            this.buttonPrevConv.Name = "buttonPrevConv";
            this.buttonPrevConv.Size = new System.Drawing.Size(150, 90);
            this.buttonPrevConv.TabIndex = 1;
            this.buttonPrevConv.Text = "Previous Conversation";
            this.buttonPrevConv.UseVisualStyleBackColor = true;
            this.buttonPrevConv.Click += new System.EventHandler(this.buttonPrevConv_Click_1);
            // 
            // buttonNextConv
            // 
            this.buttonNextConv.Location = new System.Drawing.Point(637, 580);
            this.buttonNextConv.Name = "buttonNextConv";
            this.buttonNextConv.Size = new System.Drawing.Size(150, 90);
            this.buttonNextConv.TabIndex = 2;
            this.buttonNextConv.Text = "Next Conversation";
            this.buttonNextConv.UseVisualStyleBackColor = true;
            this.buttonNextConv.Click += new System.EventHandler(this.buttonNextConv_Click);
            // 
            // FormViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.buttonNextConv);
            this.Controls.Add(this.buttonPrevConv);
            this.Controls.Add(this.buttonNextLine);
            this.Controls.Add(this.display);
            this.Controls.Add(this.grid);
            this.Name = "FormViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialogue Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private FormMain parentForm;
        private string fileDir;
        private DialogueTree dialogue;
        private System.Windows.Forms.TextBox display;
        private int dialogueLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmoteType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityAnimation;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participants;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversationSummary;
        private System.Windows.Forms.Button buttonNextLine;
        private System.Windows.Forms.Button buttonPrevConv;
        private System.Windows.Forms.Button buttonNextConv;
    }
}