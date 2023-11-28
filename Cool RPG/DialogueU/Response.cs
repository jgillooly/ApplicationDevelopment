using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cool_RPG.DialogueU
{
    internal class Response
    {
        public string responseText {  get; set; }
        //public string[] playerOptions { get; set; }
        public Dictionary<string, Response?> dialogueOptions { get; set; }
        public Response() {
            dialogueOptions = new Dictionary<string, Response?>();
        }


    }
}
