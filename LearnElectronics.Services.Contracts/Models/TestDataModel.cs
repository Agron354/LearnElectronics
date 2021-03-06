﻿using System.Collections.Generic;

namespace LearnElectronics.Services.Contracts.Models
{
    public class TestDataModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<QuestionModel> Questions { get; set; }

        public TestDataModel()
        {
            Questions= new List<QuestionModel>();
        }
    }
}
