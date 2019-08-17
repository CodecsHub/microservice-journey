using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice00000.Contacts.Domain.Entities
{
    /// <summary>
    /// The sealed Contact class.
    /// The entity for contact information
    /// </summary>
    /// <remarks>
    /// <para>This class is consist of properties are private set but get in open via constructor</para>
    /// <para>These operations can be performed on contact information combination of string and number</para>
    /// </remarks>
    public sealed class Contact
    {
        /// <summary>
        /// The unique Id for the contact information entity.
        /// </summary>
        /// <value>Gets the value of Id and private set from contructor</value>
        public Int64 Id { get; private set;}

        /// <summary>
        /// The first name of the contact information.
        /// </summary>
        /// <value>Gets the value of FirstName and private set from contructor</value>
        public string FirstName { get; private set; }

        /// <summary>
        /// The last Name of the contact information.
        /// </summary>
        /// <value>Gets the value of LastName and private set from contructor</value>
        public string LastName { get; private set; }

        /// <summary>
        /// The contact number of the contact information.
        /// </summary>
        /// <value>Gets the value of ContactNumber and private set from contructor</value>
        public string ContactNumber { get; private set; }

        /// <summary>
        /// Entry point of the contact information system
        /// </summary>
        /// <return>
        /// get the return data set in the constructor
        /// </return>
        /// <example>
        /// <code>
        /// Contact contactInformation = new Contact(exepctId, expectFirstName, expectLastName, expectedContactNumber);
        /// return contactInformation;
        /// </code>
        /// </example>
        /// <param name="id">831</param>
        /// <param name="firstname">Francisco</param>
        /// <param name="lastname">Abayon</param>
        /// <param name="contactNumber">092248678349</param>
        /// <exception cref="System.ArgumentException">Thrown when either firstname
        /// or lastname is not a valid name</exception>
        public Contact(Int64 id, string firstname, string lastname, string contactNumber)
        {


            if (ValidateName(firstname) == true)
            {
                this.FirstName = firstname ?? throw new NullReferenceException(nameof(firstname));
            }
            else
            {
                throw new ArgumentException("The value was not valid", "firstName");
            }

            if (ValidateName(lastname) == true)
            {
                this.LastName = lastname;
            }
            else
            {
                throw new ArgumentException("The value was not valid", "lastName");
            }


            this.Id = id;
            this.ContactNumber = contactNumber ?? throw new ArgumentNullException(nameof(contactNumber));



        }


        private bool ValidateName(string name)
        {
            bool output = true;
            char[] invalidCharacters = "`~!@#$%^&*()_+=0123456789<>,.?/\\|{}[]'\"".ToCharArray();

            if (name == null || name == String.Empty)
            {
                output = false;
            }

            if (name.Length < 2)
            {
                output = false;
            }

            if (name.IndexOfAny(invalidCharacters) >= 0)
            {
                output = false;
            }

            return output;
        }
    }
}
