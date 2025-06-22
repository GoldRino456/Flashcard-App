namespace Flashcards.GoldRino456.Database.Models
{
    internal class Stack
    {
        public int StackId {  get; set; }
        public string? StackName { get; set; }


        public override string ToString()
        {
            return $"{StackId}: {StackName}";
        }
    }
}
