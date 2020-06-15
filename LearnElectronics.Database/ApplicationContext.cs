using Microsoft.EntityFrameworkCore;

namespace LearnElectronics.Database
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Theme> Themes { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionVariant> QuestionVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CompletedLecture> CompletedUserLectures { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Dislike> Dislikes { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var testData = TestData.GetTestData();

            modelBuilder.Entity<Theme>().HasData(testData.Themes);
            modelBuilder.Entity<Lecture>().HasData(testData.Lectures);
            modelBuilder.Entity<Comment>().HasData(testData.Comments);
            modelBuilder.Entity<Test>().HasData(testData.Tests);
            modelBuilder.Entity<Question>().HasData(testData.Questions);
            modelBuilder.Entity<QuestionVariant>().HasData(testData.QuestionVariants);
            modelBuilder.Entity<CompletedLecture>().HasData(testData.CompletedUserLectures);
            modelBuilder.Entity<Like>().HasData(testData.Likes);
            modelBuilder.Entity<Dislike>().HasData(testData.Dislikes);
            modelBuilder.Entity<User>().HasData(testData.Users);

            base.OnModelCreating(modelBuilder);
        }
    }
}
