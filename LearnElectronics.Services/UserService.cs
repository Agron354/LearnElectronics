using AutoMapper;
using LearnElectronics.CommonData;
using LearnElectronics.Database;
using LearnElectronics.Services.Contracts;
using LearnElectronics.Services.Contracts.Models;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LearnElectronics.Services
{
    public class UserService : IUserService
    {
        public ApplicationContext _applicationContext { get; set; }
        private readonly IMapper _mapper;
        public UserService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public static async Task<UserAccountModel> GetUserActivity(UserAccountModel userAccount, int userId, ApplicationContext _applicationContext)
        {
            var userCommments = await _applicationContext.Comments.Where(us => us.Id == userId).ToListAsync();
            userAccount.CommentCount = userCommments.Count;
            var completedUserTests = await _applicationContext.CompletedUserLectures.Where(te => te.UserId == userId).ToListAsync();
            userAccount.CompletedTestCount = completedUserTests.Count;
            var totalTests = await _applicationContext.CompletedUserLectures.ToListAsync();
            userAccount.LectureProgress = completedUserTests.Count * 100 / totalTests.Count;
            return userAccount;
        }

        public async Task<IBaseResponse<UserAccountModel>> GetUserAccount(int userId)
        {
            var userAccount = new UserAccountModel();
            if (userId != 0)
            {
                var userInfo = await _applicationContext.Users.FirstOrDefaultAsync(us => us.Id == userId);
                if (userInfo == null)
                    return new BaseResponse<UserAccountModel>
                    {
                        Code = HttpStatusCode.NotFound,
                        Data = userAccount
                    };
                userAccount = _mapper.Map<UserAccountModel>(userInfo);
                userAccount.RegistrationData = userInfo.RegistrationData.ToShortDateString();
                userAccount = await GetUserActivity(userAccount, userId, _applicationContext);
            }
            else return new BaseResponse<UserAccountModel>
            {
                Code = HttpStatusCode.NotFound,
                Data = userAccount
            };

            return new BaseResponse<UserAccountModel>
            {
                Code = HttpStatusCode.OK,
                Data = userAccount
            };
        }

        public async Task<IBaseResponse<UserAccountModel>> Login(LoginUserModel loginUserModel)
        {
            var userAccount = new UserAccountModel();
            loginUserModel.Password = Hashing.HashValue(loginUserModel.Password);

            var user = await _applicationContext.Users.FirstOrDefaultAsync(us => us.Login == loginUserModel.Login && us.Password == loginUserModel.Password);
            if (user == null)
                return new BaseResponse<UserAccountModel>
                {
                    Code = HttpStatusCode.NotFound,
                    Data = userAccount
                };
            userAccount = _mapper.Map<UserAccountModel>(user);
            userAccount = await GetUserActivity(userAccount, user.Id, _applicationContext);

            return new BaseResponse<UserAccountModel>
            {
                Code = HttpStatusCode.OK,
                Data = userAccount
            };
        }


        public async Task<IBaseResponse<UserAccountModel>> Register(RegisterUserModel registerUserModel)
        {
            var userAccount = new UserAccountModel();
            registerUserModel.Password = Hashing.HashValue(registerUserModel.Password);

            var user = await _applicationContext.Users.FirstOrDefaultAsync(us => us.Login == registerUserModel.Login);
            if (user != null)
                return new BaseResponse<UserAccountModel>
                {
                    Code = HttpStatusCode.BadRequest,
                    Data = userAccount
                };
            else
            {
                await _applicationContext.Users.AddAsync
                (
                    new User
                    {
                        UserName = registerUserModel.UserName,
                        Login = registerUserModel.Login,
                        Password = registerUserModel.Password,
                        RegistrationData = DateTime.Now,
                    }
                );
                await _applicationContext.SaveChangesAsync();
            }
            user = await _applicationContext.Users.FirstOrDefaultAsync(us => us.Login == registerUserModel.Login || us.Password == registerUserModel.Password);
            userAccount = _mapper.Map<UserAccountModel>(user);
            userAccount = await GetUserActivity(userAccount, user.Id, _applicationContext);

            return new BaseResponse<UserAccountModel>
            {
                Code = HttpStatusCode.OK,
                Data = userAccount
            };
        }
    }
}
