// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var requestTokenResponse = RequestTokenResponse.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RequestTokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }

    /*public partial class RequestTokenResponse
    {
        public static RequestTokenResponse FromJson(string json) => JsonConvert.DeserializeObject<RequestTokenResponse>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RequestTokenResponse self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
