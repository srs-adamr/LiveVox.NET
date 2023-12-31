﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Campaign.Common;
using RestSharp;

namespace LiveVox.NET.Models.Campaign.Requests
{
    public class AppendCampaignRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "campaign";
        [JsonIgnore]
        public string? Resource { get; set; } = "campaigns/{id}/transactions";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Put;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", CampaignId, ParameterType.UrlSegment);

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        /// <summary>
        /// Gets or sets the ID of the campaign to append records to.
        /// </summary>
        public int CampaignId { get; set; }
        /// <summary>
        /// Gets or sets the ID of the campaign to append records to.
        /// </summary>
        [JsonPropertyName("records")]
        public ICollection<CampaignTransaction> CampaignRecords { get; set; }

        public AppendCampaignRequest()
        {
            CampaignRecords = new List<CampaignTransaction>();
        }
    }
}