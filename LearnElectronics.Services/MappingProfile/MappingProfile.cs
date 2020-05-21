using AutoMapper;
using LearnElectronics.Database;
using LearnElectronics.Services.Contracts.Models;

namespace LearnElectronics.Services.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CommentModel, Comment>();
            CreateMap<Comment, CommentModel>();
            CreateMap<Lecture, LectureModel>();
            CreateMap<Comment, CommentModel>();
            CreateMap<Question, QuestionModel>();
            CreateMap<Lecture, LigthLectureModel>();
            CreateMap<Theme, ThemeModel>();
            CreateMap<User, UserAccountModel>();
            CreateMap<Test, TestDataModel>();
        }
    }
}
