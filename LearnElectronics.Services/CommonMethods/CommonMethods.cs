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
        public static async Task<List<CommentModel>> GetCommentList(List<Comment> commentList, List<CommentModel> comments, ApplicationContext _applicationContext, IMapper _mapper)
        {
            foreach (var comment in commentList)
            {

                var likes = await _applicationContext.Likes.Where(like => like.CommentId == comment.Id).ToListAsync();
                var dislikes = await _applicationContext.Dislikes.Where(dlike => dlike.CommentId == comment.Id).ToListAsync();
                var commentAuthor = await _applicationContext.Users.FirstOrDefaultAsync(us => us.Id == comment.UserId);

                var currentComment = _mapper.Map<CommentModel>(comment);
                currentComment.UserName = commentAuthor.UserName;
                currentComment.Likes = likes.Count;
                currentComment.Dislikes = dislikes.Count;

                comments.Add(currentComment);
            }
            return comments;
        }
    }
}
