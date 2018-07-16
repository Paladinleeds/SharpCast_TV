using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class UpdateWOTAccount
    {
        [JsonProperty("wot_account")]
        public string WotAccount { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }
    }

    public class UpdateLOLAccount
    {
        [JsonProperty("lol_account")]
        public string LolAccount { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("lol_region")]
        public string LolRegion { get; set; }
    }
}
