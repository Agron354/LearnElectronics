using LearnElectronics.CommonData;
using System.Collections.Generic;

namespace LearnElectronics.Services.Contracts.Models
{
    public class QuestionModel
    {
        public string Description { get; set; }
        public TestComponent Component { get; set; }
        public List<string> Variants { get; set; }

        public QuestionModel()
        {
            Variants = new List<string>();
        }
    }
}
