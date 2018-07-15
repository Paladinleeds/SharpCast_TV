// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var checkTokenInvalid = CheckTokenInvalid.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CheckTokenInvalid
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }
    }

    /*public partial class CheckTokenInvalid
    {
        public static CheckTokenInvalid FromJson(string json) => JsonConvert.DeserializeObject<CheckTokenInvalid>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CheckTokenInvalid self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
