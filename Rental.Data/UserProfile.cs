using System;

namespace Rental.Data
{
    public class UserProfile
    {
        /// <summary>
        /// User's firstname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// User's lastname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// User's birthday
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// User's <see cref="FirstName"/> and <see cref="LastName"/>
        /// </summary>
        public string FullName { get => FirstName + " " + LastName; }
    }
}