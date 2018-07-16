// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var data = CheckVerifiedEmail.FromJson(jsonString);
//
// WARNING: CheckVerifiedEmail might not currently work. Attempts to fix it are underway if required. Please bear with me.

namespace SharpCastTV
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class Welcome
    {
        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("user")]
        public User_Catch User { get; set; }
    }

    public partial class Request
    {
        [JsonProperty("this")]
        public string This { get; set; }
    }

    public partial class User_Catch
    {
        [JsonProperty("user_activated")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long UserActivated { get; set; }
    }

    /*public partial class CheckVerifiedEmail
    {
        public static CheckVerifiedEmail FromJson(string json) => JsonConvert.DeserializeObject<CheckVerifiedEmail>(json, Converter.Settings);
    }*/
}

