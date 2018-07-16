// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var requestTokenRequest = RequestTokenRequest.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RequestTokenRequest
    {
        [JsonProperty("request_token")]
        public string RequestToken { get; set; }

        [JsonProperty("app_token")]
        public string AppToken { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    /*public partial class RequestTokenRequest
    {
        public static RequestTokenRequest FromJson(string json) => JsonConvert.DeserializeObject<RequestTokenRequest>(json, SharpCastTV.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RequestTokenRequest self) => JsonConvert.SerializeObject(self, SharpCastTV.Converter.Settings);
    }*/
}
