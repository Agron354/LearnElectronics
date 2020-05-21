using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LearnElectronics.Services.Contracts.Services
{
    public interface IBaseResponse<T>
    {
        HttpStatusCode Code { get; set; }
        T Data { get; set; }
    }
}
