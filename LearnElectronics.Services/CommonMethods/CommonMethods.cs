using AutoMapper;
using LearnElectronics.Database;
using LearnElectronics.Services.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnElectronics.Services
{
    public class CommonMethods
    {
        public static async Task<List<CommentModel>> GetCommentList(List<Comment> commentList, List<CommentModel> comments, ApplicationContext _applicationContext, IMapper _mapper, int userId)
        {
            foreach (var comment in commentList)
            {

                var likes = await _applicationContext.Likes.Where(like => like.CommentId == comment.Id).ToListAsync();
                var dislikes = await _applicationContext.Dislikes.Where(dlike => dlike.CommentId == comment.Id).ToListAsync();
                var commentAuthor = await _applicationContext.Users.FirstOrDefaultAsync(us => us.Id == comment.UserId);

                var currentComment = _mapper.Map<CommentModel>(comment);
                currentComment.DateTime = comment.DateTime.ToShortDateString();
                currentComment.UserName = commentAuthor.UserName;

                var currentUserLike = await _applicationContext.Likes.FirstOrDefaultAsync(like => like.CommentId == comment.Id && like.UserId == userId);
                var currentUserDislike = await _applicationContext.Dislikes.FirstOrDefaultAsync(dlike => dlike.CommentId == comment.Id && dlike.UserId == userId);

                currentComment.Likes = new LikeModel()
                {
                    Count = likes.Count,
                    IsLiked = currentUserLike != null
                };

                currentComment.Dislikes = new DislikeModel()
                {
                    Count = dislikes.Count,
                    IsDisliked = currentUserDislike != null
                };

                comments.Add(currentComment);
            }
            return comments;
        }
    }
}
