using System;

namespace Rental.Data
{
    public class User
    {
        /// <summary>
        /// User's identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// User's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// User's Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Role assigned <see cref="Role"/>
        /// </summary>
        public Role AccountRole { get; set; }

        /// <summary>
        /// Status the account can be <see cref="UserStatus"/>
        /// </summary>
        public UserStatus Status { get; set; }
    }
}