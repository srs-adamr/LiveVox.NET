﻿using LiveVox.NET.Models.Base;
using RestSharp;
using System.Text.Json.Serialization;

namespace LiveVox.NET.Models.Contact.Requests.Contacts
{
    public class DeleteContactRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "contact";
        [JsonIgnore]
        public string? Resource { get; set; } = "contacts";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Delete;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddQueryParameter("acct", Account);
            return Task.FromResult(request);
        }

        public DeleteContactRequest(string account)
        {
            Account = account;
        }

        /// <summary>
        /// The account of the contact you want to delete.
        /// </summary>
        public string Account { get; set; }
    }
}
