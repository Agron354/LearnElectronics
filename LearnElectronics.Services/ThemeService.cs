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
    public class ThemeService : IThemeService
    {
        public ApplicationContext _applicationContext { get; set; }
        private readonly IMapper _mapper;
        public ThemeService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public async Task<IBaseResponse<List<ThemeModel>>> GetThemes(int userId)
        {
            var themeList = await _applicationContext.Themes.ToListAsync();
            var themes = new List<ThemeModel>();
            foreach (var theme in themeList)
            {
                var currentTheme = _mapper.Map<ThemeModel>(theme);
                var themeLectures = await _applicationContext.Lectures.Where(lec => lec.ThemeId == theme.Id).ToListAsync();
                currentTheme.LigthLectures = new List<LigthLectureModel>();

                foreach (var lecture in themeLectures)
                {
                    var lightLecture = _mapper.Map<LigthLectureModel>(lecture);
                    var isLectureCompleted = await _applicationContext.CompletedUserLectures.FirstOrDefaultAsync(lec => lec.LectureId == lecture.Id && lec.UserId == userId);
                    lightLecture.IsCompleted = userId == 0 ? false : isLectureCompleted != null;
                    currentTheme.LigthLectures.Add(lightLecture);
                }
                themes.Add(currentTheme);
            }

            return new BaseResponse<List<ThemeModel>>
            {
                Code = HttpStatusCode.OK,
                Data = themes
            };

        }
    }
}
