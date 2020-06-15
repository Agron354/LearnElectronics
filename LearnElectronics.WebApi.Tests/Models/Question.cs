using LearnElectronics.WebApi.Tests.Models

namespace LearnElectronics.Database
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public TestComponent Component { get; set; }
        public int TestId { get; set; }
    }
}
