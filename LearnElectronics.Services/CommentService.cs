using AutoMapper;
using LearnElectronics.Database;
using LearnElectronics.Services.Contracts;
using LearnElectronics.Services.Contracts.Models;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LearnElectronics.Services
{
    public class CommentService : ICommentService
    {
        public ApplicationContext _applicationContext { get; set; }
        private readonly IMapper _mapper;
        public CommentService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public async Task<IBaseResponse<List<CommentModel>>> AddComment(AddCommentModel addCommentModel, int userId)
        {
            if (addCommentModel != null)
            {
                await _applicationContext.Comments.AddAsync
                (
                    new Comment
                    {
                        DateTime = DateTime.Now,
                        Text = addCommentModel.Text,
                        UserId = userId,
                        LectureId = addCommentModel.LectureId
                    }
                );
                await _applicationContext.SaveChangesAsync();
            }

            var commentList = await _applicationContext.Comments.Where(com => com.LectureId == addCommentModel.LectureId).ToListAsync();
            var comments = new List<CommentModel>();

            comments = await CommonMethods.GetCommentList(commentList, comments, _applicationContext, _mapper, userId);

            return new BaseResponse<List<CommentModel>>
            {
                Code = addCommentModel != null ? HttpStatusCode.Created : HttpStatusCode.BadRequest,
                Data = comments
            };

        }

        public async Task<IBaseResponse<List<CommentModel>>> EditComment(EditCommentModel editCommentModel, int userId)
        {
            var editedComment = await _applicationContext.Comments.FindAsync(editCommentModel.CommentId);
            if (editedComment != null)
            {
                editedComment.Text = editCommentModel.Text;
                await _applicationContext.SaveChangesAsync();
            }

            var commentList = await _applicationContext.Comments.Where(com => com.LectureId == editedComment.LectureId).ToListAsync();
            var comments = new List<CommentModel>();

            comments = await CommonMethods.GetCommentList(commentList, comments, _applicationContext, _mapper, userId);

            return new BaseResponse<List<CommentModel>>
            {
                Code = editedComment != null ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
                Data = comments
            };

        }

        public async Task<IBaseResponse<List<CommentModel>>> DeleteComment(int id, int userId)
        {
            var deletedComment = await _applicationContext.Comments.FindAsync(id);
            if (deletedComment != null)
            {
                _applicationContext.Comments.Remove(deletedComment);
                await _applicationContext.SaveChangesAsync();
            }
            var commentList = await _applicationContext.Comments.Where(com => com.LectureId == deletedComment.LectureId).ToListAsync();
            var comments = new List<CommentModel>();

            comments = await CommonMethods.GetCommentList(commentList, comments, _applicationContext, _mapper, userId);

            return new BaseResponse<List<CommentModel>>
            {
                Code = deletedComment != null ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
                Data = comments
            };

        }

    }
}
