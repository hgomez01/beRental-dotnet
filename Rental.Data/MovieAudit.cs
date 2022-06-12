using System;

namespace Rental.Data
{
    /// <summary>
    /// Stores audit of changes made on <see cref="Movie"/> entries
    /// </summary>
    public class MovieAudit
    {
        /// <summary>
        /// Audit entry Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Previous movie data
        /// </summary>
        public Movie OldMovie { get; set; }

        /// <summary>
        /// Id of user doing the change
        /// </summary>
        public Guid UpdatedByUserId { get; set;}

        /// <summary>
        /// Name of the user doing the change.
        /// This is saved in case user won't be found later
        /// </summary>
        public string UpdatedByUsername { get; set;}

        /// <summary>
        /// Date and time when this is updated
        /// </summary>
        public DateTime UpdatedOn { get; set; }
    }
}