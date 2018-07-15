// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var getTokenRequest = GetTokenRequest.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetTokenRequest
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("pass")]
        public string Pass { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }
    }

    /*public partial class GetTokenRequest
    {
        public static GetTokenRequest FromJson(string json) => JsonConvert.DeserializeObject<GetTokenRequest>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetTokenRequest self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
