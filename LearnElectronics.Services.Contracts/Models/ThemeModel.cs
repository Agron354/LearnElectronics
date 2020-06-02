using System.Collections.Generic;

namespace LearnElectronics.Services.Contracts.Models
{
    public class ThemeModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<LigthLectureModel> LigthLectures { get; set; }

        public ThemeModel()
        {
            LigthLectures = new List<LigthLectureModel>();
        }
    }
}
