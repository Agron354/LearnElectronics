using System;
using System.Collections.Generic;
using System.Text;

namespace LearnElectronics.Services.Contracts.Models
{
    public class CheckedTestModel
    {
        public bool IsCompleted { get; set; }
        public List<string> CorrectAnswers { get; set; }
        public CheckedTestModel()
        {
            CorrectAnswers = new List<string>();
        }
    }
}
