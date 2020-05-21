using LearnElectronics.Services.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface ILectureService
    {
        Task<IBaseResponse<LectureModel>> GetLecture(int lectureId, int userId);
    }
}
