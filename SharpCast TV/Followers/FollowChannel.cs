using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCast_TV.Followers
{
    class FollowChannel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("follow_id")]
        public string FollowId { get; set; }
    }
}
