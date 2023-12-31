﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common;
using LiveVox.NET.Models.Contact.Common.Contacts;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.Contacts
{
    public class UpdateContactRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "contact";
        [JsonIgnore]
        public string? Resource { get; set; } = "contacts";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Put;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("account", Account);
            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        public UpdateContactRequest(string account)
        {
            Account = account;
        }

        /// <summary>
        /// The Account of the contact to be updated.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// The details of a contact that will be updated.
        /// </summary>
        [JsonPropertyName("updateContactDetails")]
        public ContactDetails UpdateContactDetails { get; set; }
    }
}
