﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common;
using LiveVox.NET.Models.Contact.Common.Contacts;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.Contacts
{
    public class BulkUpdateContactRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "";
        [JsonIgnore]
        public string? Resource { get; set; } = "";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Put;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        // Properties to hold the request data
        /// <summary>
        /// Collection of Contact Details to update.
        /// </summary>
        [Required]
        [JsonPropertyName("updateContactDetails")]
        public ICollection<BulkUpdateContactDetails>  UpdateContactDetails { get; set; }
    }
}
