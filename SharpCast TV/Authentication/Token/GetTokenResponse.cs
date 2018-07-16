// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var getTokenResponse = GetTokenResponse.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetTokenResponse
    {
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }
    }

    /*public partial class GetTokenResponse
    {
        public static GetTokenResponse FromJson(string json) => JsonConvert.DeserializeObject<GetTokenResponse>(json, SharpCastTV.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetTokenResponse self) => JsonConvert.SerializeObject(self, SharpCastTV.Converter.Settings);
    }*/
}

