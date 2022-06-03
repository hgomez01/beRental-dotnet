using System;

namespace Rental.Api.Models
{
    public class MovieAudit
    {
        /// <summary>
        /// Audit entry Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Movie Id
        /// </summary>
        public Guid MovieId { get; set; }

        /// <summary>
        /// Previous movie title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Previous movie sale price
        /// </summary>
        public double SalePrice { get; set; }

        /// <summary>
        /// Previous movie rental price
        /// </summary>
        public double RentalPrice { get; set; }

        /// <summary>
        /// Id of user doing the change
        /// </summary>
        public Guid UpdatedBy { get; set;}

        /// <summary>
        /// Date and time when this is updated
        /// </summary>
        public DateTime UpdatedOn { get; set; }
    }
}