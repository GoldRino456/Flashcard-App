using Flashcards.GoldRino456.Database.Models;
using Spectre.Console;
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

            return (MenuOptions) DisplayUtils.PromptUserForEnumSelection("What would you like to do?", menuOptions);
        }

        public static EditOptions DisplayEditMenu()
        {
            var editOptions = new Dictionary<string, int> {
                { "Create A New Stack", ((int)EditOptions.CreateStack) },
                { "Create A New Flashcard", ((int)EditOptions.CreateFlashcard) },
                { "Edit An Existing Stack", ((int)EditOptions.EditStack)},
                { "Edit An Existing Flashcard", ((int)EditOptions.EditFlashcard) },
                { "Go Back", ((int)EditOptions.Quit) }};

            return (EditOptions) DisplayUtils.PromptUserForEnumSelection("Please make a selection:", editOptions);
        }

        public static void PromptUserForStackInfo(Stack stack)
        {
            var stackName = DisplayUtils.PromptUserForStringInput("What do you want to call this card stack?");

            stack.Name = stackName;
        }

        public static void PromptUserForFlashcardInfo(Flashcard flashcard, List<Stack> stackList, out Stack? stack)
        {
            stack = null;

            if(stackList.Count == 0)
            {
                stack = new();

                AnsiConsole.WriteLine("No existing card stack found. Creating new card stack!");
                PromptUserForStackInfo(stack);
            }


        }
    }
}
