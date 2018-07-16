// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var data = RemoveOAuthRequest.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class RemoveOAuthAccessRequest
    {
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }
    }
}
