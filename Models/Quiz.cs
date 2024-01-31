using System.ComponentModel.DataAnnotations;

namespace NewQuizApp.Models
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageSource { get; set; }
    }
}
