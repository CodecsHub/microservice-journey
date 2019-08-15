using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice00000.Contacts.Domain.Entities
{
    /// <summary>
    /// Sealed class to be avoided used outside from the domain excep instantion
    /// in infrastructure, presenter and application
    /// </summary>
    public sealed class Contact
    {
        /// <summary>
        /// The unique Id for the contact information entity.
        /// </summary>
        public Int64 Id { get; private set;}

        /// <summary>
        /// The first name of the contact information.
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// The last Name of the contact information.
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// The contact number of the contact information.
        /// </summary>
        public string ContactNumber { get; private set; }

        /// <summary>
        /// Entry point of the contact information system
        /// </summary>
        /// <param name="id">831</param>
        /// <param name="firstname">Francisco</param>
        /// <param name="lastname">Abayon</param>
        /// <param name="contactNumber">092248678349</param>
        public Contact(Int64 id, string firstname, string lastname, string contactNumber)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.ContactNumber = contactNumber;

        }
    }
}
