namespace FinalProject.Models
{
    public class WordGameModel
    {
        public int WordId { get; set; }
        public string Word { get; set; }
        public string Hint { get; set; }

        public int RemainingAttempts { get; set; } = 6;
        public string GuessedLetters { get; set; } = ""; // Initialize as an empty string

        public List<char> IncorrectGuesses { get; set; } = new List<char>();
    }
}
