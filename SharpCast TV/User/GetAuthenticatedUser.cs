// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = GetAuthenticatedUser.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class GetAuthenticatedUser
    {
        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("videos")]
        public int Videos { get; set; }

        [JsonProperty("recordings")]
        public int Recordings { get; set; }

        [JsonProperty("teams")]
        public int Teams { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_status")]
        public int UserStatus { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_cover")]
        public string UserCover { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("user_partner")]
        public int UserPartner { get; set; }

        [JsonProperty("partner_type")]
        public string PartnerType { get; set; }

        [JsonProperty("user_beta_profile")]
        public int UserBetaProfile { get; set; }

        [JsonProperty("media_is_live")]
        public int MediaIsLive { get; set; }

        [JsonProperty("media_live_since")]
        public System.DateTime MediaLiveSince { get; set; }

        [JsonProperty("user_media_id")]
        public int UserMediaId { get; set; }

        [JsonProperty("twitter_account")]
        public string TwitterAccount { get; set; }

        [JsonProperty("twitter_enabled")]
        public int TwitterEnabled { get; set; }

        [JsonProperty("livestream_count")]
        public int LivestreamCount { get; set; }
    }
}

