// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var runCommercialBreakRequest = RunCommercialBreakRequest.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RunCommercialBreakRequest
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }
    }

    /*public partial class RunCommercialBreakRequest
    {
        public static RunCommercialBreakRequest FromJson(string json) => JsonConvert.DeserializeObject<RunCommercialBreakRequest>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RunCommercialBreakRequest self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
