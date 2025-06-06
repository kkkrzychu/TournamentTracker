using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents a place in a tournament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        ///     Represents the name of the place for the prize (e.g., "First Place", "Runner Up").
        /// </summary>
        public string? PlaceName { get; set; }
        /// <summary>
        /// Represents the amount of money awarded for the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of the total prize pool awarded for this prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
