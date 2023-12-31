﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;
using LiveVox.NET.Models.Contact.Common.Contacts;
using LiveVox.NET.Models.Contact.Enumerations;
using RestSharp;

namespace LiveVox.NET.Models.Contact.Requests.Contacts
{
    public class BulkContactDownloadRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "contact";
        [JsonIgnore]
        public string? Resource { get; set; } = "contacts/bulk";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Post;
        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);

            // If you provide the  Accept-Encoding  header with valid value ' gzip ', the served content is compressed. 

            // Serialize the request using the source-generated context for the specific type of 'request'
            var requestBodyJson = JsonSerializer.Serialize(this, LiveVoxSerializerContext.Default.Options);

            // Add the serialized request body to the RestRequest
            request.AddJsonBody(requestBodyJson);
            return Task.FromResult(request);
        }

        // Properties to hold the request data
        /// <summary>
        /// The start date of the date range to return contact records which have a ‘modifyDate’ as same or after this date.
        /// It could take the format "CCYY-MM-DD" like "2020-01-01" or Unix timestamp like 1577858400000 (in milliseconds).
        /// </summary>
        [JsonPropertyName("startDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The start date of the date range to return contact records which have a ‘modifyDate’ as same or after this date.
        /// It could take the format "CCYY-MM-DD" like "2020-01-01" or Unix timestamp like 1577858400000 (in milliseconds).
        /// </summary>
        [JsonPropertyName("endDate")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// The start date of the date range to return contact records which have a ‘modifyDate’ as same or after this date.
        /// It could take the format "CCYY-MM-DD" like "2020-01-01" or Unix timestamp like 1577858400000 (in milliseconds).
        /// </summary>
        [JsonPropertyName("exportableFields")]
        public ICollection<ExportableFieldBulkDownload> ExportableFields { get; set; }
    }
}
