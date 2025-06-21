using Flashcards.GoldRino456.Database;
using Flashcards.GoldRino456.Database.Models;
using Flashcards.GoldRino456.UI;

public class StudyAid()
{
    private static void Main()
    {
        while (true)
        {
            ProcessMainMenu();
        }
    }

    private static void ProcessMainMenu()
    {
        var menuSelection = DisplayEngine.DisplayMainMenu();

        switch (menuSelection)
        {
            case MenuOptions.StartStudy:
                break;

            case MenuOptions.EditMaterials:
                ProcessEditSelected();
                break;

            case MenuOptions.ViewMaterials:
                break;

            case MenuOptions.ViewStudySession:
                break;

            case MenuOptions.Quit:
                break;
        }
    }

    private static void ProcessEditSelected()
    {
        var choice = DisplayEngine.DisplayEditMenu();

        switch(choice)
        {
            case EditOptions.CreateStack:
                break;
            case EditOptions.CreateFlashcard:
                break;
            case EditOptions.EditStack:
                break;
            case EditOptions.EditFlashcard:
                break;
            case EditOptions.Quit:
                break;
        }
    }
}

/*DatabaseManager.Instance.InitializeDatabase();

var stackController = DatabaseManager.Instance.StackCtrl;
var flashcardController = DatabaseManager.Instance.FlashcardCtrl;
var studySessionController = DatabaseManager.Instance.StudySessionCtrl;

var stack1 = new Stack() {Name = "Test" };
var card1 = new Flashcard() { StackId = 1, FrontOfCard = "Hola!", BackOfCard = "Hello!" };
var session1 = new StudySession() { StackId = 1, Date = DateTime.Now, Score = 12 };

stackController.CreateEntry(stack1);
flashcardController.CreateEntry(card1);
studySessionController.CreateEntry(session1);

Console.ReadLine();

Console.WriteLine(stackController.ReadEntry(1));
Console.WriteLine(flashcardController.ReadEntry(1));
Console.WriteLine(studySessionController.ReadEntry(1));

Console.ReadLine();

stackController.UpdateEntry(1, new Stack() { Name = "Change" });
flashcardController.UpdateEntry(1, new Flashcard() {StackId = 1, FrontOfCard = "Guten Tag!", BackOfCard = "Good Day!"});
studySessionController.UpdateEntry(1, new StudySession() { StackId = 1, Date = DateTime.Now, Score = 5 });

Console.ReadLine();

Console.WriteLine(stackController.ReadEntry(1));
Console.WriteLine(flashcardController.ReadEntry(1));
Console.WriteLine(studySessionController.ReadEntry(1));

Console.ReadLine();


flashcardController.DeleteEntry(1);
studySessionController.DeleteEntry(1);
stackController.DeleteEntry(1);

Console.ReadLine();
*/