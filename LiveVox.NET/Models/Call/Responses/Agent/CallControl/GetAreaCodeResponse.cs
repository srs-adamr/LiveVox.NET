﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Base;

namespace LiveVox.NET.Models.Call.Responses.Agent.CallControl
{
    public class GetAreaCodeResponse : ILiveVoxResponse
    {
        /// <summary>
        /// Start time of the area code.
        /// </summary>
        [JsonPropertyName("startTime")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// End time of the area code.
        /// </summary>
        [JsonPropertyName("endTime")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Time zone
        /// </summary>
        
        [JsonPropertyName("timeZone")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TimeZone TimeZone { get; set; }
    }
}
