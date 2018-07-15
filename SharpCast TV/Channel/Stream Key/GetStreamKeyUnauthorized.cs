// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var getStreamKeyUnauthorized = GetStreamKeyUnauthorized.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetStreamKeyUnauthorized
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }
    }

    public partial class GetStreamKeyUnauthorized
    {
        public static GetStreamKeyUnauthorized FromJson(string json) => JsonConvert.DeserializeObject<GetStreamKeyUnauthorized>(json, QuickType.Converter.Settings);
    }
}
