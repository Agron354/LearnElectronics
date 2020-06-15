using System;

namespace LearnElectronics.WebApi.Tests.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationData { get; set; }
    }
}
