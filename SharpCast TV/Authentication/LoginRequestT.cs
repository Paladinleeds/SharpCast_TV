// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var loginRequestT = LoginRequestT.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LoginRequestT
    {
        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }
    }

    /*public partial class LoginRequestT
    {
        public static LoginRequestT FromJson(string json) => JsonConvert.DeserializeObject<LoginRequestT>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LoginRequestT self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
