namespace StackOverflow.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public DateTime QuestionDateAndTime { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
    }
}
