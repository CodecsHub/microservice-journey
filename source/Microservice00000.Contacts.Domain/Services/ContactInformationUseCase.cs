using Microservice00000.Contacts.Domain.Contracts;
using Microservice00000.Contacts.Domain.Entities;
using Microservice00000.Contacts.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice00000.Contacts.Domain.Services
{
    public class ContactInformationUseCase : IContactInformationUseCase
    {
        public ContactResult CreateContact(string expectFirstName, string expectLastName, string expectedContactNumber)
        {
            Contact contactInformation = new Contact( expectFirstName, expectLastName, expectedContactNumber);
            return new ContactResult(contactInformation);
        }
    }
}
