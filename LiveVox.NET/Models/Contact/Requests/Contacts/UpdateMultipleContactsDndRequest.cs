﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common.Contacts;
using LiveVox.NET.Models.Contact.Enumerations;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.Contacts
{
    public class UpdateMultipleContactsDndRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "contact";
        [JsonIgnore]
        public string? Resource { get; set; } = "contacts/dnd";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Post;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }
        
        // <summary>
        /// An array of contact phones and their DND settings.
        /// </summary>
        [JsonPropertyName("contactDnd")]
        public ICollection<ContactDnd> ContactDND { get; set; }
    }
}
