using System.Collections.Generic;

namespace LearnElectronics.WebApi.Tests.Models
{
    public interface IRepository
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Create(User user);
    }
}