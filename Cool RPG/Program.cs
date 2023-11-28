using Cool_RPG.DialogueU;

namespace Cool_RPG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(FormManager.Current);

            NonPlayerCharacter npc = new NonPlayerCharacter();
            npc.dialogueTree = new DialogueU.Dialogue();


        }
    }
}