using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class GetFollowers
    {
        [JsonProperty("request")]
        public GetFollowerRequest Request { get; set; }

        [JsonProperty("followers")]
        public IList<Follower> Followers { get; set; }

        [JsonProperty("max_results")]
        public string MaxResults { get; set; }
    }

    public class GetFollowerRequest
    {
        [JsonProperty("this")]
        public string This { get; set; }
    }

    public class Follower
    {
        [JsonProperty("followers")]
        public string Followers { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("follow_id")]
        public string FollowId { get; set; }

        [JsonProperty("follower_user_id")]
        public string FollowerUserId { get; set; }

        [JsonProperty("follower_notify")]
        public string FollowerNotify { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }
    }
}
