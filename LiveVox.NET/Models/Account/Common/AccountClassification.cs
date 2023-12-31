﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiveVox.NET.Models.Account.Common
{
    public class AccountClassification
    {
        /// <summary>
        /// A number indicating the sequence in the display.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// Name of the classification & Account.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the classification and accountId.
        /// </summary>
        [JsonPropertyName("id")]
        public int ClassificationId { get; set; }
    }
}
