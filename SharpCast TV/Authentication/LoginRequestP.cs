// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var loginRequestP = LoginRequestP.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LoginRequestP
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("pass")]
        public string Pass { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }
    }

    /*public partial class LoginRequestP
    {
        public static LoginRequestP FromJson(string json) => JsonConvert.DeserializeObject<LoginRequestP>(json, SharpCastTV.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LoginRequestP self) => JsonConvert.SerializeObject(self, SharpCastTV.Converter.Settings);
    }*/
}
