using System;
using System.Collections.Generic;
using System.Text;
using LearnElectronics.CommonData;

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
