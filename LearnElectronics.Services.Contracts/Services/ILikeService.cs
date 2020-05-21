using LearnElectronics.Services.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface ILikeService
    {
        Task<IBaseResponse<int>> LikeComment(int commentId, int userId);
        Task<IBaseResponse<int>> DislikeComment(int commentId, int userId);
    }
}
