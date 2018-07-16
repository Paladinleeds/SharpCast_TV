using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class CheckFollowing
    {
        [JsonProperty("following")]
        public FollowingStatus Following { get; set; }
    }

    public class FollowingStatus
    {

        [JsonProperty("follow_id")]
        public string FollowId { get; set; }

        [JsonProperty("follower_user_id")]
        public string FollowerUserId { get; set; }

        [JsonProperty("follower_notify")]
        public string FollowerNotify { get; set; }
    }

}
