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
    public class GetCallRecordingInfoRequest : ILiveVoxRequest
    {
        [JsonIgnore]
        public string? Category { get; set; } = "compliance";
        [JsonIgnore]
        public string? Resource { get; set; } = "recording/info";
        [JsonIgnore]
        public Method RequestType { get; set; } = Method.Get;

        public Task<RestRequest> BuildRequestAsync()
        {
            var request = new RestRequest(Category + "/" + Resource, RequestType);
            
            request.AddQueryParameter("recording", RecordingId);

            return Task.FromResult(request);
        }

        public GetCallRecordingInfoRequest(string recordingId)
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
