﻿using LiveVox.NET.Models.Campaign.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Campaign.Responses
{
    public class ListCampaingnResponse : ILiveVoxResponse
    {   
        /// <summary>
        /// Gets or sets a URI for the next page of entries. If not present or blank, there are no more pages.
        /// </summary>
        public Uri Next { get; set; }

        /// <summary>
        /// Gets or sets a container for a page of Campaign detail entries.
        /// </summary>
        public List<CampaignEntry> CampaignDetails { get; set; }
    }
}
