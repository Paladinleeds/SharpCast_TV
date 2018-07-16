// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var tokenGetUser = TokenGetUser.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class TokenGetUser
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }

    /*public partial class TokenGetUser
    {
        public static TokenGetUser FromJson(string json) => JsonConvert.DeserializeObject<TokenGetUser>(json, SharpCastTV.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this TokenGetUser self) => JsonConvert.SerializeObject(self, SharpCastTV.Converter.Settings);
    }*/
}
