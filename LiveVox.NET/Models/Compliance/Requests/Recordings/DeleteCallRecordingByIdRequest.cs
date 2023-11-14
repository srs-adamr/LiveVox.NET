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

namespace LiveVox.NET.Models.Compliance.Requests.Recordings
{
    public class DeleteCallRecordingByIdRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "recording/{id}";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Delete;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            request.AddParameter("id", RecordingId, ParameterType.UrlSegment);

            return Task.FromResult(request);
        }

        public DeleteCallRecordingByIdRequest(string recordingId)
        {
            RecordingId = recordingId;
        }
        /// <summary>
        /// Gets or sets the recording ID, a unique identifier of the call recording that you wish to delete.
        /// </summary>
        [Required]
        public string RecordingId { get; set; }
    }
}
