using System;

namespace Rental.Api.Models
{
    /// <summary>
    /// Class to store information about movies
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Id of the movie
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Title of movie
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Brief description about the movie
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Movie sale price
        /// </summary>
        public double SalePrice { get; set; }

        /// <summary>
        /// Movie rental price
        /// </summary>
        public double RentalPrice { get; set; }

        /// <summary>
        /// Boolean to determine whether a movie is available or not
        /// </summary>
        public bool IsAvailable { get; set; }
    }
}