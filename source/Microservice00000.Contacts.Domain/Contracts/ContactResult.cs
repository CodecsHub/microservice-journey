using Microservice00000.Contacts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice00000.Contacts.Domain.Contracts
{
    public sealed class ContactResult
    {
        /// <summary>
        /// Get only the return result of Contact.id
        /// </summary>
        public Int64 Id { get; }

        /// <summary>
        /// Get only the return result of Contact.FirstName
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Get only the return result of Contact.LastName
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Get only the return result of Contact.ContactNumber
        /// </summary>
        public string ContactNumber { get; }

        /// <summary>
        /// Return the result fo the <c>ContactResult.cs</c> class with domain binding in the
        /// Entity of <c>Contact.cs</c> class
        /// </summary>
        /// <param name="contact">Contact class {"Id": 1, "FirstName":"Francisco"
        /// ,"LastName" : "Abayon" , "ContactNumber" : :09238910021"};</param>
        public ContactResult(Contact contact)
        {
            this.Id = contact.Id;
            this.FirstName = contact.FirstName;
            this.LastName = contact.LastName;
            this.ContactNumber = contact.ContactNumber;
        }
    }
}
