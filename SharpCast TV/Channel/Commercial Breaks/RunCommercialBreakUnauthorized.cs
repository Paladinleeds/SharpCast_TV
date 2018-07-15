// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var runCommercialBreakUnauthorized = RunCommercialBreakUnauthorized.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RunCommercialBreakUnauthorized
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }
    }

    /*public partial class RunCommercialBreakUnauthorized
    {
        public static RunCommercialBreakUnauthorized FromJson(string json) => JsonConvert.DeserializeObject<RunCommercialBreakUnauthorized>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RunCommercialBreakUnauthorized self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
