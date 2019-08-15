using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

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
            //
            // Arrange
            string expectName = "John Doe";
            string expectedPhoneNumber = "+76 1 400 180 66";
            //ICreateContactInformation createContactInformation = new CreateContactInformation();

            // Act
            //CustomerResult actualCustomerResult = registerUC.Register(expectName, expectedPhoneNumber);

            // Assert
            //Assert.NotNull(actualCustomerResult);
            //Assert.NotEqual(Guid.Empty, actualCustomerResult.Id);
            //Assert.Equal(expectName, actualCustomerResult.Name);
            //Assert.Equal(expectedPhoneNumber, actualCustomerResult.PhoneNumber);
        }

    }
}
