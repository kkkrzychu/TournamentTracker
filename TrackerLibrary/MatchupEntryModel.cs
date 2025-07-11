﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team competing in a matchup.
        /// </summary>
        public TeamModel? TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for the team in this matchup.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came from as the winner.
        /// </summary>
        public MatchupModel? ParentMatchup { get; set; }      
    }
}
