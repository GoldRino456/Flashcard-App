namespace Flashcards.GoldRino456
{
    internal class StudySession
    {
        public int ID { get; set; }
        public required int StackID { get; init; }
        public required DateOnly Date { get; init; }
        public required int Score { get; init; }
    }
}
