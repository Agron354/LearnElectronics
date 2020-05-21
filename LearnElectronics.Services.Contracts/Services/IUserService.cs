using LearnElectronics.Services.Contracts.Models;
using System.Threading.Tasks;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface IUserService
    {
        Task<IBaseResponse<UserAccountModel>> GetUserAccount(int userId);
        Task<IBaseResponse<UserAccountModel>> Login(LoginUserModel loginUserModel);
        Task<IBaseResponse<UserAccountModel>> Register(RegisterUserModel registerUserModel);
    }
}
