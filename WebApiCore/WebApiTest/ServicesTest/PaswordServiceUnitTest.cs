using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WebApiTest.ServicesTest
{
    public class PaswordServiceUnitTest
    {
        [Fact]
        public async Task TestGeneratePasword_() {
            //arrange

            //act

            //assert

        }
        //[Fact]
        //        public async Task ValidateUploadDocument_WhenPolicyBloobIsEmpty_ThenReturnViolationMessage() {
        //            //arrange
        //            var expectedMessage = "Trebuie incarcat extrasul!";
        //            Amendment amendment = new Amendment { ExtEntity = new ExtAmendment { AmendmentClass = new AmendmentClass { Id = 171 } } };
        //            var extAmendment = amendment.ExtEntity as ExtAmendment;
        //            int contractId = 1;
        //            string extractNumber = null;
        //            int docType = 6058;
        //            var expectedSeverity = Severity.EXCLAMATION.ToString();
        //            int blobExist = 0;

        //            amendmentValidationProxy.Setup(proxy => proxy.CountBlobsbyPolicyIdAndDocType(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(blobExist);

        //            var result = new ValidationResult() { Violations = new List<ValidationViolation>() };

        //            //act
        //            ValidationViolation validationViolationResult = await service.ValidateUploadDocument(contractId, extractNumber);
        //            result.Violations.Add(validationViolationResult);

        //            //assert
        //            Assert.IsType<ValidationViolation>(validationViolationResult);
        //            Assert.NotNull(validationViolationResult);
        //            Assert.Single(result.Violations);
        //            var actualViolation = result.Violations[0];
        //            Assert.Equal(expectedMessage, actualViolation._Message);
        //            Assert.Equal(expectedSeverity, actualViolation.Severity);
        //            amendmentValidationProxy.Verify(x => x.CountBlobsbyPolicyIdAndDocType(contractId, docType), Times.Once);
        //        }
    }
}
