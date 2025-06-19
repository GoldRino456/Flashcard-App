using Flashcards.GoldRino456;

DatabaseManager.Instance.InitializeDatabase();

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