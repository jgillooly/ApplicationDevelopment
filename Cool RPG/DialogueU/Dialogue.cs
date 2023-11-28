using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cool_RPG.DialogueU
{
    internal class Dialogue
    {
        // relationship between npcs and dialogue is the responsibility of the character class
        // start the dialogue (first things said, first options, etc)
        public Response initialResponse { get; set; }

    }
}
