﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Campaign.Common;
using RestSharp;

namespace LiveVox.NET.Models.Campaign.AppendCampaign
{
    public class AppendCampaignRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "campaign";
        public string? Resource { get; set; } = "campaigns/{id}/transactions";
        public Method RequestType { get; set; }

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Resource.Replace("{id}", CampaignId.ToString()), RequestType);

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

        public ICollection<CampaignTransaction> Records { get; set; }

        public AppendCampaignRequest()
        {
            Records = new List<CampaignTransaction>();
        }
    }
}