using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cool_RPG.Gamelogic
{
    internal class Game
    {
        Random die = new Random();
        public enum State
        {
            Creation,
            Dialogue,
            Combat
        }
        public Character player;
        public Character enemy;
        public State gamestate;
        public bool running = true;
        public State GameState { get { return gamestate; } }
        private Character? character;
        public bool combatOver = false;
        public string victor = "";

        public void StartGame()
        {
            gamestate = State.Creation;
        }

        public void FinalizeCharacter(Character character)
        {
            this.character = character;
            gamestate = State.Dialogue;
        }



        private void Update()
        {
            switch (gamestate)
            {
                case State.Creation:
                    //FormManager.CreateForm<Form1>();
                    break;
                case State.Dialogue:
                    break;
                case State.Combat:
                    break;
            }
        }

        public Form getCurrentForm()
        {
            switch (gamestate)
            {
                case State.Creation:
                    return new Form1();
                case State.Dialogue:
                    return new Form2();
                case State.Combat:
                    return new Form3();
                default:
                    return new Form();
            }
        }

        public string Attack()
        {
            string result = "";
            if (gamestate != State.Combat) return "Nice try bud. No hacks allowed :)";
            int roll = die.Next(1, 21) + player.getBonus(player.dexterity);
            if (roll < 10)
            {
                result += "Your attack missed :(";
            }
            else
            {
                enemy.takeDamage((player.strength > 15) ? 2 : 1);
                result += "You deal " + ((player.strength > 15) ? 2 : 1) + " damage to your enemy.";
            }

            roll = die.Next(1, 21);
            if ( roll < 10 + player.getBonus(player.dexterity))
            {
                result += " The enemy attacks you but misses";
            } else
            {
                player.takeDamage(1);
                result += " The enemy attacks you for 1 damage";
            }
            CheckOver();
            return result;
        }

        public string Defend()
        {
            string result = "You ready yourself for the enemy attack";
            int roll = die.Next(1, 21);
            if (roll < 15 + player.getBonus(player.dexterity))
            {
                result += " The enemy attacks you but misses";
            }
            else
            {
                player.takeDamage(1);
                result += " The enemy attacks you for 1 damage";
            }
            CheckOver();
            return result;
        }

        public string Diplomacy()
        {
            string result = "You fail at convincing him";
            int roll = die.Next(1, 21) + player.getBonus(player.charisma);
            if (roll > 10)
            {
                combatOver = true;
                victor = "Player";
                return "You successfully win over the enemy";
            } else
            {
                roll = die.Next(1, 21);
                if (roll < 10 + player.getBonus(player.dexterity))
                {
                    result += " The enemy attacks you but misses";
                }
                else
                {
                    player.takeDamage(1);
                    result += " The enemy attacks you for 1 damage";
                    CheckOver();
                }
                return result;
            }
        }

        private void CheckOver()
        {
            combatOver = (player.Health <= 0 || enemy.Health <= 0);
            victor = (player.Health > 0) ? "Player" : "Enemy";
        }
    }
}
