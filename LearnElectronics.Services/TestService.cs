using AutoMapper;
using LearnElectronics.Database;
using LearnElectronics.Services.Contracts;
using LearnElectronics.Services.Contracts.Models;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LearnElectronics.Services
{
    public class TestService : ITestService
    {
        public ApplicationContext _applicationContext { get; set; }
        private readonly IMapper _mapper;
        public TestService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public async Task<IBaseResponse<CheckedTestModel>> CheckTest(TestModel testModel, int userId)
        {
            var currentTest = await _applicationContext.Tests.FirstOrDefaultAsync(t => t.LectureId == testModel.LectureId);
            var currentTestQuestions = await _applicationContext.Questions.Where(qu => qu.TestId == currentTest.Id).ToListAsync();

            var isTestCompleted = true;
            var correctAnswerList = new List<string>();

            for (int i = 0; i < testModel.Answers.Length; i++)
            {
                var correctAnswers = await _applicationContext.QuestionVariants.Where(qu => qu.IsCorrect && qu.QuestionId == currentTestQuestions[i].Id).ToListAsync();

                var correctAnswerVariants = "";
                foreach (var answer in correctAnswers)
                {
                    correctAnswerVariants += answer != correctAnswers.Last() ? answer.Description + "," : answer.Description;
                }
 
                correctAnswerList.Add(correctAnswerVariants);
                isTestCompleted = !isTestCompleted ? false : string.Compare(testModel.Answers[i], correctAnswerVariants) == 0;
            }

            if (isTestCompleted && userId != 0)
            {
                await _applicationContext.CompletedUserLectures.AddAsync
                (
                    new CompletedLecture
                    {
                        LectureId = testModel.LectureId,
                        UserId = userId
                    }
                );
                await _applicationContext.SaveChangesAsync();
            }

            var checkedTest = new CheckedTestModel() { IsCompleted = isTestCompleted , CorrectAnswers = correctAnswerList};

            return new BaseResponse<CheckedTestModel>
            {
                Code = testModel != null ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
                Data = checkedTest
            };
        }
    }
}
