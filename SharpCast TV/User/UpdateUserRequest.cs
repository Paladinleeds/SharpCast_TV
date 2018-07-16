// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var data = UpdateUserRequest.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class UpdateUserRequest
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; set; }

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }
    }
}
