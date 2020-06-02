﻿using System.Collections.Generic;

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
