using Microservice00000.Contacts.Domain.Contracts;
using Microservice00000.Contacts.Domain.Entities;
using Microservice00000.Contacts.Domain.Interfaces;
using Microservice00000.Contacts.Domain.Services;
using System;
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
        [InlineData(2, "Alice", "Delos Santos", "09238910021")]
        [InlineData(3, "Nimrod", "Abayon IV", "09224873491")]
        [InlineData(3, "Dianalyn", "Muaña", "09224873491")]
        [InlineData(4, "Danica Marie", "Muaña", "09224873491")]
        [InlineData(4, "Danica Marie", "Noyaba", "09224873491")]
        [InlineData(Int64.MinValue, "Nimrod", "Abayon", "09224873491")]
        [InlineData(Int64.MaxValue, "Nimrod", "Abayon", "09224873491")]

        public void CreateContact__Returns__Success(Int64 id, string firstName, string lastName, string contactNumber)
        {
            //Act
            Contact expected = new Contact(id, firstName, lastName, contactNumber);
            Contact actual = new Contact(id, firstName, lastName, contactNumber);

            //Assert
            Assert.NotNull(expected);
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.ContactNumber, actual.ContactNumber);
        }

        //Arrange
        [Theory]
        [InlineData(1, "!Francisco", "Abayon", "0921151615", "firstName")]
        [InlineData(1, "Fran(isc0", "Abayon", "0921151615", "firstName")]
        [InlineData(2, "Alice", "Noyab@", "09238910021", "lastName")]
        [InlineData(3, "Nimrod", "Abayon 3rd", "09224873491", "lastName")]


        public void CreateContact__Returns__Failed(Int64 id, string firstName, string lastName, string contactNumber, string invalidParameter)
        {
            //Act
            var expected = Record.Exception(() => new Contact(id, firstName, lastName, contactNumber));

            //Assert
            Assert.NotNull(expected);
            Assert.IsType<ArgumentException>(expected);
            if (expected is ArgumentException argEx)
            {
                Assert.Equal(invalidParameter, argEx.ParamName);
            }
        }

        ////Arrange
        //[Theory]
        //[InlineData(3, null, "Abayon jr.", "09224873491", "firstName")]
        //[InlineData(3, "Nimrod", null, "09224873491", "lastName")]
        //public void CreateContact__Returns__Null(Int64 id, string firstName, string lastName, string contactNumber, string invalidParameter)
        //{
        //    //Act
        //    var expected = Record.Exception(() => new Contact(id, firstName, lastName, contactNumber));

        //    //Assert
        //    Assert.NotNull(expected);
        //    Assert.IsType<NullReferenceException>(expected);
        //    if (expected is NullReferenceException argEx)
        //    {
        //        Assert.Equal(invalidParameter, argEx.GetHashCode);
        //    }
        //}
    }
}