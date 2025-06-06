using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the entries in a matchup, which can be teams or individuals.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner of the matchup, which is a team or individual that advances to the next round.
        /// </summary>
        public TeamModel? Winner { get; set; }
        /// <summary>
        /// Represents the matchup's score, which is used to determine the winner.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
