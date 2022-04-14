using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PasswordGenerate.DataModels;
using PaswordGenerate.DataModels;
using System;
using System.Net;
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
        public async Task TestGeneratePassword_UserValid_OK()
        {
            //arrange
            var user = new User {
                DateTimeUser = DateTime.Now,
                UserId = 123 };
            DateTime dateTimeExpected = DateTime.Now;

            var passwordResponse = new PasswordResponse { 
                UserId = 123,
                Password = "abcd",
                DateTimePasswordStarted = user.DateTimeUser,
                DateTimePasswordEnded = user.DateTimeUser.AddSeconds(30) };

            passwordService.Setup(
                mock => mock.GeneratePassword(
                    It.IsAny<int>(),
                    It.IsAny<DateTime>())).ReturnsAsync(passwordResponse);

            //act
            IActionResult result = await service.GeneratePassword(user);
            ObjectResult objectResult = result as ObjectResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<ObjectResult>(result);
            Assert.Equal(passwordResponse.DateTimePasswordStarted.Second, dateTimeExpected.Second);
            Assert.Equal(passwordResponse.DateTimePasswordEnded.Second, dateTimeExpected.AddSeconds(30).Second);
            Assert.Equal((int)HttpStatusCode.OK, objectResult.StatusCode);
            //passwordService.Verify(x => x.GeneratePassword(user.UserId,user.DateTimeUser), Times.Once);
        }

        [Fact]
        public async Task TestGeneratePassword_WithoutUserId_BadRequest()
        {
            //arrange
            string expectedError = "A intervenit o eroare...";
            var user = new User { DateTimeUser = DateTime.Now };
            //DateTime dateTimeExpected = DateTime.Now;
            //var passwordResponse = new PasswordResponse { UserId = 123, Password = "abcd", DateTimePasswordStarted = user.DateTimeUser, DateTimePasswordEnded = user.DateTimeUser.AddSeconds(30) };
            passwordService.Setup(mock => mock.GeneratePassword(It.IsAny<int>(), It.IsAny<DateTime>()));

            //act
            var result = await service.GeneratePassword(user);
            ObjectResult objectResult = result as ObjectResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<ObjectResult>(result);
            Assert.Equal(objectResult.Value, expectedError);
            Assert.Equal((int)HttpStatusCode.BadRequest, objectResult.StatusCode);

        }

        [Fact]
        public async Task TestCheckPassword_ValidPassword_OK()
        {
            //arrange
            string password = "123";
            int expectedResult = 1;
            passwordService.Setup(mock => mock.CheckPassword(It.IsAny<string>())).ReturnsAsync(1);

            //act
            var result = await service.CheckPassword(password);
            ObjectResult objectResult = result as ObjectResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<ObjectResult>(result);
            Assert.Equal(objectResult.Value, expectedResult);
            Assert.Equal((int)HttpStatusCode.OK, objectResult.StatusCode);
        }

        [Fact]
        public async Task TestCheckPassword_InvalidPassword_Ok()
        {
            //arrange
            string password = "123";
            int expectedResult = 0;
            passwordService.Setup(mock => mock.CheckPassword(It.IsAny<string>())).ReturnsAsync(0);

            //act
            var result = await service.CheckPassword(password);
            ObjectResult objectResult = result as ObjectResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<ObjectResult>(result);
            Assert.Equal(objectResult.Value, expectedResult);
            Assert.Equal((int)HttpStatusCode.OK, objectResult.StatusCode);
        }
    }
}
