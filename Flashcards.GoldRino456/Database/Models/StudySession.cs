namespace Flashcards.GoldRino456.Database.Models
{
    internal class StudySession
    {
        public int Id { get; set; }
        public int StackId { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}
