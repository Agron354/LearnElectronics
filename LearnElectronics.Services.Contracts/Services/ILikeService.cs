using LearnElectronics.Services.Contracts.Models;
using System.Threading.Tasks;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface ILikeService
    {
        Task<IBaseResponse<LikeModel>> LikeComment(int commentId, int userId);
        Task<IBaseResponse<DislikeModel>> DislikeComment(int commentId, int userId);
    }
}
