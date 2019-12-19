﻿using Newtonsoft.Json;

namespace DeleteAgency.Kentico11.TinyPng.Models
{
    public partial class TinyPngShrinkResponseInput
    {
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}