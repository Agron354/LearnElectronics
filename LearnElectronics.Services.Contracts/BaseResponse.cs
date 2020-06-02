using LearnElectronics.Services.Contracts.Services;
using System.Net;

namespace LearnElectronics.Services.Contracts
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public HttpStatusCode Code { get; set; }
        public T Data { get; set; }
    }
}
