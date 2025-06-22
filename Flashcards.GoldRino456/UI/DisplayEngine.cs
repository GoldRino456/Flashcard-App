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

            return (MenuOptions) DisplayUtils.PromptUserForIndexSelection("What would you like to do?", menuOptions);
        }

        public static void DisplayErrorToUser(string error)
        {
            AnsiConsole.WriteLine("[red]" + error + "[/]");
        }

        public static EditOptions DisplayEditMenu()
        {
            var editOptions = new Dictionary<string, int> {
                { "Create A New Stack", ((int)EditOptions.CreateStack) },
                { "Create A New Flashcard", ((int)EditOptions.CreateFlashcard) },
                { "Edit An Existing Stack", ((int)EditOptions.EditStack)},
                { "Edit An Existing Flashcard", ((int)EditOptions.EditFlashcard) },
                { "Go Back", ((int)EditOptions.Quit) }};

            return (EditOptions) DisplayUtils.PromptUserForIndexSelection("Please make a selection:", editOptions);
        }

        public static void PromptUserForStackInfo(Stack stack)
        {
            var stackName = DisplayUtils.PromptUserForStringInput("What do you want to call this card stack?");

            stack.StackName = stackName;
        }

        public static void PromptUserForFlashcardInfo(Flashcard flashcard, List<Stack> stackList)
        {
            if(stackList.Count == 0 || stackList == null)
            {
                AnsiConsole.WriteLine("No existing card stack found.");
                return;
            }

            var stackChoices = new Dictionary<string, int>();

            foreach (Stack stack in stackList)
            {
                stackChoices[stack.StackName] = stack.StackId;
            }

            var frontOfCard = DisplayUtils.PromptUserForStringInput("Please enter the text for the front side of the flashcard: ");
            var backOfCard = DisplayUtils.PromptUserForStringInput("Please enter the text for the back side of the flashcard: ");
            var stackIndex = DisplayUtils.PromptUserForIndexSelection("Which stack should this card be added to?", stackChoices);

            flashcard.StackId = stackIndex;
            flashcard.FrontOfCard = frontOfCard;
            flashcard.BackOfCard = backOfCard;
        }
    }
}
