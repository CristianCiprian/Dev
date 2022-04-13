using Microsoft.AspNetCore.Authentication;
using Moq;
using PasswordGenerate.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApiCore.Controllers;
using WebApiCore.Framework;
using Xunit;

namespace WebApiTest.ControllersTest
{
    public class PasswordControllerUnitTest
    {
        private PasswordController service;
        private Mock<IPasswordService> passwordService;
        private Mock<IAuthenticationService> authenticationService;
      public PasswordControllerUnitTest() {
            passwordService = new Mock<IPasswordService>();
            authenticationService = new Mock<IAuthenticationService>();
            service = new PasswordController( authenticationService.Object, passwordService.Object);
        }

        [Fact]
        public async Task TestGeneratePassword_() {
            //arrange
            int userId = 123;
            DateTime dateTime = DateTime.Now;
            PasswordResponse passwordResponse = new PasswordResponse { UserId = 123, Password = "abcd", DateTimePasswordStarted = dateTime, DateTimePasswordEnded = dateTime.AddSeconds(30)};
            passwordService.Setup(mock => mock.GeneratePassword(It.IsAny<int>(), It.IsAny<DateTime>())).ReturnsAsync(passwordResponse);

            //act
            var result = await service.GetPassword(userId, dateTime);
            //assert
            Assert.NotNull(result);

        }
    }
}
