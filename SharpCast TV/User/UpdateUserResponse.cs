// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var data = UpdateUserResponse.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class UpdateUserResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

