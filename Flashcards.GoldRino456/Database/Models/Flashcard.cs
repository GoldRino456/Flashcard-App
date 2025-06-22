using System.Diagnostics;

namespace Flashcards.GoldRino456.Database.Models
{
    internal class Flashcard
    {
        public int CardId { get; set; }
        public int StackId { get; set; }
        public string? FrontOfCard { get; set; }
        public string? BackOfCard { get; set; }

        public override string ToString()
        {
            return $"{StackId}: {FrontOfCard}, {BackOfCard}";
        }
    }
}
