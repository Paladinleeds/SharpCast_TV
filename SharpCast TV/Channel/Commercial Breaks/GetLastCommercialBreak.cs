// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var getLastCommercialBreak = GetLastCommercialBreak.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetLastCommercialBreak
    {
        [JsonProperty("seconds_ago")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long SecondsAgo { get; set; }

        [JsonProperty("ad_count")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long AdCount { get; set; }

        [JsonProperty("timeout")]
        public long Timeout { get; set; }
    }

    /*public partial class GetLastCommercialBreak
    {
        public static GetLastCommercialBreak FromJson(string json) => JsonConvert.DeserializeObject<GetLastCommercialBreak>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetLastCommercialBreak self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
