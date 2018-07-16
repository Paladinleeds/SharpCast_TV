using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// WARNING: If total views = zero, "total live views" will return a value of "false"

namespace SharpCastTV
{
    public class TotalViews
    {
        [JsonProperty("total_live_views")]
        public string TotalLiveViews { get; set; }
    }
}
