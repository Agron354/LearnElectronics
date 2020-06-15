using LearnElectronics.Services.Contracts.Models;
using System.Threading.Tasks;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface ITestService
    {
        Task<IBaseResponse<CheckedTestModel>> CheckTest(TestModel testModel, int userId);
    }
}
