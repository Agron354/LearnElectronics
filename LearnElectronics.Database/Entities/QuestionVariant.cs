namespace LearnElectronics.Database
{
    public class QuestionVariant
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
    }
}
