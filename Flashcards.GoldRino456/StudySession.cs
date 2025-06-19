namespace Flashcards.GoldRino456
{
    internal class StudySession
    {
        public int Id { get; set; }
        public required int StackId { get; init; }
        public required DateTime Date { get; init; }
        public required int Score { get; init; }
    }
}
