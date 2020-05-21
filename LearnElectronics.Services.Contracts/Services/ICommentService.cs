using LearnElectronics.Services.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface ICommentService
    {
        Task<IBaseResponse<List<CommentModel>>> AddComment(AddCommentModel addCommentModel, int userId);
        Task<IBaseResponse<List<CommentModel>>> EditComment(EditCommentModel editCommentModel, int userId);
        Task<IBaseResponse<List<CommentModel>>> DeleteComment(int commentId, int userId);
    }
}
