using LearnElectronics.Services.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface IThemeService
    {
        Task<IBaseResponse<List<ThemeModel>>> GetThemes(int userId);
    }
}
