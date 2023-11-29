using Cool_RPG.DialogueU;
using Cool_RPG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cool_RPG.Gamelogic
{
    internal class NonPlayerCharacter : Character
    {
        public NonPlayerCharacter(int strength = 0, int dexterity = 0, int constitution = 0, int intelligence = 0, int wisdom = 0, int charisma = 0) : base(strength, dexterity, constitution, intelligence, wisdom, charisma)
        {
        }

        public Dialogue dialogueTree { get; set; }

    }
}
