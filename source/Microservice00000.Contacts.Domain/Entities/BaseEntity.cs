using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice00000.Contacts.Domain.Entities
{
    /// <summary>
    /// The base entity property of all Entity
    /// </summary>
    public abstract class BaseEntity
    {


        /// <summary>
        /// The unique Id for the contact information entity.
        /// </summary>
        /// <value>Gets the value of Id and private set from constructor.</value>
        public Guid Id { get; set; }

        public int RowVersionNumber { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime CurrentAt { get; set; }
        public bool IsActive { get; set; }


    }
}
