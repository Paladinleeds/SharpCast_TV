// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var data = UserAccessLevels.FromJson(jsonString);
//
// WARNING: If you have never been granted Moderator or Editor in :channel, this API will only return isSubscriber and isFollower

namespace QuickType
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class UserAccessLevels
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("access_user_id")]
        public string AccessUserId { get; set; }

        [JsonProperty("settings")]
        public string Settings { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("livestreams")]
        public string Livestreams { get; set; }

        [JsonProperty("partner")]
        public object Partner { get; set; }

        [JsonProperty("broadcast")]
        public string Broadcast { get; set; }

        [JsonProperty("videos")]
        public string Videos { get; set; }

        [JsonProperty("recordings")]
        public string Recordings { get; set; }

        [JsonProperty("statistics")]
        public string Statistics { get; set; }

        [JsonProperty("inbox")]
        public string Inbox { get; set; }

        [JsonProperty("revenues")]
        public string Revenues { get; set; }

        [JsonProperty("chat")]
        public string Chat { get; set; }

        [JsonProperty("following")]
        public string Following { get; set; }

        [JsonProperty("teams")]
        public string Teams { get; set; }

        [JsonProperty("subscriptions")]
        public string Subscriptions { get; set; }

        [JsonProperty("admin")]
        public object Admin { get; set; }

        [JsonProperty("superadmin")]
        public object Superadmin { get; set; }

        [JsonProperty("payments")]
        public string Payments { get; set; }

        [JsonProperty("isSubscriber")]
        public bool IsSubscriber { get; set; }

        [JsonProperty("isFollower")]
        public bool IsFollower { get; set; }
    }
}

