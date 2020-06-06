using LearnElectronics.Services.Contracts.Models;
using System.Threading.Tasks;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface ILikeService
    {
        Task<IBaseResponse<RateModel>> LikeComment(int commentId, int userId);
        Task<IBaseResponse<RateModel>> DislikeComment(int commentId, int userId);
    }
}
