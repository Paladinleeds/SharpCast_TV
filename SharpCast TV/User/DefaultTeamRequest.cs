// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = DefaultTeamRequest.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class DefaultTeamRequest
    {
        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }
}

