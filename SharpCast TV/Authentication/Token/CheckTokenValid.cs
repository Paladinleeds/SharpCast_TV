// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var checkTokenValid = CheckTokenValid.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CheckTokenValid
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }

    /*public partial class CheckTokenValid
    {
        public static CheckTokenValid FromJson(string json) => JsonConvert.DeserializeObject<CheckTokenValid>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CheckTokenValid self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
