using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cool_RPG.UI;

namespace Cool_RPG.Gamelogic
{
    internal class Character
    {
        public Character(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.charisma = charisma;

            this.maxHealth = 10 + getBonus(constitution);
            health = maxHealth;
        }

        public Character(UI.Character other)
        {
            this.strength = other.strength;
            this.dexterity = other.dexterity;
            this.constitution = other.constitution;
            this.intelligence = other.intelligence;
            this.wisdom = other.wisdom;
            this.charisma = other.charisma;
            this.maxHealth = 10 + getBonus(constitution);
            health = maxHealth;
        }

        public int strength { get; }
        public int dexterity { get;}
        public int constitution { get; }
        public int intelligence { get; }
        public int wisdom { get; }
        public int charisma { get; }
        public int MaxHealth { get { return maxHealth; } }
        private int maxHealth;
        private int health;
        public int Health { get { return health; } }

        public void takeDamage(int damage)
        {
            this.health -= damage;
        }

        public int getBonus(int score)
        {
            switch (score)
            {
                default:
                    return 0;
                case 9:
                case 8:
                    return -1;
                case 7:
                case 6:
                    return -2;
                case 5:
                case 4:
                    return -3;
                case 3:
                case 2:
                    return -4;
                case 1:
                    return -5;
                case 12:
                case 13:
                    return 1;
                case 14:
                case 15:
                    return 2;
                case 16:
                case 17:
                    return 3;
                case 18:
                case 19:
                    return 4;
                case 20:
                    return 5;

            }
        }
    }
}
