using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace DialogueTool
{
    class DialogueTree
    {
        public List<DialogueRoot> DialogueRoot = new List<DialogueRoot>();

        //Prototype: 
        //Arguments: 
        //Description: 
        //Precondition: 
        //Postcondition: 
        //Protection Level: 
        public void Save(string destination, string fileName)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            string newName = @"\" + fileName;
            if (!newName.Contains(".json") || !newName.Contains(".Json") ||
                !newName.Contains(".JSON"))
            {
                newName += ".json";
            }
            File.WriteAllText(destination + newName, json);
        }

        //Prototype: 
        //Arguments: 
        //Description: 
        //Precondition: 
        //Postcondition: 
        //Protection Level: 
        public void Load(string directory)
        {
            DialogueTree temp = JsonConvert.DeserializeObject<DialogueTree>(
                File.ReadAllText(directory));
            DialogueRoot = temp.DialogueRoot;
        }
    }
}
