using Utilities.GoldRino456;

namespace Flashcards.GoldRino456.UI
{
    internal static class DisplayEngine
    {
        public static MenuOptions DisplayMainMenu()
        {
            var menuOptions = new Dictionary<string, int> { 
                { "Start A Study Session", ((int)MenuOptions.StartStudy) }, 
                { "Edit Study Materials", ((int)MenuOptions.EditMaterials) }, 
                { "View Study Materials", ((int)MenuOptions.ViewMaterials) }, 
                { "View Study Session History", ((int)MenuOptions.ViewStudySession) }, 
                { "Quit", ((int)MenuOptions.Quit) }};

            return (MenuOptions) DisplayUtils.PromptUserForSingleSelection("What would you like to do?", menuOptions);
        }

        public static EditOptions DisplayEditMenu()
        {
            var editOptions = new Dictionary<string, int> {
                { "Create A New Stack", ((int)EditOptions.CreateStack) },
                { "Create A New Flashcard", ((int)EditOptions.CreateFlashcard) },
                { "Edit An Existing Stack", ((int)EditOptions.EditStack)},
                { "Edit An Existing Flashcard", ((int)EditOptions.EditFlashcard) },
                { "Go Back", ((int)EditOptions.Quit) }};

            return (EditOptions) DisplayUtils.PromptUserForSingleSelection("Please make a selection:", editOptions);
        }
    }
}
