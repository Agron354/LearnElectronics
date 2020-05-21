using LearnElectronics.Services.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LearnElectronics.Services.Contracts
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public HttpStatusCode Code { get; set; }
        public T Data { get; set; }
    }
}
