namespace NewQuizApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using NewQuizApp.Models;

    public class QuizDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"data source=DESKTOP-KNK93V5\SQLEXPRESS;initial catalog=DBTest;trusted_connection=true;Encrypt=True;TrustServerCertificate=True"
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quiz>().HasData(
                new Quiz
                {
                    Id = 1,
                    Title = "Looking for Alaska",
                    ImageSource = "https://m.media-amazon.com/images/I/81ckDwn0FdL._AC_UF1000,1000_QL80_.jpg"
                }
            );

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    QuizId = 1,
                    Text = "How does Alaska die?",
                    ImageSource = "https://assets.mycast.io/actor_images/actor-alaska-young-461105_large.jpg?1655621246",
                    AnswerOptions = new List<string>
                    {
                    "Overdose",
                    "Stabbing",
                    "Car accident",
                    "Drowning",
                    },
                    CorrectAnswer = 2,
                },
                new Question
                {
                    Id = 2,
                    QuizId = 1,
                    Text = "What room do Pudge and the Colonel live in?",
                    ImageSource = "https://www.refinery29.com/images/8598766.jpg",
                    AnswerOptions = new List<string>
                    {
                    "Room 56",
                    "Room 18",
                    "Room 42",
                    "Room 43",
                    },
                    CorrectAnswer = 3,
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
