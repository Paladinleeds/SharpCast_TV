using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class LiveStatus
    {
        [JsonProperty("media_is_live")]
        public string MediaIsLive { get; set; }

        [JsonProperty("media_views")]
        public string MediaViews { get; set; }
    }
}
