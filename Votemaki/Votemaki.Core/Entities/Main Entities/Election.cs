﻿using System.Collections.Generic;
using Votemaki.Core.Entities.NavigationEntities;

namespace Votemaki.Core.Entities.MainEntities
{
    public class Election
    {
        public string Name { get; set; }
        public IEnumerable<Votable> Votables { get; set; }
        public IEnumerable<VoterElection> VoterElections { get; set; }
        public IEnumerable<Vote> Votes { get; set; }
    }
}