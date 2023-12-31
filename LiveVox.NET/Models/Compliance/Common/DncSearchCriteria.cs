﻿using LiveVox.NET.Models.Compliance.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LiveVox.NET.Converter;

namespace LiveVox.NET.Models.Compliance.Common
{
    public class DncSearchCriteria
    {
        /// <summary>
        /// Gets or sets the type of the DNC entry (DAILY or PERMANENT).
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DncEntryType Type { get; set; }

        /// <summary>
        /// Gets or sets the date and time after which a DNC entry must have been created or modified.
        /// </summary>
        [JsonPropertyName("modifiedAfter")]
        [JsonConverter(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
        public DateTimeOffset ModifiedAfter { get; set; }

        /// <summary>
        /// Gets or sets an array of Service IDs to further filter the list of matching DNC entries.
        /// If Service IDs are included in the request, only DNC entries associated with one of those Service IDs will be returned.
        /// </summary>
        [JsonPropertyName("service")]
        public List<int> Service { get; set; }
    }
}
