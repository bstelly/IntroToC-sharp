using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DialogueTool
{
    internal class DialogueTree
    {
        public List<DialogueRoot> DialogueRoot = new List<DialogueRoot>();

        //Prototype: void Save(string destination, string fileName)
        //Arguments: Two strings. One for the save location and one for the file name
        //Description: Serializes a DialogueTree object into a json file at a specified location
        //Precondition: There must be a DialogueTree object
        //Postcondition: A DialogueTree object is serialized and saved to a location
        //Protection Level: public
        public void Save(string destination, string fileName)
        {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            var newName = @"\" + fileName;
            if (!newName.Contains(".json") || !newName.Contains(".Json") ||
                !newName.Contains(".JSON"))
                newName += ".json";
            File.WriteAllText(destination + newName, json);
        }

        //Prototype: void Load(string directory)
        //Arguments: Takes in a string
        //Description: Deserializes a DialogueTree object from a json file located at the
        //             specified location into another DialogueTree object
        //Precondition: There must be an instance of the DialogueTree class
        //Postcondition: The DialogueTree object calling the function is assigned the values
        //               of the deserialized file
        //Protection Level: public
        public void Load(string directory)
        {
            var temp = JsonConvert.DeserializeObject<DialogueTree>(
                File.ReadAllText(directory));
            DialogueRoot = temp.DialogueRoot;
        }
    }
}