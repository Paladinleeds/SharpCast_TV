using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class HostersList
    {
        [JsonProperty("hosters")]
        public IList<Hoster> Hosters { get; set; }
    }

    public class Hoster
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }
    }
}
