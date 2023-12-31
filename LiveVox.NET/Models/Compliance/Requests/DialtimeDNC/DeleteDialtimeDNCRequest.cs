﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using RestSharp;

namespace LiveVox.NET.Models.Compliance.Requests.DialtimeDnc
{
    public class DeleteDialtimeDncRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "dialtime/dnc/{dncId}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("dncId", DncId, ParameterType.UrlSegment);

            return Task.FromResult(request);
        }
        public DeleteDialtimeDncRequest(int dncId)
        {
            DncId = dncId;
        }
        /// <summary>
        /// Gets or sets the dialtime Dnc entry id to be deleted.
        /// </summary>
        [Required]
        public int DncId { get; set; }
    }
}
