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
            // clean the unused test class on Id
            // Arrange

            string expectFirstName = "francisco";
            string expectLastName = "abayon";
            string expectedContactNumber = "09224878349";

            IContactInformationUseCase createContactInformation = new ContactInformationUseCase();

            // Act
            ContactResult actualContactResult = createContactInformation.CreateContact( expectFirstName, expectLastName, expectedContactNumber);

            // Assert
            Assert.NotNull(actualContactResult);
            //Assert.NotEqual(0, actualContactResult.Id);
            Assert.Equal(expectFirstName, actualContactResult.FirstName);
            Assert.Equal(expectFirstName, actualContactResult.FirstName);
            Assert.Equal(expectLastName, actualContactResult.LastName);
            Assert.Equal(expectedContactNumber, actualContactResult.ContactNumber);
        }

        // ToDo : unit test the character case sensitve in contact entity

        //Arrange
        [Theory]
        [InlineData("Francisco", "Abayon", "0921151615")]
        [InlineData("Alice", "Delos Santos", "09238910021")]
        [InlineData("Nimrod", "Abayon IV", "09224873491")]
        [InlineData("Dianalyn", "Muaña", "09224873491")]
        [InlineData("Danica MARIE", "Muaña", "09224873491")]
        [InlineData("dAnica marie", "Noyaba", "09224873491")]
        [InlineData("Nimrod", "Abayon", "09224873491")]
        [InlineData("Nimrosd", "Abayon", "09224873491")]

        public void CreateContact__Returns__Success(string firstName, string lastName, string contactNumber)
        {
            //Act
            Contact expected = new Contact( firstName, lastName, contactNumber);
            Contact actual = new Contact(firstName, lastName, contactNumber);

            //Assert
            Assert.NotNull(expected);
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.ContactNumber, actual.ContactNumber);
        }

        //Arrange
        [Theory]
        [InlineData("!Francisco", "Abayon", "0921151615", "firstName")]
        [InlineData("Fran(isc0", "Abayon", "0921151615", "firstName")]
        [InlineData("Alice", "Noyab@", "09238910021", "lastName")]
        [InlineData("Nimrod", "Abayon 3rd", "09224873491", "lastName")]


        public void CreateContact__Returns__Failed(string firstName, string lastName, string contactNumber, string invalidParameter)
        {
            //Act
            var expected = Record.Exception(() => new Contact(firstName, lastName, contactNumber));

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