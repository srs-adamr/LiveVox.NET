﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests
{
    public class BulkUpdateContactRequest : ILiveVoxRequest
    {
        public string? Category { get; set; } = "";
        public string? Resource { get; set; } = "";
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
