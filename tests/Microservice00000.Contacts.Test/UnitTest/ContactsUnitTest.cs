using Microservice00000.Contacts.Domain.Contracts;
using Microservice00000.Contacts.Domain.Entities;
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

        //Arrange
        [Theory]
        [InlineData(1, "Francisco", "Abayon", "0921151615")]
        [InlineData(2, "Alice", "Noyaba", "09238910021")]
        [InlineData(3, "Nimrod", "Abayon", "09224873491")]
        public void CreateContact__Returns__Success(Int64 id, string firstName, string lastName, string contactNumber)
        {

            //Act
            Contact expected = new Contact(id, firstName, lastName, contactNumber);
            Contact actual = new Contact(id, firstName, lastName, contactNumber);

            //Assert
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.ContactNumber, actual.ContactNumber);
        }

    }
}
