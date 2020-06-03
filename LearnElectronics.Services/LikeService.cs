using AutoMapper;
using LearnElectronics.Database;
using LearnElectronics.Services.Contracts;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LearnElectronics.Services
{
    public class LikeService : ILikeService
    {
        public ApplicationContext _applicationContext { get; set; }
        private readonly IMapper _mapper;
        public LikeService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }
        public async Task<IBaseResponse<int>> LikeComment(int commentId, int userId)
        {
            var like = await _applicationContext.Likes.FirstOrDefaultAsync(lik => lik.CommentId == commentId && lik.UserId == userId);
            if (like == null)
            {
                await _applicationContext.Likes.AddAsync
                (
                    new Like
                    {
                        CommentId = commentId,
                        UserId = userId
                    }
                );
                var dislike = await _applicationContext.Dislikes.FirstOrDefaultAsync(dlik => dlik.CommentId == commentId && dlik.UserId == userId);
                if (dislike != null)
                {
                    _applicationContext.Dislikes.Remove(dislike);
                }
                await _applicationContext.SaveChangesAsync();
            }
            else
            {
                _applicationContext.Likes.Remove(like);
                await _applicationContext.SaveChangesAsync();
            }
            var likes = await _applicationContext.Likes.Where(lik => lik.CommentId == commentId).ToListAsync();
            var likeCount = likes.Count();

            return new BaseResponse<int>
            {
                Code = commentId != 0 ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
                Data = likeCount
            };
        }

        public async Task<IBaseResponse<int>> DislikeComment(int commentId, int userId)
        {
            var dislike = await _applicationContext.Dislikes.FirstOrDefaultAsync(dislik => dislik.CommentId == commentId && dislik.UserId == userId);
            if (dislike == null)
            {
                await _applicationContext.Dislikes.AddAsync
                (
                    new Dislike
                    {
                        CommentId = commentId,
                        UserId = userId
                    }
                );
                var like = await _applicationContext.Likes.FirstOrDefaultAsync(lik => lik.CommentId == commentId && lik.UserId == userId);
                if (like != null)
                {
                    _applicationContext.Likes.Remove(like);
                }
                await _applicationContext.SaveChangesAsync();
            }
            else
            {
                _applicationContext.Dislikes.Remove(dislike);
                await _applicationContext.SaveChangesAsync();
            }
            var dislikes = await _applicationContext.Dislikes.Where(dislik => dislik.CommentId == commentId).ToListAsync();
            var dislikeCount = dislikes.Count();

            return new BaseResponse<int>
            {
                Code = commentId != 0 ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
                Data = dislikeCount
            };
        }
    }
}
