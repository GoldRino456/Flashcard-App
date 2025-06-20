using Spectre.Console;
using Utilities.GoldRino456;

namespace Flashcards.GoldRino456.UI
{
    enum MenuOptions
    {
        StartStudy = 1,
        EditMaterials = 2,
        ViewMaterials = 3,
        ViewStudySession = 4,
        Quit = 0
    }

    internal static class DisplayEngine
    {
        public static void ProcessMainMenu()
        {
            while(true)
            {
                var menuSelection = DisplayMainMenu();
            }
        }

        private static MenuOptions DisplayMainMenu()
        {
            var menuOptions = new Dictionary<string, int> { 
                { "Start A Study Session", ((int)MenuOptions.StartStudy)}, 
                { "Edit Study Materials", ((int)MenuOptions.EditMaterials) }, 
                { "View Study Materials", ((int)MenuOptions.ViewMaterials) }, 
                { "View Study Session History", ((int)MenuOptions.ViewStudySession) }, 
                { "Quit", ((int)MenuOptions.Quit) }};

            return (MenuOptions) DisplayUtils.PromptUserForSingleSelection("What would you like to do?", menuOptions);
        }
    }
}
