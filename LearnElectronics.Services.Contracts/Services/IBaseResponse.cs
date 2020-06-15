using System.Net;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface IBaseResponse<T>
    {
        HttpStatusCode Code { get; set; }
        T Data { get; set; }
    }
}
