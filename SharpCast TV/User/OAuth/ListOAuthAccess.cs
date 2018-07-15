// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCast_TV;
//
//    var listOAuthAccess = ListOAuthAccess.FromJson(jsonString);

namespace QuickType.User.OAuth
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ListOAuthAccess
    {
        [JsonProperty("apps")]
        public App[] Apps { get; set; }
    }

    public partial class App
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
