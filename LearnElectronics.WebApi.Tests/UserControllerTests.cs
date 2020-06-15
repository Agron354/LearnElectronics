using LearnElectronics.Services;
using LearnElectronics.Services.Contracts.Models;
using LearnElectronics.WebApi.Tests.Models;
using LearnElectronics.WebApplication.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LearnElectronics.WebApi.Tests
{
    public class UserControllerTests
    {
        private readonly UserService userService;

        [Fact]
        public void IndexReturnsAViewResultWithAListOfUsers()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestUsers());
            var controller = new UserController(userService);

            // Act
            var user = new LoginUserModel()
            {
                Login = "World Keeper",
                Password = "12345"
            };
            var result = controller.Login(user);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<User>>(viewResult.Model);
            Assert.Equal(GetTestUsers().Count, model.Count());
        }
        private List<User> GetTestUsers()
        {
            var users = new List<User>
            {
                new User { Id=1, Login="World Keeper", Password="12345", UserName="Egor", RegistrationData=DateTime.Now },
                new User { Id=2, Login="World Destroyer", Password="123", UserName="Roma", RegistrationData=DateTime.Now },
            };
            return users;
        }
    }
}
