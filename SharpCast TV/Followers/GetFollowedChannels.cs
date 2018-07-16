using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class GetFollowedChannels
    {
        [JsonProperty("request")]
        public FollowedChannelsRequest Request { get; set; }

        [JsonProperty("following")]
        public IList<Following> Following { get; set; }

        [JsonProperty("max_results")]
        public string MaxResults { get; set; }
    }

    public class FollowedChannelsRequest
    {
        [JsonProperty("this")]
        public string This { get; set; }
    }

    public class Following
    {
        [JsonProperty("followers")]
        public string Followers { get; set; }

        [JsonProperty("videos")]
        public string Videos { get; set; }

        [JsonProperty("recordings")]
        public string Recordings { get; set; }

        [JsonProperty("teams")]
        public string Teams { get; set; }

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
