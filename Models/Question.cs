using System.ComponentModel.DataAnnotations;

namespace NewQuizApp.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> AnswerOptions { get; set; }
        public int CorrectAnswer { get; set; }
        public string ImageSource { get; set; }
        public int QuizId { get; set; }
    }
}
