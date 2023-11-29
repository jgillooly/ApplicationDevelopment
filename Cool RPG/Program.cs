using Cool_RPG.DialogueU;
using Cool_RPG.Gamelogic;
using Cool_RPG.UI;

namespace Cool_RPG
{
    internal static class Program
    {
        public static Game game = new Game();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            game.StartGame();

            while (game.running)
            {
                Application.Run(game.getCurrentForm());
            }
            

            //FormManager.Start();

            NonPlayerCharacter npc = new NonPlayerCharacter();
            npc.dialogueTree = new DialogueU.Dialogue();


        }
    }
}