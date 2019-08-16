using Microservice00000.Contacts.Domain.Contracts;
using Microservice00000.Contacts.Domain.Interfaces;
using Microservice00000.Contacts.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
/// <summary>
/// The unit test of contact class
/// </summary>
namespace Microservice00000.Contacts.Test.UnitTest
{
    /// <summary>
    /// The class for unit testing in Contacts Entities
    /// </summary>
    public class ContactsUnitTest
    {
        [Fact]
        public void CreateSingleContactInformation__Returns_SingleContactInformation()
        {

            // ToDo: refactor to single mock unit class
            // Arrange
            Int64 exepctId = 1;
            string expectFirstName = "Francisco";
            string expectLastName = "Abayon";
            string expectedContactNumber = "09224878349";

            IContactInformationUseCase createContactInformation = new ContactInformationUseCase();

            // Act
            ContactResult actualContactResult = createContactInformation.CreateContact(exepctId, expectFirstName, expectLastName, expectedContactNumber);

            // Assert
            Assert.NotNull(actualContactResult);
            Assert.NotEqual(0, actualContactResult.Id);
            Assert.Equal(expectFirstName, actualContactResult.FirstName);
            Assert.Equal(expectFirstName, actualContactResult.FirstName);
            Assert.Equal(expectLastName, actualContactResult.LastName);
            Assert.Equal(expectedContactNumber, actualContactResult.ContactNumber);
        }

    }
}
