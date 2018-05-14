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
        public FormViewer(FormMain parent, string directory)
        {
            parentForm = parent;
            fileDir = directory;
            InitializeComponent();
            grid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dialogue = JsonConvert.DeserializeObject<DialogueTree>(File.ReadAllText(
                fileDir));

            for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
            {
                for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                {
                    DataGridViewRow row = (DataGridViewRow)grid.RowTemplate.Clone();
                    string[] strings =
                    {
                        dialogue.DialogueRoot[i].DialogueNode[j].ConversationID,
                        dialogue.DialogueRoot[i].DialogueNode[j].ParticipantName,
                        dialogue.DialogueRoot[i].DialogueNode[j].EmoteType,
                        dialogue.DialogueRoot[i].DialogueNode[j].Side,
                        dialogue.DialogueRoot[i].DialogueNode[j].Line,
                        dialogue.DialogueRoot[i].DialogueNode[j].SpecialityAnimation,
                        dialogue.DialogueRoot[i].DialogueNode[j].SpecialtyCamera,
                        dialogue.DialogueRoot[i].DialogueNode[j].Participants,
                        dialogue.DialogueRoot[i].DialogueNode[j].ConversationSummary,
                    };
                    row.CreateCells(grid, strings);
                    grid.Rows.Add(strings);
                    dialogueLines += 1;
                }
            }
        }

        private void grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string convID = grid.SelectedRows[0].Cells[0].Value + string.Empty;
            string partName = grid.SelectedRows[0].Cells[1].Value + string.Empty;
            string emote = grid.SelectedRows[0].Cells[2].Value + string.Empty;
            string line = grid.SelectedRows[0].Cells[4].Value + string.Empty;
            display.Text = convID + ", " + partName + ", " + emote + ":" +
                           Environment.NewLine + "\"" + line + "\"";
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.SelectedCells.Count == 1 && e.RowIndex != -1)
            {
                display.Text = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + string.Empty;
            }
        }

        private void buttonNextLine_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(dialogue.DialogueRoot[dialogue.DialogueRoot.Count - 1]
               .DialogueNode[dialogue.DialogueRoot[dialogue.DialogueRoot.Count - 1].DialogueNode.Count - 1].Line))
            {
                for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
                {
                    for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                    {
                        if (display.Text ==
                            dialogue.DialogueRoot[i].DialogueNode[j].ConversationID + ", " +
                            dialogue.DialogueRoot[i].DialogueNode[j].ParticipantName + ", " +
                            dialogue.DialogueRoot[i].DialogueNode[j].EmoteType + ":" +
                            Environment.NewLine +
                            "\"" + dialogue.DialogueRoot[i].DialogueNode[j].Line + "\""
                            )
                        {
                            if (dialogue.DialogueRoot[i].DialogueNode.Count == j + 1)
                            {
                                display.Text = dialogue.DialogueRoot[i + 1].DialogueNode[0].ConversationID + ", ";
                                display.Text += dialogue.DialogueRoot[i + 1].DialogueNode[0].ParticipantName + ", ";
                                display.Text += dialogue.DialogueRoot[i + 1].DialogueNode[0].EmoteType + ":";
                                display.Text += Environment.NewLine;
                                display.Text += "\"" + dialogue.DialogueRoot[i + 1].DialogueNode[0].Line + "\"";
                                return;
                            }

                            display.Text = dialogue.DialogueRoot[i].DialogueNode[j + 1].ConversationID + ", ";
                            display.Text += dialogue.DialogueRoot[i].DialogueNode[j + 1].ParticipantName + ", ";
                            display.Text += dialogue.DialogueRoot[i].DialogueNode[j + 1].EmoteType + ":";
                            display.Text += Environment.NewLine;
                            display.Text += "\"" + dialogue.DialogueRoot[i].DialogueNode[j + 1].Line + "\"";
                            return;
                        }
                    }
                }
            }
        }

        private void buttonPrevConv_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
            {
                for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                {
                    if (display.Text.Contains(dialogue.DialogueRoot[i].DialogueNode[j].Line) && i > 0)
                    {
                        display.Text = dialogue.DialogueRoot[i - 1].DialogueNode[0].ConversationID + ", ";
                        display.Text += dialogue.DialogueRoot[i - 1].DialogueNode[0].ParticipantName + ", ";
                        display.Text += dialogue.DialogueRoot[i - 1].DialogueNode[0].EmoteType + ":";
                        display.Text += Environment.NewLine;
                        display.Text += "\"" + dialogue.DialogueRoot[i - 1].DialogueNode[0].Line + "\"";
                        return;
                    }
                }
            }
        }

        private void buttonNextConv_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
            {
                for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                {
                    if (display.Text.Contains(dialogue.DialogueRoot[i].DialogueNode[j].Line) &&
                        i < dialogue.DialogueRoot.Count - 1)
                    {
                        display.Text = dialogue.DialogueRoot[i + 1].DialogueNode[0].ConversationID + ", ";
                        display.Text += dialogue.DialogueRoot[i + 1].DialogueNode[0].ParticipantName + ", ";
                        display.Text += dialogue.DialogueRoot[i + 1].DialogueNode[0].EmoteType + ":";
                        display.Text += Environment.NewLine;
                        display.Text += "\"" + dialogue.DialogueRoot[i + 1].DialogueNode[0].Line + "\"";
                        return;
                    }
                }
            }
        }

        private void FormViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }
    }
}
