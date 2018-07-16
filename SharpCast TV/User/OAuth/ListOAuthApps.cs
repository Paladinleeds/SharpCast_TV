// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var data = ListOAuthApps.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class ListOAuthApps
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("apps")]
        public App[] Apps { get; set; }
    }

    public partial class App
    {
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("app_name")]
        public string AppName { get; set; }

        [JsonProperty("app_note")]
        public string AppNote { get; set; }

        [JsonProperty("app_enabled")]
        public string AppEnabled { get; set; }

        [JsonProperty("app_redirect_uri")]
        public string AppRedirectUri { get; set; }

        [JsonProperty("app_token")]
        public string AppToken { get; set; }

        [JsonProperty("app_secret")]
        public string AppSecret { get; set; }

        [JsonProperty("app_user_id")]
        public string AppUserId { get; set; }
    }
}
