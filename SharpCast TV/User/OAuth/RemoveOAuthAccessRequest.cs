// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = RemoveOAuthRequest.FromJson(jsonString);

namespace QuickType
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
