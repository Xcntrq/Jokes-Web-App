namespace Jokes_Web_App.Models
{
    public class Joke
    {
        public Joke()
        {
        }

        public int Id { get; set; }

        public string? Question { get; set; }

        public string? Answer { get; set; }
    }
}
