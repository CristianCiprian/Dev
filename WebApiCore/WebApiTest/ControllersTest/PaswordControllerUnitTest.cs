using Microsoft.AspNetCore.Authentication;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApiCore.Controllers;
using WebApiCore.Framework;
using WebApiCore.Models;
using Xunit;

namespace WebApiTest.ControllersTest
{
    public class PaswordControllerUnitTest
    {
        private PaswordController service;
        private Mock<IPaswordService> paswordService;
        private Mock<IAuthenticationService> authenticationService;
      public PaswordControllerUnitTest() {
            paswordService = new Mock<IPaswordService>();
            authenticationService = new Mock<IAuthenticationService>();
            service = new PaswordController( authenticationService.Object, paswordService.Object);
        }

        [Fact]
        public async Task TestGeneratePasword_() {
            //arrange
            int userId = 123;
            DateTime dateTime = DateTime.Now;
            PaswordResponse paswordResponse = new PaswordResponse { UserId = 123, Pasword = "abcd", DateTimePaswordStarted = dateTime.ToLongDateString(), DateTimePaswordEnded = dateTime.AddSeconds(30).ToLongDateString()};
            paswordService.Setup(mock => mock.GeneratePasword(It.IsAny<int>(), It.IsAny<DateTime>())).ReturnsAsync(paswordResponse);

            //act
            var result = await service.GetPasword(userId, dateTime);
            //assert
            Assert.NotNull(result);

        }
    }
}
