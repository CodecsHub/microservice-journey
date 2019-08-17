using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice00000.Contacts.Domain.Entities
{
    /// <summary>
    /// The sealed <c>Contact</c> class.
    /// The entity for contact information.
    /// <list type="bullet">
    /// <item>
    /// <term>Constructor</term>
    /// <description>Predefined instantation of contact.</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>This class is consist of properties are private set but get in open via constructor.</para>
    /// <para>These operations can be performed on contact information combination of string and number.</para>
    /// </remarks>
    public sealed class Contact
    {

        private Int64 _id;
        private string _firstName;
        private string _lastName;
        private string _contactNumber;

        /// <summary>
        /// The unique Id for the contact information entity.
        /// </summary>
        /// <value>Gets the value of Id and private set from constructor.</value>
        public Int64 Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

        /// <summary>
        /// The first name of the contact information.
        /// </summary>
        /// <value>Gets the value of FirstName and private set from constructor.</value>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            private set
            {
                _firstName = value.ToLower();
            }
        }

        /// <summary>
        /// The last Name of the contact information.
        /// </summary>
        /// <value>Gets the value of LastName and private set from constructor.</value>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            private set
            {
                _lastName = value.ToLower();
            }
        }

        /// <summary>
        /// The contact number of the contact information.
        /// </summary>
        /// <value>Gets the value of ContactNumber and private set from constructor.<value>
        public string ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            private set
            {
                _contactNumber = value.ToLower();
            }
        }

        /// <summary>
        /// Entry point of the contact information system with having
        /// the unique  <paramref name="id"/> then followed by
        /// <paramref name="firstname"/>, <paramref name="lastname"/> and number <paramref name="contactNumber"/>.
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
        /// <param name="id">A unique long Id.</param>
        /// <param name="firstname">The First Name string.</param>
        /// <param name="lastname">The Last Name string.</param>
        /// <param name="contactNumber">The contact number with string data type.</param>
        /// <exception cref="System.ArgumentException">Thrown when either firstname
        /// or lastname is not a valid name.</exception>
        /// See <see cref="ValidateName(string)"/> to add doubles
        /// <seealso cref="CreateContact(Contact)"/>
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
