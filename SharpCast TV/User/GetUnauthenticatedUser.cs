// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var data = GetUnauthenticatedUser.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class GetUnauthenticatedUser
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_cover")]
        public string UserCover { get; set; }

        [JsonProperty("user_status")]
        public string UserStatus { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("user_is_broadcaster")]
        public bool UserIsBroadcaster { get; set; }

        [JsonProperty("followers")]
        public string Followers { get; set; }

        [JsonProperty("user_partner")]
        public string UserPartner { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("is_live")]
        public string IsLive { get; set; }

        [JsonProperty("live_since")]
        public System.DateTime LiveSince { get; set; }

        [JsonProperty("twitter_account")]
        public string TwitterAccount { get; set; }

        [JsonProperty("twitter_enabled")]
        public string TwitterEnabled { get; set; }

        [JsonProperty("user_beta_profile")]
        public string UserBetaProfile { get; set; }
    }
}

