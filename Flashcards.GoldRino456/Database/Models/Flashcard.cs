namespace Flashcards.GoldRino456.Database.Models
{
    internal class Flashcard
    {
        public int Id { get; set; }
        public int StackId { get; set; }
        public string? FrontOfCard { get; set; }
        public string? BackOfCard { get; set; }
    }
}
