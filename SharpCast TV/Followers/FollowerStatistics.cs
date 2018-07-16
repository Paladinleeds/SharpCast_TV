using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class FollowerStatistics
    {
        [JsonProperty("followers")]
        public IList<Follower> Followers { get; set; }
    }

    public class FollowerStats
    {

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("followers")]
        public string Followers { get; set; }
    }
}
