using Spectre.Console;
using Utilities.GoldRino456;

namespace Flashcards.GoldRino456.UI
{
    internal static class MainMenu
    {
        public static void ProcessMainMenu()
        {
            while(true)
            {
                AnsiConsole.WriteLine(DisplayMainMenu());
            }
        }

        private static string DisplayMainMenu()
        {
            var menuOptions = new string[] { "Start A Study Session", "Edit Study Materials", "View Study Materials", "View Study Session History", "Quit"};
            return  DisplayUtils.PromptUserForSingleSelection("What would you like to do?", menuOptions);
        }
    }
}
