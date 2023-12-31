﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Call.Common.Agent;

namespace LiveVox.NET.Models.Call.Responses.Agent.Chat
{
    public class ListPostsResponse : ILiveVoxResponse
    {
        /// <summary>
        /// A URI for the next page of entries. If next is not present, or blank, then there are no pages after this one.
        /// </summary>
        [JsonPropertyName("next")]
        public Uri Next { get; set; }

        /// <summary>
        /// An array of posts.
        /// </summary>
        [JsonPropertyName("posts")]
        public ICollection<Post> Posts { get; set; }
    }
}
