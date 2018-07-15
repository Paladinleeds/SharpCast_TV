// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var runCommercialBreakResponse = RunCommercialBreakResponse.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RunCommercialBreakResponse
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public Params Params { get; set; }
    }

    public partial class Params
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("count")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long Count { get; set; }

        [JsonProperty("delay")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long Delay { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }

    /*public partial class RunCommercialBreakResponse
    {
        public static RunCommercialBreakResponse FromJson(string json) => JsonConvert.DeserializeObject<RunCommercialBreakResponse>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RunCommercialBreakResponse self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
