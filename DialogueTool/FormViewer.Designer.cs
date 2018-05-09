namespace DialogueTool
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ConversationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmoteType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityAnimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConversationSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConversationID,
            this.ParticipantName,
            this.EmoteType,
            this.Side,
            this.Line,
            this.SpecialityAnimation,
            this.SpecialtyCamera,
            this.Participants,
            this.ConversationSummary});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 343);
            this.dataGridView1.TabIndex = 0;
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
            this.Line.Width = 200;
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
            this.ConversationSummary.Width = 200;
            // 
            // FormViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormViewer";
            this.Text = "Dialogue Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmoteType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityAnimation;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participants;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversationSummary;
    }
}