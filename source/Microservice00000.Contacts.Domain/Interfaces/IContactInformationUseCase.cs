using Microservice00000.Contacts.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice00000.Contacts.Domain.Interfaces
{
    public interface IContactInformationUseCase
    {
        ContactResult CreateContact(Int64 exepctId, string expectFirstName, string expectLastName, string expectedContactNumber);

    }
}
