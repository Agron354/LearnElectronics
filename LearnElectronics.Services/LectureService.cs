using AutoMapper;
using LearnElectronics.Database;
using LearnElectronics.Services.Contracts;
using LearnElectronics.Services.Contracts.Models;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LearnElectronics.Services
{
    public class LectureService : ILectureService
    {
        public ApplicationContext _applicationContext { get; set; }
        private readonly IMapper _mapper;
        public LectureService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public async Task<IBaseResponse<LectureModel>> GetLecture(int lectureId, int userId)
        {
            var lectureModel = new LectureModel();
            var currentLecture = await _applicationContext.Lectures.FirstOrDefaultAsync(lec => lec.Id == lectureId);

            if (currentLecture == null)
                return new BaseResponse<LectureModel>
                {
                    Code = HttpStatusCode.BadRequest,
                    Data = lectureModel
                };

            lectureModel = _mapper.Map<LectureModel>(currentLecture);

            var lectureTest = await _applicationContext.Tests.FirstOrDefaultAsync(test => test.LectureId == lectureId);

            lectureModel.Test = _mapper.Map<TestDataModel>(lectureTest);
            var testQuestionModels = new List<QuestionModel>();
            var testQuestions = await _applicationContext.Questions.Where(qu => qu.TestId == lectureTest.Id).ToListAsync();

            foreach (var question in testQuestions)
            {
                var testQuestion = _mapper.Map<QuestionModel>(question);
                var questionVariants = await _applicationContext.QuestionVariants.Where(qv => qv.QuestionId == question.Id).ToListAsync();
                
                for (int i = 0; i < questionVariants.Count; i++)
                {
                    testQuestion.Variants.Add(questionVariants[i].Description);
                }
                testQuestionModels.Add(testQuestion);
            }
            lectureModel.Test.Questions = testQuestionModels; 

            var isLectureCompleted = await _applicationContext.CompletedUserLectures.FirstOrDefaultAsync(lec => lec.LectureId == lectureId && lec.UserId == userId);
            lectureModel.IsCompleted = isLectureCompleted != null ? true : false;

            var lectureComments = await _applicationContext.Comments.Where(com => com.LectureId == lectureModel.Id).ToListAsync();
            lectureModel.Comments = await CommonMethods.GetCommentList(lectureComments, new List<CommentModel>(), _applicationContext, _mapper, userId);

            return new BaseResponse<LectureModel>
            {
                Code = HttpStatusCode.OK,
                Data = lectureModel
            };

        }
    }
}
