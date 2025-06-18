namespace Flashcards.GoldRino456
{
    internal class Flashcard
    {
        public int ID { get; set; }
        public required int StackID { get; init; }
        public required string FrontOfCard { get; init; }
        public required string BackOfCard { get; init; }
    }
}
