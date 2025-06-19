namespace Flashcards.GoldRino456.Database.Models
{
    internal class Flashcard
    {
        public int Id { get; set; }
        public required int StackId { get; init; }
        public required string FrontOfCard { get; init; }
        public required string BackOfCard { get; init; }
    }
}
