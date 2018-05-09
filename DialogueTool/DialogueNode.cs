using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueTool
{
    class DialogueNode
    {
        public string ConversationID { get; set; }
        public string ParticipantName { get; set; }
        public string EmoteType { get; set; }
        public string Side { get; set; }
        public string Line { get; set; }
        public string SpecialityAnimation { get; set; }
        public string SpecialtyCamera { get; set; }
        public string Participants { get; set; }
        public string ConversationSummary { get; set; }
    }
}
